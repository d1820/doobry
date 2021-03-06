﻿using CosmosManager.Domain;
using CosmosManager.Extensions;
using CosmosManager.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace CosmosManager.QueryRunners
{
    public class UpdateByIdQueryRunner : IQueryRunner
    {
        private int MAX_DEGREE_PARALLEL = 5;
        private IQueryStatementParser _queryParser;
        private readonly ITransactionTask _transactionTask;

        public UpdateByIdQueryRunner(ITransactionTask transactionTask, IQueryStatementParser queryStatementParser)
        {
            _queryParser = queryStatementParser;
            _transactionTask = transactionTask;
        }

        public bool CanRun(QueryParts queryParts)
        {
            return queryParts.CleanQueryType.Equals(Constants.QueryParsingKeywords.UPDATE, StringComparison.InvariantCultureIgnoreCase)
                && !queryParts.CleanQueryBody.Equals("*")
                && !string.IsNullOrEmpty(queryParts.CleanQueryUpdateBody)
                && !string.IsNullOrEmpty(queryParts.CleanQueryUpdateType);
        }

        public async Task<(bool success, IReadOnlyCollection<object> results)> RunAsync(IDocumentStore documentStore, Connection connection,  QueryParts queryParts, bool logStats, ILogger logger, CancellationToken cancellationToken, Dictionary<string, IReadOnlyCollection<object>> variables = null)
        {
            try
            {
                if (!queryParts.IsValidQuery())
                {
                    logger.LogError("Invalid Query. Aborting Update.");
                    return (false, null);
                }

                var ids = queryParts.CleanQueryBody.Split(new[] { ',' });

                if (queryParts.CleanQueryUpdateType == Constants.QueryParsingKeywords.REPLACE && ids.Length > 1)
                {
                    var errorMessage = $"{Constants.QueryParsingKeywords.REPLACE} only supports replacing 1 document at a time.";
                    logger.LogError(errorMessage);
                    return (false, null);
                }

                if (queryParts.IsTransaction)
                {
                    logger.LogInformation($"Transaction Created. TransactionId: {queryParts.TransactionId}");
                    await _transactionTask.BackuQueryAsync(connection.Name, connection.Database, queryParts.CollectionName, queryParts.TransactionId, queryParts.CleanOrginalQuery);
                }
                var partitionKeyPath = await documentStore.LookupPartitionKeyPath(connection.Database, queryParts.CollectionName);

                var updateCount = 0;
                var actionTransactionCacheBlock = new ActionBlock<string>(async documentId =>
                                                                       {
                                                                           //this handles transaction saving for recovery
                                                                           await documentStore.ExecuteAsync(connection.Database, queryParts.CollectionName,
                                                                                         async (IDocumentExecuteContext context) =>
                                                                                         {
                                                                                             if (cancellationToken.IsCancellationRequested)
                                                                                             {
                                                                                                 throw new TaskCanceledException("Task has been requested to cancel.");
                                                                                             }
                                                                                             JObject jDoc = null;
                                                                                             if (queryParts.IsTransaction)
                                                                                             {
                                                                                                 var backupResult = await _transactionTask.BackupAsync(context, connection.Name, connection.Database, queryParts.CollectionName, queryParts.TransactionId, logger, documentId);
                                                                                                 if (!backupResult.isSuccess)
                                                                                                 {
                                                                                                     logger.LogError($"Unable to backup document {documentId}. Skipping Update.");
                                                                                                     return false;
                                                                                                 }
                                                                                                 jDoc = backupResult.document;
                                                                                             }

                                                                                             if (queryParts.IsReplaceUpdateQuery())
                                                                                             {
                                                                                                 var fullJObjectToUpdate = JObject.Parse(queryParts.CleanQueryUpdateBody);
                                                                                                 var fullJObjectPartionKeyValue = fullJObjectToUpdate.SelectToken(partitionKeyPath).ToString();
                                                                                                 var fullJObjectUpdatedDoc = await context.UpdateAsync(fullJObjectToUpdate, new RequestOptions
                                                                                                 {
                                                                                                     PartitionKey = fullJObjectPartionKeyValue
                                                                                                 });
                                                                                                 if (fullJObjectUpdatedDoc != null)
                                                                                                 {
                                                                                                     Interlocked.Increment(ref updateCount);
                                                                                                     logger.LogInformation($"Updated {documentId}");
                                                                                                 }
                                                                                                 else
                                                                                                 {
                                                                                                     logger.LogInformation($"Document {documentId} unable to be updated.");
                                                                                                 }
                                                                                                 return true;
                                                                                             }

                                                                                             //this is a partial update
                                                                                             if (jDoc == null)
                                                                                             {
                                                                                                 //this would only need to run if not in a transaction, because in a transaction we have already queried for the doc and have it.
                                                                                                 var queryToFindOptions = new QueryOptions
                                                                                                 {
                                                                                                     PopulateQueryMetrics = false,
                                                                                                     EnableCrossPartitionQuery = true,
                                                                                                     MaxItemCount = 1,
                                                                                                 };
                                                                                                 //we have to query to find the partitionKey value so we can do the delete
                                                                                                 var queryToFind = context.QueryAsSql<object>($"SELECT * FROM {queryParts.CollectionName} WHERE {queryParts.CollectionName}.id = '{documentId.CleanId()}'", queryToFindOptions);
                                                                                                 var queryResultDoc = (await queryToFind.ConvertAndLogRequestUnits(false, logger)).FirstOrDefault();
                                                                                                 if (queryResultDoc == null)
                                                                                                 {
                                                                                                     logger.LogInformation($"Document {documentId} not found. Skipping Update");
                                                                                                     return false;
                                                                                                 }
                                                                                                 jDoc = JObject.FromObject(queryResultDoc);
                                                                                             }
                                                                                             var partionKeyValue = jDoc.SelectToken(partitionKeyPath).ToString();

                                                                                             var partialDoc = JObject.Parse(queryParts.CleanQueryUpdateBody);

                                                                                             //ensure the partial update is not trying to update id or the partition key
                                                                                             var pToken = partialDoc.SelectToken(partitionKeyPath);
                                                                                             var idToken = partialDoc.SelectToken(Constants.DocumentFields.ID);
                                                                                             if (pToken != null || idToken != null)
                                                                                             {
                                                                                                 logger.LogError($"Updates are not allowed on ids or existing partition keys of a document. Skipping updated for document {documentId}.");
                                                                                                 return false;
                                                                                             }
                                                                                             var shouldUpdateToEmptyArray = partialDoc.HasEmptyJArray();
                                                                                             jDoc.Merge(partialDoc, new JsonMergeSettings
                                                                                             {
                                                                                                 MergeArrayHandling = shouldUpdateToEmptyArray ? MergeArrayHandling.Replace : MergeArrayHandling.Merge,
                                                                                                 MergeNullValueHandling = MergeNullValueHandling.Merge
                                                                                             });

                                                                                             //save
                                                                                             var updatedDoc = await context.UpdateAsync(jDoc, new RequestOptions
                                                                                             {
                                                                                                 PartitionKey = partionKeyValue
                                                                                             });
                                                                                             if (updatedDoc != null)
                                                                                             {
                                                                                                 Interlocked.Increment(ref updateCount);
                                                                                                 logger.LogInformation($"Updated {documentId}");
                                                                                             }
                                                                                             else
                                                                                             {
                                                                                                 logger.LogInformation($"Document {documentId} unable to be updated.");
                                                                                             }

                                                                                             return true;
                                                                                         }, cancellationToken);
                                                                       },
                                                                       new ExecutionDataflowBlockOptions
                                                                       {
                                                                           MaxDegreeOfParallelism = MAX_DEGREE_PARALLEL,
                                                                           CancellationToken = cancellationToken
                                                                       });

                foreach (var id in ids)
                {
                    actionTransactionCacheBlock.Post(id);
                }
                actionTransactionCacheBlock.Complete();
                await actionTransactionCacheBlock.Completion;
                logger.LogInformation($"Updated {updateCount} out of {ids.Length}");
                if (queryParts.IsTransaction && updateCount > 0)
                {
                    logger.LogInformation($"To rollback execute: ROLLBACK {queryParts.TransactionId}");
                }
                return (true, null);
            }
            catch (Exception ex)
            {
                var errorMessage = $"Unable to run {Constants.QueryParsingKeywords.UPDATE} query.";
                if (queryParts.CleanQueryUpdateType == Constants.QueryParsingKeywords.REPLACE)
                {
                    errorMessage += $"{Constants.QueryParsingKeywords.REPLACE} only supports replacing 1 document at a time.";
                }
                logger.Log(LogLevel.Error, new EventId(), errorMessage, ex);
                return (false, null);
            }
        }
    }
}