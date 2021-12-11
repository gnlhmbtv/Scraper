using System;

namespace Scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://yts.mx/");
            foreach (var item in doc.DocumentNode.SelectNodes("//a[@class='browse-movie-title']")) 
            {
                Console.WriteLine(item.InnerText);
            }
        }
    }
}
