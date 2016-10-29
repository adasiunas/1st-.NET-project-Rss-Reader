namespace rssReaderDemo
{
    partial class rssReader
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Daily news");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Lithuania");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("World news");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Science and IT");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Sport");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Other");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.articlesTabControl = new System.Windows.Forms.TabControl();
            this.unreadArticlesTab = new System.Windows.Forms.TabPage();
            this.feedList = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.feedNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Link = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.readArticlesTab = new System.Windows.Forms.TabPage();
            this.readArticlesList = new System.Windows.Forms.ListView();
            this.titleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pubDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkToWebsite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkToDomain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.feedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.readAllTab = new System.Windows.Forms.TabPage();
            this.readAllList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.readButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.urlGroup = new System.Windows.Forms.GroupBox();
            this.readAll = new System.Windows.Forms.Button();
            this.urlTreeView = new System.Windows.Forms.TreeView();
            this.removeButton = new System.Windows.Forms.Button();
            this.Feed = new System.Windows.Forms.GroupBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.articlesTabControl.SuspendLayout();
            this.unreadArticlesTab.SuspendLayout();
            this.readArticlesTab.SuspendLayout();
            this.readAllTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.urlGroup.SuspendLayout();
            this.Feed.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.articlesTabControl);
            this.groupBox1.Location = new System.Drawing.Point(299, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Latest Articles";
            // 
            // articlesTabControl
            // 
            this.articlesTabControl.Controls.Add(this.unreadArticlesTab);
            this.articlesTabControl.Controls.Add(this.readArticlesTab);
            this.articlesTabControl.Controls.Add(this.readAllTab);
            this.articlesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.articlesTabControl.Location = new System.Drawing.Point(3, 16);
            this.articlesTabControl.Name = "articlesTabControl";
            this.articlesTabControl.SelectedIndex = 0;
            this.articlesTabControl.Size = new System.Drawing.Size(576, 307);
            this.articlesTabControl.TabIndex = 0;
            // 
            // unreadArticlesTab
            // 
            this.unreadArticlesTab.Controls.Add(this.feedList);
            this.unreadArticlesTab.Location = new System.Drawing.Point(4, 22);
            this.unreadArticlesTab.Name = "unreadArticlesTab";
            this.unreadArticlesTab.Padding = new System.Windows.Forms.Padding(3);
            this.unreadArticlesTab.Size = new System.Drawing.Size(568, 281);
            this.unreadArticlesTab.TabIndex = 0;
            this.unreadArticlesTab.Text = "UNREAD";
            this.unreadArticlesTab.UseVisualStyleBackColor = true;
            // 
            // feedList
            // 
            this.feedList.AllowColumnReorder = true;
            this.feedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.feedNameColumn,
            this.Date,
            this.Link});
            this.feedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedList.Location = new System.Drawing.Point(3, 3);
            this.feedList.Name = "feedList";
            this.feedList.Size = new System.Drawing.Size(562, 275);
            this.feedList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.feedList.TabIndex = 2;
            this.feedList.UseCompatibleStateImageBehavior = false;
            this.feedList.View = System.Windows.Forms.View.Details;
            this.feedList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.feedList_ColumnClick);
            this.feedList.SelectedIndexChanged += new System.EventHandler(this.feedList_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Tag = "1";
            this.Title.Text = "Title";
            this.Title.Width = 440;
            // 
            // feedNameColumn
            // 
            this.feedNameColumn.Text = "Feed";
            this.feedNameColumn.Width = 0;
            // 
            // Date
            // 
            this.Date.Tag = "1";
            this.Date.Text = "Pub. Date";
            this.Date.Width = 92;
            // 
            // Link
            // 
            this.Link.Text = "Link";
            this.Link.Width = 0;
            // 
            // readArticlesTab
            // 
            this.readArticlesTab.Controls.Add(this.readArticlesList);
            this.readArticlesTab.Location = new System.Drawing.Point(4, 22);
            this.readArticlesTab.Name = "readArticlesTab";
            this.readArticlesTab.Padding = new System.Windows.Forms.Padding(3);
            this.readArticlesTab.Size = new System.Drawing.Size(568, 281);
            this.readArticlesTab.TabIndex = 1;
            this.readArticlesTab.Text = "READ";
            this.readArticlesTab.UseVisualStyleBackColor = true;
            // 
            // readArticlesList
            // 
            this.readArticlesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readArticlesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumn,
            this.pubDate,
            this.linkToWebsite,
            this.linkToDomain,
            this.feedColumn});
            this.readArticlesList.Location = new System.Drawing.Point(3, 3);
            this.readArticlesList.Name = "readArticlesList";
            this.readArticlesList.Size = new System.Drawing.Size(562, 275);
            this.readArticlesList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.readArticlesList.TabIndex = 3;
            this.readArticlesList.UseCompatibleStateImageBehavior = false;
            this.readArticlesList.View = System.Windows.Forms.View.Details;
            this.readArticlesList.SelectedIndexChanged += new System.EventHandler(this.readArticlesList_SelectedIndexChanged);
            // 
            // titleColumn
            // 
            this.titleColumn.Text = "Title";
            this.titleColumn.Width = 440;
            // 
            // pubDate
            // 
            this.pubDate.DisplayIndex = 2;
            this.pubDate.Text = "Pub. Date";
            this.pubDate.Width = 79;
            // 
            // linkToWebsite
            // 
            this.linkToWebsite.DisplayIndex = 3;
            this.linkToWebsite.Text = "Link";
            this.linkToWebsite.Width = 0;
            // 
            // linkToDomain
            // 
            this.linkToDomain.DisplayIndex = 4;
            this.linkToDomain.Width = 0;
            // 
            // feedColumn
            // 
            this.feedColumn.DisplayIndex = 1;
            this.feedColumn.Width = 0;
            // 
            // readAllTab
            // 
            this.readAllTab.Controls.Add(this.readAllList);
            this.readAllTab.Location = new System.Drawing.Point(4, 22);
            this.readAllTab.Name = "readAllTab";
            this.readAllTab.Padding = new System.Windows.Forms.Padding(3);
            this.readAllTab.Size = new System.Drawing.Size(568, 281);
            this.readAllTab.TabIndex = 2;
            this.readAllTab.Text = "READ ALL";
            this.readAllTab.UseVisualStyleBackColor = true;
            // 
            // readAllList
            // 
            this.readAllList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readAllList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.readAllList.Location = new System.Drawing.Point(3, 3);
            this.readAllList.Name = "readAllList";
            this.readAllList.Size = new System.Drawing.Size(562, 275);
            this.readAllList.TabIndex = 4;
            this.readAllList.UseCompatibleStateImageBehavior = false;
            this.readAllList.View = System.Windows.Forms.View.Details;
            this.readAllList.SelectedIndexChanged += new System.EventHandler(this.readAllList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 440;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pub. Date";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Link";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.descriptionBox);
            this.groupBox2.Controls.Add(this.readButton);
            this.groupBox2.Location = new System.Drawing.Point(299, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionBox.Location = new System.Drawing.Point(6, 19);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(569, 59);
            this.descriptionBox.TabIndex = 2;
            // 
            // readButton
            // 
            this.readButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.readButton.Location = new System.Drawing.Point(480, 81);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 24);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // urlGroup
            // 
            this.urlGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.urlGroup.Controls.Add(this.readAll);
            this.urlGroup.Controls.Add(this.urlTreeView);
            this.urlGroup.Controls.Add(this.removeButton);
            this.urlGroup.Location = new System.Drawing.Point(12, 71);
            this.urlGroup.Name = "urlGroup";
            this.urlGroup.Size = new System.Drawing.Size(279, 383);
            this.urlGroup.TabIndex = 4;
            this.urlGroup.TabStop = false;
            this.urlGroup.Text = "Subscribtions";
            // 
            // readAll
            // 
            this.readAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.readAll.Location = new System.Drawing.Point(6, 356);
            this.readAll.Name = "readAll";
            this.readAll.Size = new System.Drawing.Size(86, 23);
            this.readAll.TabIndex = 6;
            this.readAll.Text = "Read all";
            this.readAll.UseVisualStyleBackColor = true;
            this.readAll.Click += new System.EventHandler(this.readAll_Click);
            // 
            // urlTreeView
            // 
            this.urlTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTreeView.Location = new System.Drawing.Point(6, 19);
            this.urlTreeView.Name = "urlTreeView";
            treeNode13.Checked = true;
            treeNode13.Name = "dailyNews";
            treeNode13.Text = "Daily news";
            treeNode14.Checked = true;
            treeNode14.Name = "Lithuania";
            treeNode14.Text = "Lithuania";
            treeNode15.Checked = true;
            treeNode15.Name = "worlsNews";
            treeNode15.Text = "World news";
            treeNode16.Checked = true;
            treeNode16.Name = "scieneNews";
            treeNode16.Text = "Science and IT";
            treeNode17.Checked = true;
            treeNode17.Name = "sportNews";
            treeNode17.Text = "Sport";
            treeNode18.Checked = true;
            treeNode18.Name = "otherNews";
            treeNode18.Text = "Other";
            this.urlTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            this.urlTreeView.Size = new System.Drawing.Size(262, 331);
            this.urlTreeView.TabIndex = 5;
            this.urlTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.urlTreeView_AfterSelect);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(183, 356);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(86, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Feed
            // 
            this.Feed.Controls.Add(this.categoryBox);
            this.Feed.Controls.Add(this.addButton);
            this.Feed.Controls.Add(this.urlBox);
            this.Feed.Location = new System.Drawing.Point(9, 0);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(282, 65);
            this.Feed.TabIndex = 5;
            this.Feed.TabStop = false;
            this.Feed.Text = "Feed URL";
            // 
            // categoryBox
            // 
            this.categoryBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Daily news",
            "Lithuania",
            "Sport",
            "Science and IT",
            "World news",
            "Other"});
            this.categoryBox.Location = new System.Drawing.Point(3, 16);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(206, 21);
            this.categoryBox.TabIndex = 2;
            this.categoryBox.Text = "Category";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(215, 28);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(57, 21);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // urlBox
            // 
            this.urlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.urlBox.Location = new System.Drawing.Point(3, 39);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(206, 20);
            this.urlBox.TabIndex = 0;
            this.urlBox.Text = "Enter your URL here";
            this.urlBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.urlBox_MouseClick);
            this.urlBox.Leave += new System.EventHandler(this.urlBox_Leave);
            this.urlBox.MouseLeave += new System.EventHandler(this.urlBox_MouseLeave);
            this.urlBox.MouseHover += new System.EventHandler(this.urlBox_MouseHover);
            this.urlBox.Validating += new System.ComponentModel.CancelEventHandler(this.urlBox_Validating);
            // 
            // rssReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 463);
            this.Controls.Add(this.Feed);
            this.Controls.Add(this.urlGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "rssReader";
            this.Text = "RSS READER";
            this.Load += new System.EventHandler(this.rssReader_Load);
            this.groupBox1.ResumeLayout(false);
            this.articlesTabControl.ResumeLayout(false);
            this.unreadArticlesTab.ResumeLayout(false);
            this.readArticlesTab.ResumeLayout(false);
            this.readAllTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.urlGroup.ResumeLayout(false);
            this.Feed.ResumeLayout(false);
            this.Feed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button readButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox urlGroup;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListView feedList;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Link;
        private System.Windows.Forms.TabControl articlesTabControl;
        private System.Windows.Forms.TabPage unreadArticlesTab;
        private System.Windows.Forms.TabPage readArticlesTab;
        private System.Windows.Forms.ListView readArticlesList;
        private System.Windows.Forms.ColumnHeader titleColumn;
        private System.Windows.Forms.ColumnHeader pubDate;
        private System.Windows.Forms.ColumnHeader linkToWebsite;
        private System.Windows.Forms.GroupBox Feed;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.ColumnHeader linkToDomain;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.TreeView urlTreeView;
        private System.Windows.Forms.Button readAll;
        private System.Windows.Forms.TabPage readAllTab;
        private System.Windows.Forms.ListView readAllList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader feedNameColumn;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader feedColumn;
    }
}

