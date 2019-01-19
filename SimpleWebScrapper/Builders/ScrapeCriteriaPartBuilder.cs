using SimpleWebScrapper.Data;
using System.Text.RegularExpressions;

namespace SimpleWebScrapper.Builders
{
    public class ScrapeCriteriaPartBuilder
    {
        private string _regex;
        private RegexOptions _regexOption ;

        public ScrapeCriteriaPartBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _regex = string.Empty;
            _regexOption = RegexOptions.None;
        }

        public ScrapeCriteriaPartBuilder WithRegex(string regex)
        {
            _regex = regex;
            return this; 
        }

        public ScrapeCriteriaPartBuilder WithRegexOption(RegexOptions regexOption)
        {
            _regexOption = regexOption;
            return this;
        }

        public ScrapeCriteriaPart Build()
        {
            var scrapeCriteriaPart = new ScrapeCriteriaPart
            {
                Regex = _regex,
                RegexOption = _regexOption
            };

            return scrapeCriteriaPart;
        }
    }
}
