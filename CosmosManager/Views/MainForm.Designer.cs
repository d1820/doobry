﻿namespace CosmosManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileQueryTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPreviousActionsLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCommandPromptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConnectionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editConnectionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCosmosManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.appStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCnnectionFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.transactionCacheSizeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fileTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabBackgroundPanel = new System.Windows.Forms.Panel();
            this.queryTabControl = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newQueryTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInFileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextTabs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duplicateTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addToCommandWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabBackgroundPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "json";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileQueryTabToolStripMenuItem,
            this.toolStripSeparator2,
            this.openFolderToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileQueryTabToolStripMenuItem
            // 
            this.newFileQueryTabToolStripMenuItem.Name = "newFileQueryTabToolStripMenuItem";
            this.newFileQueryTabToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newFileQueryTabToolStripMenuItem.Text = "New Query Tab";
            this.newFileQueryTabToolStripMenuItem.Click += new System.EventHandler(this.newFileQueryTabToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(153, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTransactionCacheToolStripMenuItem,
            this.viewPreviousActionsLogToolStripMenuItem,
            this.addToCommandWindowToolStripMenuItem,
            this.openCommandPromptToolStripMenuItem,
            this.toolStripSeparator1,
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewTransactionCacheToolStripMenuItem
            // 
            this.viewTransactionCacheToolStripMenuItem.Name = "viewTransactionCacheToolStripMenuItem";
            this.viewTransactionCacheToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.viewTransactionCacheToolStripMenuItem.Text = "View Transaction Cache";
            this.viewTransactionCacheToolStripMenuItem.Click += new System.EventHandler(this.viewTransactionCacheToolStripMenuItem_Click);
            // 
            // viewPreviousActionsLogToolStripMenuItem
            // 
            this.viewPreviousActionsLogToolStripMenuItem.Name = "viewPreviousActionsLogToolStripMenuItem";
            this.viewPreviousActionsLogToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.viewPreviousActionsLogToolStripMenuItem.Text = "View Previous Actions Log";
            this.viewPreviousActionsLogToolStripMenuItem.Click += new System.EventHandler(this.viewPreviousActionsLogToolStripMenuItem_Click);
            // 
            // openCommandPromptToolStripMenuItem
            // 
            this.openCommandPromptToolStripMenuItem.Name = "openCommandPromptToolStripMenuItem";
            this.openCommandPromptToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.openCommandPromptToolStripMenuItem.Text = "Open Application Prompt";
            this.openCommandPromptToolStripMenuItem.Click += new System.EventHandler(this.openCommandPromptToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadConnectionFileToolStripMenuItem,
            this.editConnectionFileToolStripMenuItem});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // loadConnectionFileToolStripMenuItem
            // 
            this.loadConnectionFileToolStripMenuItem.Name = "loadConnectionFileToolStripMenuItem";
            this.loadConnectionFileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.loadConnectionFileToolStripMenuItem.Text = "Load Connection File";
            this.loadConnectionFileToolStripMenuItem.Click += new System.EventHandler(this.loadConnectionFileToolStripMenuItem_Click);
            // 
            // editConnectionFileToolStripMenuItem
            // 
            this.editConnectionFileToolStripMenuItem.Name = "editConnectionFileToolStripMenuItem";
            this.editConnectionFileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.editConnectionFileToolStripMenuItem.Text = "Edit Connection File";
            this.editConnectionFileToolStripMenuItem.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guideToolStripMenuItem,
            this.reportABugToolStripMenuItem,
            this.aboutCosmosManagerToolStripMenuItem,
            this.toolStripSeparator4,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // guideToolStripMenuItem
            // 
            this.guideToolStripMenuItem.Name = "guideToolStripMenuItem";
            this.guideToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.guideToolStripMenuItem.Text = "Guide";
            this.guideToolStripMenuItem.Click += new System.EventHandler(this.guideToolStripMenuItem_Click);
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reportABugToolStripMenuItem.Text = "Report A Bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.reportABugToolStripMenuItem_Click);
            // 
            // aboutCosmosManagerToolStripMenuItem
            // 
            this.aboutCosmosManagerToolStripMenuItem.Name = "aboutCosmosManagerToolStripMenuItem";
            this.aboutCosmosManagerToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.aboutCosmosManagerToolStripMenuItem.Text = "About Cosmos Manager";
            this.aboutCosmosManagerToolStripMenuItem.Click += new System.EventHandler(this.aboutCosmosManagerToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(200, 6);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appStatusLabel,
            this.lblCnnectionFile,
            this.transactionCacheSizeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 602);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1229, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // appStatusLabel
            // 
            this.appStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.appStatusLabel.ForeColor = System.Drawing.Color.White;
            this.appStatusLabel.Name = "appStatusLabel";
            this.appStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.appStatusLabel.Text = "Ready";
            // 
            // lblCnnectionFile
            // 
            this.lblCnnectionFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblCnnectionFile.ForeColor = System.Drawing.Color.White;
            this.lblCnnectionFile.Name = "lblCnnectionFile";
            this.lblCnnectionFile.Size = new System.Drawing.Size(1070, 17);
            this.lblCnnectionFile.Spring = true;
            this.lblCnnectionFile.Text = "No Connection File Loaded";
            // 
            // transactionCacheSizeLabel
            // 
            this.transactionCacheSizeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.transactionCacheSizeLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.transactionCacheSizeLabel.ForeColor = System.Drawing.Color.White;
            this.transactionCacheSizeLabel.LinkColor = System.Drawing.Color.White;
            this.transactionCacheSizeLabel.Name = "transactionCacheSizeLabel";
            this.transactionCacheSizeLabel.Size = new System.Drawing.Size(105, 17);
            this.transactionCacheSizeLabel.Text = "Transaction Cache";
            this.transactionCacheSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transactionCacheSizeLabel.DoubleClick += new System.EventHandler(this.transactionCacheSizeLabel_DoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fileTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabBackgroundPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1229, 578);
            this.splitContainer1.SplitterDistance = 231;
            this.splitContainer1.TabIndex = 2;
            // 
            // fileTreeView
            // 
            this.fileTreeView.CausesValidation = false;
            this.fileTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileTreeView.ImageIndex = 0;
            this.fileTreeView.ImageList = this.imageList1;
            this.fileTreeView.Location = new System.Drawing.Point(0, 0);
            this.fileTreeView.Name = "fileTreeView";
            this.fileTreeView.SelectedImageIndex = 0;
            this.fileTreeView.Size = new System.Drawing.Size(231, 578);
            this.fileTreeView.TabIndex = 0;
            this.fileTreeView.TabStop = false;
            this.fileTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fileTreeView_NodeMouseClick);
            this.fileTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fileTreeView_NodeMouseDoubleClick);
            this.fileTreeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fileTreeView_MouseUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder");
            this.imageList1.Images.SetKeyName(1, "File");
            this.imageList1.Images.SetKeyName(2, "FolderOpen");
            // 
            // tabBackgroundPanel
            // 
            this.tabBackgroundPanel.BackColor = System.Drawing.SystemColors.Control;
            this.tabBackgroundPanel.Controls.Add(this.queryTabControl);
            this.tabBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.tabBackgroundPanel.Name = "tabBackgroundPanel";
            this.tabBackgroundPanel.Size = new System.Drawing.Size(994, 578);
            this.tabBackgroundPanel.TabIndex = 1;
            this.tabBackgroundPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabBackgroundPanel_MouseDoubleClick);
            // 
            // queryTabControl
            // 
            this.queryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.queryTabControl.Location = new System.Drawing.Point(0, 0);
            this.queryTabControl.Name = "queryTabControl";
            this.queryTabControl.SelectedIndex = 0;
            this.queryTabControl.Size = new System.Drawing.Size(994, 578);
            this.queryTabControl.TabIndex = 0;
            this.queryTabControl.Visible = false;
            this.queryTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.queryTabControl_DrawItem);
            this.queryTabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.queryTabControl_MouseDown);
            this.queryTabControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.queryTabControl_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newQueryTabToolStripMenuItem,
            this.createNewQueryToolStripMenuItem,
            this.openInFileExplorerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 70);
            // 
            // newQueryTabToolStripMenuItem
            // 
            this.newQueryTabToolStripMenuItem.Name = "newQueryTabToolStripMenuItem";
            this.newQueryTabToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newQueryTabToolStripMenuItem.Text = "New Query Tab";
            this.newQueryTabToolStripMenuItem.Click += new System.EventHandler(this.newQueryTabToolStripMenuItem_Click);
            // 
            // createNewQueryToolStripMenuItem
            // 
            this.createNewQueryToolStripMenuItem.Name = "createNewQueryToolStripMenuItem";
            this.createNewQueryToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.createNewQueryToolStripMenuItem.Text = "Create New Script";
            this.createNewQueryToolStripMenuItem.Click += new System.EventHandler(this.createNewQueryToolStripMenuItem_Click);
            // 
            // openInFileExplorerToolStripMenuItem
            // 
            this.openInFileExplorerToolStripMenuItem.Name = "openInFileExplorerToolStripMenuItem";
            this.openInFileExplorerToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.openInFileExplorerToolStripMenuItem.Text = "Open In File Explorer";
            this.openInFileExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInFileExplorerToolStripMenuItem_Click);
            // 
            // contextTabs
            // 
            this.contextTabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicateTabToolStripMenuItem});
            this.contextTabs.Name = "contextTabs";
            this.contextTabs.Size = new System.Drawing.Size(148, 26);
            // 
            // duplicateTabToolStripMenuItem
            // 
            this.duplicateTabToolStripMenuItem.Name = "duplicateTabToolStripMenuItem";
            this.duplicateTabToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.duplicateTabToolStripMenuItem.Text = "Duplicate Tab";
            this.duplicateTabToolStripMenuItem.Click += new System.EventHandler(this.duplicateTabToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.NotifyFilter = ((System.IO.NotifyFilters)((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName)));
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            // 
            // addToCommandWindowToolStripMenuItem
            // 
            this.addToCommandWindowToolStripMenuItem.Name = "addToCommandWindowToolStripMenuItem";
            this.addToCommandWindowToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.addToCommandWindowToolStripMenuItem.Text = "Add To Command Window";
            this.addToCommandWindowToolStripMenuItem.Click += new System.EventHandler(this.addToCommandWindowToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 624);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cosmos Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabBackgroundPanel.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TabControl queryTabControl;
        public System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loadConnectionFileToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel appStatusLabel;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem createNewQueryToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextTabs;
        public System.Windows.Forms.ToolStripMenuItem duplicateTabToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel transactionCacheSizeLabel;
        public System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem viewTransactionCacheToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem guideToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        public System.IO.FileSystemWatcher fileSystemWatcher1;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editConnectionFileToolStripMenuItem;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ToolStripMenuItem newQueryTabToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem newFileQueryTabToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.Panel tabBackgroundPanel;
        public System.Windows.Forms.ToolStripMenuItem aboutCosmosManagerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openInFileExplorerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem viewPreviousActionsLogToolStripMenuItem;
        public System.Windows.Forms.TreeView fileTreeView;
        private System.Windows.Forms.ToolStripStatusLabel lblCnnectionFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCommandPromptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToCommandWindowToolStripMenuItem;
    }
}

