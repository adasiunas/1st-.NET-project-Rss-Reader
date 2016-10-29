using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rssReaderDemo
{

    public class DataControler
    {
        private string[] data;
 
        public string[] readData(string fileName)
        {
            try
            {
                data = System.IO.File.ReadAllLines(fileName);
                return data;
            }
            catch(FileNotFoundException e)
            {
                throw new FileNotFoundException(e.ToString());
            }
        }

        public void saveData(Collection<Rss.Urls> WebSubscribtions, string filename)
        {
            using (StreamWriter fileStream = new StreamWriter(filename))
            {
                foreach (Rss.Urls item in WebSubscribtions)
                {
                    fileStream.Write(item.WebsiteName + ",");
                    fileStream.Write(item.LinkToWebsite + ",");
                    fileStream.WriteLine(item.Category);
                }
            }
        }
        public void saveData(Collection<Rss.Items> readArticles, string filename)
        {
            using (StreamWriter fileStream = new StreamWriter(filename))
            {
                foreach (Rss.Items item in readArticles)
                {
                    fileStream.WriteLine(item.Title);
                    fileStream.WriteLine(item.Date.ToString());
                    fileStream.WriteLine(item.Link);
                    fileStream.WriteLine(item.Description);
                }
            }
        }


        public static bool IsValidData(string text)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(text, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (!result)
            {
                return false;
            }
            return true;
        }


    }
}
