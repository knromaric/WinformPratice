using System;
using System.Collections.Generic;
using WordUnscrambler.Data;

namespace WordUnscrambler.Workers

{
    public class WordMatcher
    { 

        public List<MatchedWord> Match(string[] scrambleWords, string[] wordList)
        {
            var matchedWords = new List<MatchedWord>();

            foreach (var scrambleWord in scrambleWords)
            {
                foreach(var word in wordList)
                {
                    if(scrambleWord.Equals(word, StringComparison.CurrentCultureIgnoreCase))
                    {
                        matchedWords.Add(BuildMatchedWord(scrambleWord, word));
                    }
                    else
                    {
                        var scrambleWordArray = scrambleWord.ToCharArray();
                        var wordArray = word.ToCharArray();
                        Array.Sort(scrambleWordArray);
                        Array.Sort(wordArray);

                        var sortedScrambleWord = new string(scrambleWordArray);
                        var sortedWord = new string(wordArray);

                        if(sortedScrambleWord.Equals(sortedWord, StringComparison.CurrentCultureIgnoreCase))
                        {
                            matchedWords.Add(BuildMatchedWord(scrambleWord, word));
                        }
                    }
                }
            }

            return matchedWords;
        }

        private MatchedWord BuildMatchedWord(string scrambleWord, string word)
        {
            var matchedWord = new MatchedWord
            {
                ScrambleWord = scrambleWord,
                Word = word
            };

            return matchedWord;
        }
    }
}