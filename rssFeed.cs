using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static rssReaderDemo.Rss;
using rssReader;

namespace rssReaderDemo
{
    public partial class rssReader : Form
    {
        Subscribtion subsribtion = new Subscribtion();
        RssManager reader = new RssManager();
        Collection<Rss.Items> articlesList;
        Collection<Rss.Urls> subscriobtionsList;
        Collection<Rss.Items> readArticles = new Collection<Rss.Items>();
        Collection<Rss.Items> allArticles = new Collection<Items>();
        ListViewItem row;
        ListViewColumnSorter lvwColumnSorter;

        public rssReader()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.feedList.ListViewItemSorter = lvwColumnSorter;
        }
        #region Buttons

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                subsribtion.WebsiteUrl = urlBox.Text;
                subsribtion.Category = categoryBox.SelectedItem.ToString();
                subsribtion.AddSubscribtion();
                urlBox.Clear();
                printWebsites();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Provide URL adress!");
                throw new Exception(ex.ToString());
            }
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (feedList.SelectedItems.Count == 1)
                {
                    System.Diagnostics.Process.Start(feedList.SelectedItems[0].SubItems[3].Text);
                    row = feedList.SelectedItems[0];
                    setToSaveArticle();
                    feedList.SelectedItems[0].Remove();
                    row.SubItems.Add(descriptionBox.Text);
                    readArticlesList.Items.Add(row);
                }
                else
                {
                    System.Diagnostics.Process.Start(readArticlesList.SelectedItems[0].SubItems[2].Text);
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.ToString());
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (urlTreeView.SelectedNode.Nodes.Count == 0)
            {
                subsribtion.DeleteSubscribtion(urlTreeView.SelectedNode.Name);
                printWebsites();
            }
            else
            {
                MessageBox.Show("You need to select URL to remove it.");
            }
        }

        private void readAll_Click(object sender, EventArgs e)
        {
            if (readAllList.Items.Count > 0)
            {
                readAllList.Clear();
            }
            foreach (Rss.Urls subscribtion in subscriobtionsList)
            {
                reader.Url = subscribtion.LinkToWebsite;
                reader.GetFeed();
                articlesList = reader.RssItems;
                bool articleIsRead = false;
                for (int i = 0; i < articlesList.Count; i++)
                {
                    allArticles.Add(articlesList[i]);
                    foreach (ListViewItem check in readArticlesList.Items)
                    {
                        if (articlesList[i].Link == check.SubItems[2].Text)
                        {
                            articleIsRead = true;
                            break;
                        }
                    }
                    if (!articleIsRead)
                    {
                        row = new ListViewItem();
                        row.Text = articlesList[i].Title;
                        row.SubItems.Add(articlesList[i].Date.ToShortDateString());
                        row.SubItems.Add(articlesList[i].Link);
                        readAllList.Items.Add(row);
                    }
                    articleIsRead = false;
                }
            }
            articlesTabControl.SelectedTab = readAllTab;
        }

        #endregion

        #region SelectionsAndIndexChanges

        private void feedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (feedList.SelectedItems.Count == 1 && feedList.Columns[1].Width == 0)
            {
                for (int i = 0; i < articlesList.Count; i++)
                {
                    if (articlesList[i].Title == feedList.SelectedItems[0].Text)
                    {
                        descriptionBox.Text = articlesList[i].Description;
                    }
                }
            }
            else
            {
                if (feedList.SelectedItems.Count == 1)
                    for (int i = 0; i < allArticles.Count; i++)
                    {
                        if (allArticles[i].Title == feedList.SelectedItems[0].Text)
                        {
                            descriptionBox.Text = allArticles[i].Description;
                        }
                    }
            }
        }
        private void readArticlesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (readArticlesList.SelectedItems.Count == 1)
            {
                descriptionBox.Text = readArticlesList.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void urlTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!urlTreeView.SelectedNode.Checked)
            {
                feedList.Columns[1].Width = 0;
                try
                {
                    if (feedList.Items.Count > 0) feedList.Items.Clear();
                    reader.Url = urlTreeView.SelectedNode.Name;
                    reader.GetFeed();
                    articlesList = reader.RssItems;
                    bool articleIsRead = false;
                    for (int i = 0; i < articlesList.Count; i++)
                    {
                        foreach (ListViewItem check in readArticlesList.Items)
                        {
                            if (articlesList[i].Link == check.SubItems[2].Text)
                            {
                                articleIsRead = true;
                                break;
                            }
                        }
                        if (!articleIsRead)
                        {
                            row = new ListViewItem();
                            row.Text = articlesList[i].Title;
                            row.SubItems.Add(String.Empty);
                            row.SubItems.Add(articlesList[i].Date.ToShortDateString());
                            row.SubItems.Add(articlesList[i].Link);
                            feedList.Items.Add(row);
                        }
                        articleIsRead = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                feedList.Columns[1].Width = 80;
                feedList.Columns[0].Width = 380;
                allArticles.Clear();
                if (feedList.Items.Count > 0) feedList.Items.Clear();
                foreach (TreeNode node in urlTreeView.SelectedNode.Nodes)
                {
                    reader.Url = node.Name;
                    reader.GetFeed();
                    articlesList = reader.RssItems;
                    bool articleIsRead = false;
                    for (int i = 0; i < articlesList.Count; i++)
                    {
                        allArticles.Add(articlesList[i]);
                        foreach (ListViewItem check in readArticlesList.Items)
                        {
                            if (articlesList[i].Link == check.SubItems[2].Text)
                            {
                                articleIsRead = true;
                                break;
                            }
                        }
                        if (!articleIsRead)
                        {
                            row = new ListViewItem();
                            row.Text = articlesList[i].Title;
                            row.SubItems.Add(node.Text);
                            row.SubItems.Add(articlesList[i].Date.ToShortDateString());
                            row.SubItems.Add(articlesList[i].Link);
                            feedList.Items.Add(row);
                        }
                        articleIsRead = false;
                    }
                }
            }
            feedList.Sort();
        }

        private void readAllList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (readAllList.SelectedItems.Count == 1)
            {
                for (int i = 0; i < allArticles.Count; i++)
                {
                    if (allArticles[i].Title == readAllList.SelectedItems[0].Text)
                    {
                        descriptionBox.Text = allArticles[i].Description;
                    }
                }
            }
        }
        #endregion

        #region start/end

        private void printWebsites()
        {
            foreach (TreeNode node in urlTreeView.Nodes)
            {
                node.Nodes.Clear();
            }
            subscriobtionsList = subsribtion.Websites;
            for (int i = 0; i < subscriobtionsList.Count; i++)
            {
                foreach (TreeNode node in urlTreeView.Nodes)
                {
                    if (node.Text == subscriobtionsList[i].Category)
                    {

                        node.Nodes.Add(subscriobtionsList[i].LinkToWebsite, subscriobtionsList[i].WebsiteName);
                    }
                }
            }

        }

        private void printReadArticles()
        {
            readArticles = subsribtion.ReadArtics;
            for (int i = 0; i < readArticles.Count; i++)
            {
                row = new ListViewItem();
                row.Text = readArticles[i].Title;
                row.SubItems.Add(readArticles[i].Date.ToShortDateString());
                row.SubItems.Add(readArticles[i].Link);
                row.SubItems.Add(readArticles[i].Description);
                readArticlesList.Items.Add(row);
            }
        }

        private void rssReader_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            subsribtion.LoadReadArticles();
            subsribtion.LoadSubscribtions();
            printReadArticles();
            printWebsites();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    subsribtion.SaveSubscribtions();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void setToSaveArticle()
        {
            Items rssItem = new Items();
            rssItem.Title = feedList.SelectedItems[0].SubItems[0].Text;
            rssItem.Date = DateTime.Parse(feedList.SelectedItems[0].SubItems[2].Text);
            rssItem.Link = feedList.SelectedItems[0].SubItems[3].Text;
            rssItem.Description = descriptionBox.Text;
            subsribtion.ReadArtics.Add(rssItem);
        }
        #endregion


        #region Mouse hover events

        private void urlBox_MouseHover(object sender, EventArgs e)
        {
            if (urlBox.Text == "Enter your URL here")
            {
                urlBox.Text = String.Empty;
            }
        }

        private void urlBox_MouseLeave(object sender, EventArgs e)
        {
            if (urlBox.Text == String.Empty && !urlBox.Focused)
            {
                urlBox.Text = "Enter your URL here";
            }
        }

        private void urlBox_MouseClick(object sender, MouseEventArgs e)
        {
            urlBox.Text = String.Empty;
        }

        private void urlBox_Leave(object sender, EventArgs e)
        {
            if (urlBox.Text == String.Empty)
            {
                urlBox.Text = "Enter your URL here";
            }
        }

        #endregion

        #region Validation

        private void urlBox_Validating(object sender, CancelEventArgs e)
        {
            if (DataControler.IsValidData(urlBox.Text))
            {
                urlBox.BackColor = Color.White;
            }
            else
            {
                urlBox.BackColor = Color.Red;
            }
        }


        #endregion

        private void feedList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            this.feedList.Sort();
        }
    }
}
