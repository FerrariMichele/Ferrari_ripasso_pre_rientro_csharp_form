using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferrari_ripasso_pre_rientro_csharp_form
{
    public partial class FormMaxLen : Form
    {
        #region dichiarazioni
        funzioni_form functions;
        string fileName;
        #endregion
        public FormMaxLen()
        {
            InitializeComponent();
            functions = new funzioni_form();
            fileName = "ferrari.csv";
            int fields = functions.countFields(fileName);
            string[] maxLen = functions.maxLen(fileName, fields);
            labelRecordMaxLen.Text = $"Il record più lungo è {maxLen[fields]} composto da {maxLen[fields].Length} caratteri";
            string outputLine = "";
            for (int i = 0; i < fields; i++)
            {
               outputLine += $"Il campo {i} più lungo è {maxLen[i]} composto da {maxLen[i].Length} caratteri\n";
            } 
            labelFieldsMaxLen.Text = outputLine;
        }
    }
}