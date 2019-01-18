using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    public class Constants
    {
        public const string OptionsOnHowToEnterScrambleWords = "Enter scrambled word(s) manually or as a file: F - file / M - manual";
        public const string OptionsOnContinuingTheProgram = "Would you like to continue? Y/N";

        public const string EnterScrambleWordsViaFile = "Enter full path including the file name: ";
        public const string EnterScrambleWordManually = "Enter word(s) manually (separated by commas if multiple): ";
        public const string EnterScrambleWordsOptionNotRecognized = "The option was not recognized.";

        public const string ErrorScrambleWordsCannotBeLoaded = "Scrambled words were not loaded because there was an error";
        public const string ErrorProgramWillBeTerminated = "The program will be terminated";

        public const string MatchFound = "Match Found for "; 
        public const string MatchNotFound = "NO MATCHES HAVE BEEN FOUND";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string wordListFileName = "wordList.txt";


    }
}
