using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rssReaderDemo
{
    public class Rss
    {
        [Serializable]
        public struct Items
        {
            public DateTime Date;
            public string Title;
            public string Description;
            public string Link;
        }

        public struct Urls
        {
            public string LinkToWebsite;
            public string WebsiteName;
            public string Category;
        }
    }
}
