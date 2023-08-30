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
    }
}