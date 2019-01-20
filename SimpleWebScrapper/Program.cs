using SimpleWebScrapper.Builders;
using SimpleWebScrapper.workers;
using System;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace SimpleWebScrapper
{
    class Program
    {
        private const string METHOD = "search";
        

        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Please enter which city you would like to scrape information from: ");
                var craigListCity = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Please enter the CraigList category you would like to scrape: ");
                var craigListCategoryName = Console.ReadLine() ?? string.Empty;

                using (WebClient client = new WebClient())
                {
                    string url = $"https://{craigListCity.Replace(" ", string.Empty)}.craigslist.org/{METHOD}/{craigListCategoryName}";
                    string content = client.DownloadString(url);
                    var scrapeCriteria = new ScrapeCriteriaBuilder()
                        .WithData(content)
                        .WithRegex(@"<a href=\""(.*?)\"" data-id=\""(.*?)\"" class=\""result-title hdrlnk\"">(.*?)<\/a>")
                        .WithRegexOption(RegexOptions.ExplicitCapture)
                        .WithParts(new ScrapeCriteriaPartBuilder()
                            .WithRegex(@">(.*?)<\/a>")
                            .WithRegexOption(RegexOptions.Singleline)
                            .Build())
                        .WithParts(new ScrapeCriteriaPartBuilder()
                            .WithRegex(@"href=\""(.*?)\""")
                            .WithRegexOption(RegexOptions.Singleline)
                            .Build())
                        .Build();


                    Scraper scraper = new Scraper();
                    var scrapedElements = scraper.Scrape(scrapeCriteria);

                    if (scrapedElements.Any())
                    {
                        foreach (var scrapedElement in scrapedElements)
                            Console.WriteLine(scrapedElement);
                    }
                    else
                    {
                        Console.WriteLine("There where no matches for the specified scrape criteria.");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}

