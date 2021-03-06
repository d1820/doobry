﻿# Cosmos Manager Help Guide

## Setting up connections

Create a .json file that contains this structure for storing all of your cosmos connections. This is a user owned file so ConnectionKeys and Endpoints stay within the users environment.

```JSON
[
    {
        "Name": "Local Cosmos",
        "EndpointUrl": "https://localhost:8081/",
        "ConnectionKey": "KEY",
        "Database": "DBNAME"
    }
]
```

## Query files

Cosmos Manager uses a custom SQL query language that is a mixture of Cosmos and SQL syntax.

**Tip** When writing select statements the FROM must use the collection name and must match the casing used in Cosmos. The syntax parsers will read that and use it in the requests

*example:*  From Market

### SELECTS

#### SQL/Cosmos syntax

```SQL
SELECT * FROM Market WHERE Market.id = 'test'

SELECT * FROM Market m JOIN type IN m.Types WHERE m.id = 'test' AND type = 'whole'
```

### TRANSACTIONS

Cosmos Manager supports transactions for updates and deletes. Due to restrictions on how Cosmos operates this does not work in the traditional sense like SQL Transactions.

Transactions are achieved by creating file backups of each document that is apart of the update or delete statement. When the query statement executes a transactionId is created which when used with the ROLLBACK command allows for restoration of the changed documents.

To use transactions simply place **ASTRANSACTION** at the top of the query statement being ran.

The transactionId is broken down into collectionName_date_time_guid.

```TEXT
Market_20181014_060441_02632bc6-17c3-4bd8-a97b-268b2d4dac55
```

### DELETES

Deletes can be done in 2 way:

* By providing a list of documentIds that need to be deleted for a given collection.
* By deleting all that fulfill a WHERE clause statement

**Note:** Deletes do not use transactions by default and the proper SQL transaction syntax must be used to invoke a transaction.

#### SQL/Cosmos syntax

##### Delete by documentIds

```SQL
 ASTRANSACTION
 DELETE 'c32ee161-8dd2-4bf3-8cff-e4eb5acd5fb6','3989a227-ae55-4945-8e73-703ce17f9f78'
 FROM Market
```

##### Delete by WHERE clause

```SQL
ASTRANSACTION
DELETE *
FROM Market
WHERE Market.PartitionKey = 'List'
```

### ROLLBACKS

If transactions are used on a query the output will return the TransactionId and the ROLLBACK statement to use to rollback the changed or affected documents. For a rollback to work successfully the same connection, database, and collection must be used. This is done to help prevent a rollback of the wrong data to the wrong environment.

#### SQL/Cosmos syntax

```SQL
ROLLBACK Market_20181014_060441_02632bc6-17c3-4bd8-a97b-268b2d4dac55
```

### INSERTS

Two types of inserts can be preformed. Single record or and array of records. All insert data must be valid JSON and be able to properly be parsed.

#### SQL/Cosmos syntax

#### Single Document

```SQL
INSERT
{
    "id": "one",
    "PartitionKey": "TestKey",
    "LastModifiedOn": "0001-01-01T00:00:00-07:00",
    "LastModifiedBy": null,
    "CreatedOn": "2018-02-28T16:35:11.1404236-07:00",
    "CreatedBy": null
}
INTO Market
```

#### Multiple Documents

```SQL
INSERT
[{
    "id": "one",
    "PartitionKey": "TestKey",
    "LastModifiedOn": "0001-01-01T00:00:00-07:00",
    "LastModifiedBy": null,
    "CreatedOn": "2018-02-28T16:35:11.1404236-07:00",
    "CreatedBy": null
},
{
    "id": "two",
    "PartitionKey": "TestKey",
    "LastModifiedOn": "0001-01-01T00:00:00-07:00",
    "LastModifiedBy": null,
    "CreatedOn": "2018-02-28T16:35:11.1404236-07:00",
    "CreatedBy": null
}]
INTO Market
```

### Updates

Updates can be done in 2 way:

* By providing a list of documentIds that need to be updated for a given collection.
* By updating all that fulfill a WHERE clause statement

#### Updating an entire document

To update an entire document the Id of the document must be provided in the update statement.
When doing a full document replace only **one** document can be updated at a time.

##### SQL/Cosmos syntax

```SQL
ASTransaction
UPDATE '14e42d8c-7583-432f-8dd0-d80e699ef41f'
from Market
REPLACE {
    "id": "14e42d8c-7583-432f-8dd0-d80e699ef41f",
    "PartitionKey": "List",
    "Name": {
        "Key": "NewNameKey",
        "Text": "New Name"
    }
}
```

#### Updating a portion of a document

To update a part of the document the SET keyword is used.
This does an explicit merge of the new structure to the existing documents structure.
This means:

