using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                        lineFromFile += ";";
                        lineFromFile = lineFromFile.PadRight(256) + "##";
                        csvWriter.WriteLine(lineFromFile);
                    }
                    csvWriter.Close();
                }
                csvReader.Close();
            }
            File.Delete(fileName);
            File.Move(fileNameTemp, fileName);
            File.Delete(fileNameTemp);
        }
        public bool checkMyValue(string fileName)
        {
            bool myValue = false;
            string lineFromFile;
            using (StreamReader csvReader = File.OpenText(fileName))
            {
                lineFromFile = csvReader.ReadLine();
                if (lineFromFile.Contains("Miovalore;Cancellazione logica"))
                    myValue = true;
                csvReader.Close();
            }
            return myValue;
        }
        public void createMyValue(string fileName, string fileNameTemp)
        {
            string lineFromFile;
            Random rnd = new Random();
            using (StreamReader csvReader = File.OpenText(fileName))
            {
                using (StreamWriter csvWriter = new StreamWriter(fileNameTemp))
                {
                    lineFromFile = csvReader.ReadLine();
                    string[] fields = lineFromFile.Split(';');
                    lineFromFile = "";
                    for (int i = 0; i < fields.Length - 1; i++)
                        lineFromFile += fields[i] + ";";
                    lineFromFile += "Miovalore;Cancellazione logica;";
                    lineFromFile = lineFromFile.PadRight(256) + "##";
                    csvWriter.WriteLine(lineFromFile);
                    while ((lineFromFile = csvReader.ReadLine()) != null)
                    {
                        fields = lineFromFile.Split(';');
                        lineFromFile = "";
                        for (int i = 0; i < fields.Length - 1; i++)
                            lineFromFile += fields[i] + ";";
                        lineFromFile += rnd.Next(10,21) + ";0;";
                        lineFromFile = lineFromFile.PadRight(256) + "##";
                        csvWriter.WriteLine(lineFromFile);
                    }
                    csvWriter.Close();
                }
                csvReader.Close();
            }
            File.Delete(fileName);
            File.Move(fileNameTemp, fileName);
            File.Delete(fileNameTemp);
        }
        public int countFields(string fileName)
        {
            int count = 0;
            string lineFromFile;
            using (StreamReader csvReader = File.OpenText(fileName))
            {
                lineFromFile = csvReader.ReadLine();
                string[] fields = lineFromFile.Split(';');
                count = fields.Length;
                csvReader.Close();
            }
            return count - 1;
        }
    }
}