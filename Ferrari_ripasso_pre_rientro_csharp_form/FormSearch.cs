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
    public partial class FormSearch : Form
    {
        #region dichiarazioni
        funzioni_form functions;
        string fileName;
        #endregion
        public FormSearch()
        {
            InitializeComponent();
            functions = new funzioni_form();
            fileName = "ferrari.csv";
        }
        private void FormSearch_Load(object sender, EventArgs e)
        {
            labelSearchNum.Visible = false;
            labelRecordText.Visible = false;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Tuple<string, int> RecordAndPosition = functions.searchPosition(fileName, textBoxSearch.Text, false);
            if (RecordAndPosition.Item2 == -1)
                MessageBox.Show("Il record cercato non è presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                labelSearchNum.Text = RecordAndPosition.Item2.ToString();
                labelSearchNum.Visible = true;
            }
        }
        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
                MessageBox.Show("Inserire un valore da cercare", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Tuple<string, int> RecordAndPosition = functions.searchPosition(fileName, textBoxSearch.Text, false);
                if (RecordAndPosition.Item2 == -1)
                {
                    MessageBox.Show("Il record cercato non è presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxSearch.Text = "";
                }
                else
                {
                    labelSearchNum.Text = RecordAndPosition.Item2.ToString();
                    labelRecordText.Text = RecordAndPosition.Item1;
                    labelSearchNum.Visible = true;
                    labelRecordText.Visible = true;
                }
            }
        }
    }
}
