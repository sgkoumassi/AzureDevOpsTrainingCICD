//using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebGetter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> urls = new List<string>();
            string[] _urls = { "https://zestedesavoir.com/" };
            urls.AddRange(_urls);
            GetLinksThenDownloadPages(urls);
            Console.ReadLine();
        }

        static async void GetLinksThenDownloadPages(IEnumerable<string> urls)
        {
            List<string> downloadedUrls = await GetLinks(urls);
            await DownloadFilesFromLinks(downloadedUrls);
        }
        static async Task<List<string>> GetLinks(IEnumerable<string> startUrls)
        {
            List<Task<List<string>>> tasks = new List<Task<List<string>>>();
            foreach (string url in startUrls)
            {
                tasks.Add(DownloadLinksFromUrlAsync(url));
            }
            return (from list in await Task<List<string>>.WhenAll(tasks)
                    from link in list
                    select link).ToList();
        }

        static async Task<List<string>> DownloadLinksFromUrlAsync(string url)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse;
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                string htmlCode = streamReader.ReadToEnd();
                HtmlDocument parsed = new HtmlDocument();
                parsed.LoadHtml(htmlCode);
                IEnumerable<string> aElement = from element in parsed.DocumentNode.Descendants()
                                               where element.Name.ToString().ToLower() == "a"
                                               where element.Attributes["href"] != null
                                               select element.Attributes["href"].Value;
                return aElement.ToList();
            }

        }

        static async Task WriteFileFromUrl(string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse;
                Guid g = Guid.NewGuid();
                using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                {
                    using (StreamWriter writer = new StreamWriter(g.ToString() + ".html"))
                    {
                        await writer.WriteAsync(await streamReader.ReadToEndAsync());
                        Console.WriteLine(g.ToString() + ".html : " + url);
                    }
                }
            }
            catch (UriFormatException exception)
            {
                Console.Error.WriteLine(exception.Message);
            }
            catch (WebException exception)
            {
                Console.Error.WriteLine(url + " was correct but not downloaded due to " + exception.Message);
            }
        }

        static async Task DownloadFilesFromLinks(IEnumerable<string> list)
        {
            List<Task> tasks = new List<Task>();
            foreach (string url in list)
            {
                tasks.Add(WriteFileFromUrl(url));
            }
            await Task.WhenAll(tasks);
        }

    }
}
