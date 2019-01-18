using System;
using System.Collections.Generic;
using System.Linq;
using WordUnscrambler.Data;
using WordUnscrambler.Workers;

namespace WordUnscrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();


        static void Main(string[] args)
        {

            try
            {
                bool continueWordUnscramble = true;

                do
                {
                    Console.WriteLine(Constants.OptionsOnHowToEnterScrambleWords);
                    var option = Console.ReadLine() ?? string.Empty;

                    switch (option.ToUpper())
                    {
                        case Constants.File:
                            Console.Write(Constants.EnterScrambleWordsViaFile);
                            ExecuteScrambleWordsInFileScenario();
                            break;

                        case Constants.Manual:
                            Console.Write(Constants.EnterScrambleWordManually);
                            ExecuteScrambleWordsManualEntryScenario();
                            break;
                        default:
                            Console.Write(Constants.EnterScrambleWordsOptionNotRecognized);
                            break;
                    }

                    var continueDecision = string.Empty;

                    do
                    {
                        Console.WriteLine(Constants.OptionsOnContinuingTheProgram);
                        continueDecision = (Console.ReadLine() ?? string.Empty);

                    } while (!continueDecision.Equals(Constants.Yes, StringComparison.CurrentCultureIgnoreCase) &&
                             !continueDecision.Equals(Constants.No, StringComparison.CurrentCultureIgnoreCase));

                    continueWordUnscramble = continueDecision.Equals(Constants.Yes, StringComparison.CurrentCultureIgnoreCase);

                } while (continueWordUnscramble);
            }
            catch (Exception ex)
            {

                Console.WriteLine(Constants.ErrorProgramWillBeTerminated + ex.Message);
            }
        }

        private static void ExecuteScrambleWordsManualEntryScenario()
        {
            var manualInput = Console.ReadLine() ?? string.Empty;

            string[] scrambleWords = manualInput.Split(',');
            DisplayMatchedUnscrambleWords(scrambleWords);
        }

        private static void ExecuteScrambleWordsInFileScenario()
        {
            try
            {
                var fileName = Console.ReadLine() ?? string.Empty;
                string[] scrambleWords = _fileReader.Read(fileName);
                DisplayMatchedUnscrambleWords(scrambleWords);
            }
            catch (Exception ex)
            {
                Console.WriteLine(Constants.ErrorScrambleWordsCannotBeLoaded + ex.Message);
            }
        }

        private static void DisplayMatchedUnscrambleWords(string[] scrambleWords)
        {
            string[] wordList = _fileReader.Read(Constants.wordListFileName);

            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambleWords, wordList);

            if (matchedWords.Any())
            {
                foreach (var matchedWord in matchedWords)
                {
                    Console.WriteLine($"{Constants.MatchFound} {matchedWord.ScrambleWord} : {matchedWord.Word}");
                }
            }
            else
            {
                Console.WriteLine(Constants.MatchNotFound);
            }

        }
    }
}
