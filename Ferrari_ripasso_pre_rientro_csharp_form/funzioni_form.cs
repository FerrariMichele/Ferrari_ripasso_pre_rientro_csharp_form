using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari_ripasso_pre_rientro_csharp_form
{
    internal class funzioni_form
    {
        public bool checkFixedLen(string fileName)
        {
            bool fixedLen = false;
            string lineFromFile;
            using (StreamReader csvReader = File.OpenText(fileName))
            {
                lineFromFile = csvReader.ReadLine();
                if (lineFromFile.Contains("##"))
                    fixedLen = true;
                csvReader.Close();
            }
            return fixedLen;
        }
        public void createFixedLen(string fileName, string fileNameTemp)
        {
            string lineFromFile;
            using (StreamReader csvReader = File.OpenText(fileName))
            {
                using (StreamWriter csvWriter = new StreamWriter(fileNameTemp))
                {
                    while ((lineFromFile = csvReader.ReadLine()) != null)
                    {
                        lineFromFile = lineFromFile.PadRight(256) + "##";
                        csvWriter.WriteLine(lineFromFile);
                    }
                    csvWriter.Close();
                }
                csvReader.Close();
            }
        }
    }
}