using System.Text.RegularExpressions;

namespace SimpleWebScrapper.Data
{
    public class ScrapeCriteriaPart
    {
        public string Regex { get; set; }
        public RegexOptions RegexOption { get; set; }
    }
}