* Properties provided in the SET that do not exist in the document currently will be added to the document.
* Properties in the SET that have a **NULL** value will be added to the existing document as a **NULL** value property
* If an array of items is included in the SET will be merged to existing item in the document.

This is based on the index of the array item. So items in the SET **MUST** be in the same order as the current document else data may get corrupt or out of sync.

**Note:** When doing a partial update any attempt to change the "id" or "PartitionKey" of the document will throw an error.

##### SQL/Cosmos syntax

**ORIGINAL**

```JSON
{
    "Name": {
        "Key": "FirstNameKey",
        "Text": "First Name"
    }
}
```

**QUERY**

```SQL
ASTransaction
UPDATE '14e42d8c-7583-432f-8dd0-d80e699ef41f'
from Market
SET {
    "Name": {
        "Key": "NewNameKey",
        "Text": "New Name"
    },
    "Address": null
}
```

**MERGED RESULT**

```JSON
{
    "Name": {
        "Key": "NewNameKey",
        "Text": "New Name"
    }
    "Address" :null
}
```

**Note:** Updates do not use transactions by default and the proper SQL transaction syntax must be used to invoke a transaction.

### Multi-Statement Queries

Cosmos Manager supports being able to run a group of queries at once.
These query statements are ran synchronously and in the order written in the query window.
Each statement must be terminated with a semi-colon **(;)**

See **Select Query Results Into Variables** below to see how the results of one query can be used to fill in criteria to the next query.

#### SQL/Cosmos syntax

```SQL
SELECT *
FROM Market
WHERE Market.PartitionKey = 'List'
;

ASTRANSACTION
UPDATE 'Db71b8bf-2b51-4ed1-9dd6-724706a099e0'
FROM Market
SET
{
  "WalletId": null,
  "Phone": {
    "Number": "555-555-5555"
  }
}
;

DELETE 'test'
FROM Market
WHERE Market.PartitionKey = 'List'

```

### Select Query Results Into Variables

Cosmos Manager supports being able to select results into a variable and use the variable in additional query WHERE clauses.

The result that is stored in the variable is an array of documents. Because the results are documents json dot notation can be used to access values and sub properties.

Variable queries are still output to the application results window to data tracing can be done.

#### Limitations

* Variables can only be used with **IN()** statements
* Access sub arrays of a result document is not supported. However multiple variables can be created and used to accommodate sub array querying

##### SQL/Cosmos syntax

###### Selects

```SQL
@userProfile = Select * from Market m Where Contains(m.PartitionKey, 'UserProfile');
@product = Select * from Products p Where p.ProductLinkingId = '68cb0267-3087-4d40-84c5-ede71939e620';

@planTokens = Select ct.ProductPlanToken from Market m
JOIN ct IN m.Products
Where Contains(m.PartitionKey, 'User.Products') AND
m.UserId IN (@userProfile.id)
AND ct.ProductId IN (@product.id);

Select * from UserPayments w
Where w.PToken IN (@planTokens.ProductPToken);

```

###### Update

```SQL
@sublist = Select *
 from Market m
where m.PartitionKey = 'List' AND CONTAINS(m.Name.Key, 'type');

astransaction
UPDATE *
 from Market m
where m.PartitionKey = 'List' AND m.id IN (@sublist.id)
SET {
    "WesterId": 'update'
}
```

### Working With Dates

If you are using the default indexing with your collection in Cosmos one of the issues is the ability to filter on an exact date. Cosmos seems to have an issue doing an equals on a date field. This seems to be related to having the index defined as a range.

#### Default Indexes

```JSON
"indexes": [
    {
        "kind": "Range",
        "dataType": "Number",
        "precision": -1
    },
    {
        "kind": "Range",
        "dataType": "String",
        "precision": -1
    }
]
```

To allow for filtering on an exact date Cosmos Manager has **DATE_EQUALS**. This is used to create the range comparison for you and execute the query with the proper syntax

##### Filter Example

```SQL
SELECT c.UserId, li
From Market m
JOIN li IN c.LineItems
Where CONTAINS(m.PartitionKey, 'Order')
AND Date_Equals(li.OrderDate, '2019-06-30T17:00:00-07:00')
```

When this gets converted in Cosmos Manager it acuually creates and executes

```SQL
SELECT c.UserId, li
FROM Marketplace c
JOIN li IN c.LineItems
WHERE CONTAINS(c.PartitionKey, 'OrderHistory')
AND IS_NULL(li.Canceled)
AND (li.EffectiveDate >= '2019-07-01T00:00:00' AND li.EffectiveDate < '2019-07-01T00:00:01'
```

## Supported Applications

Cosmos Emulator Min Required Version 2.7.1.0. This requirement is due to the coupling of DocumentDB Nuget packages to the emulator installed locally. If you do not use the emulator this is not a requirement of using the application.
