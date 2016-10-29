using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static rssReaderDemo.Rss;


/* TODO:
 * read all
 * */
namespace rssReaderDemo
{
    public class Subscribtion
    {
        public Collection<Rss.Urls> WebSubscribtions = new Collection<Rss.Urls>();
        public Collection<Rss.Items> ReadArticles = new Collection<Rss.Items>();
        public DataControler dataSource = new DataControler();
        

        public Subscribtion()
        {
            WebsiteUrl = String.Empty;
        }

        public string WebsiteUrl { get; set; }
        public string WebName { get; set; }
        public string Category { get; set; }

        public Collection<Rss.Urls> Websites
        {
           get { return WebSubscribtions; }
        }

        public Collection<Rss.Items> ReadArtics
        {
            get { return ReadArticles; }
        }

        public void AddSubscribtion()
        {
            if (WebsiteUrl.Length == 0)
            {
                throw new Exception("Provide an URL adress!");
            }
            else
            {
                Rss.Urls item = new Rss.Urls();
                item.LinkToWebsite = WebsiteUrl;
                item.WebsiteName = new Uri(WebsiteUrl).Host;
                item.Category = Category;
                WebSubscribtions.Add(item);
            }
        }

        public void DeleteSubscribtion(string link)
        {
            foreach (Rss.Urls item in WebSubscribtions.ToList())
            {
                if (item.LinkToWebsite == link)
                {
                    WebSubscribtions.Remove(item);
                }
            }
        }

        public void LoadReadArticles()
        {
            string[] lines = dataSource.readData("ReadArticles.txt");
            int i = 0;
            for (int objectCount = 0; objectCount < (lines.Length / 4); objectCount++)
            {
                Items rssItem = new Items();
                rssItem.Title = lines[i++];
                rssItem.Date = DateTime.Parse(lines[i++]);
                rssItem.Link = lines[i++];
                rssItem.Description = lines[i++];
                ReadArticles.Add(rssItem);
            }
        }

        public void LoadSubscribtions()
        {
            string[] lines = dataSource.readData("Subscribtions.txt");
            string[] words;
            foreach (string line in lines)
            {
                Rss.Urls item = new Rss.Urls();
                words = line.Split(',').ToArray<string>();
                item.WebsiteName = words[0];
                item.LinkToWebsite = words[1];
                item.Category = words[2];
                WebSubscribtions.Add(item);
            }
        }

        public void SaveSubscribtions()
        {
            dataSource.saveData(WebSubscribtions, "Subscribtions.txt");
            dataSource.saveData(ReadArticles, "ReadArticles.txt");
        }
    }
}
