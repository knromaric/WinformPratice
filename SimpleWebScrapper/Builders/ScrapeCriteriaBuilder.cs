﻿using SimpleWebScrapper.Data;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SimpleWebScrapper.Builders
{
    public class ScrapeCriteriaBuilder
    {
        private string _data;
        private string _regex;
        private RegexOptions _regexOption;
        private List<ScrapeCriteriaPart> _parts;

        public ScrapeCriteriaBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _data = string.Empty;
            _regex = string.Empty;
            _regexOption = RegexOptions.None;
            _parts = new List<ScrapeCriteriaPart>();
        }

        public ScrapeCriteriaBuilder WithData(string data)
        {
            _data = data;
            return this;
        }

        public ScrapeCriteriaBuilder WithRegex(string regex)
        {
            _regex = regex;
            return this;
        }

        public ScrapeCriteriaBuilder WithRegexOption(RegexOptions regexOption)
        {
            _regexOption = regexOption;
            return this;
        }

        public ScrapeCriteriaBuilder WithParts(ScrapeCriteriaPart part)
        {
            _parts.Add(part);
            return this;
        }

        public ScrapeCriteria Build()
        {
            var scrapeCriteria = new ScrapeCriteria
            {
                Data = _data,
                Regex = _regex,
                RegexOption = _regexOption,
                Parts = _parts
            };

            return scrapeCriteria;
        }
    }
}
