using System;
using System.IO;

namespace WordUnscrambler.Workers
{
    public class FileReader
    {
        public string[] Read(string fileName)
        {
            String[] fileContent;

            try
            {
                fileContent = File.ReadAllLines(fileName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return fileContent;
        }
    }
}