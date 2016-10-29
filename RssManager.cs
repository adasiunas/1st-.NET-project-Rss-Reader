using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace rssReaderDemo
{
    public class RssManager : IDisposable
    {
        #region Variables
        private string url;
        private string feedTitle;
        private string feedDescription;
        private Collection<Rss.Items> rssItems = new Collection<Rss.Items>();
        private bool isDisposed;
        #endregion

        #region Constructors
        public RssManager()
        {
            url = string.Empty;
        }

        public RssManager(string feedUrl)
        {
            url = feedUrl;
        }
        #endregion

        #region Properties
        public string Url { get; set; }

        public Collection<Rss.Items> RssItems
        {
            get { return rssItems; }
        }

        public string FeedTitle
        {
            get { return feedTitle; }
        }

        public string FeedDescription
        {
            get { return feedDescription; }
        }

        #endregion

        #region Methods
        public Collection<Rss.Items> GetFeed()
        {
            if (String.IsNullOrEmpty(Url))
            {
                throw new ArgumentException("You need to provide a feed URL!");
            }

            using (XmlReader reader = XmlReader.Create(Url))
            {
                XmlDocument xmlDocument = new XmlDocument();
                try
                {
                    xmlDocument.Load(Url);
                }
                catch (Exception e)
                {
                    throw new ArgumentException(e.ToString());
                }
                ParseDocElements(xmlDocument.SelectSingleNode("//channel"), "title", ref feedTitle);
                ParseDocElements(xmlDocument.SelectSingleNode("//channel"), "description", ref feedDescription);
                ParseRssItems(xmlDocument);
                return rssItems;
            }
        }

        public void ParseRssItems(XmlDocument xmlDocument)
        {
            rssItems.Clear();
            XmlNodeList nodes = xmlDocument.SelectNodes("rss/channel/item");

            foreach (XmlNode node in nodes)
            {
                Rss.Items item = new Rss.Items();
                ParseDocElements(node, "title", ref item.Title);
                ParseDocElements(node, "description", ref item.Description);
                ParseDocElements(node, "link", ref item.Link);

                string date = null;
                ParseDocElements(node, "pubDate", ref date);
                DateTime.TryParse(date, out item.Date);
                item.Description = Regex.Replace(item.Description, "<.*?>", String.Empty).Trim();

                rssItems.Add(item);
            }
        }
        public void ParseDocElements(XmlNode parent, string xPath, ref string property)
        {
            XmlNode node = parent.SelectSingleNode(xPath);
            if (node != null)
            {
                property = node.InnerText;
            }
            else
            {
                property = "Unresolvable";
            }
        }

        public void Dispose(bool isDisposing)
        {
            if (isDisposing && !isDisposed)
            {
                rssItems.Clear();
                url = null;
                feedTitle = null;
                feedDescription = null;
            }
            isDisposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
