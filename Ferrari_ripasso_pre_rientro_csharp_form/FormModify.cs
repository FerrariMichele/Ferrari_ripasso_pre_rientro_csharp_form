using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferrari_ripasso_pre_rientro_csharp_form
{
    public partial class FormModify : Form
    {
        #region dichiarazioni
        funzioni_form functions;
        string fileName;
        Random rnd;
        string[] inputs;
        int recordLen;
        Tuple<string, int> RecordAndPosition;
        #endregion
        public FormModify()
        {
            InitializeComponent();
            functions = new funzioni_form();
            fileName = "ferrari.csv";
            rnd = new Random();
            recordLen = 260;
        }
        private void FormModify_Load(object sender, EventArgs e)
        {
            panelComune.Visible = false;
            panelProvincia.Visible = false;
            panelRegione.Visible = false;
            panelNome.Visible = false;
            panelAnno.Visible = false;
            panelData.Visible = false;
            panelIdOSM.Visible = false;
            panelLongitudine.Visible = false;
            panelLatitudine.Visible = false;
            buttonModify.Visible = false;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
                MessageBox.Show("Inserire un valore da cercare", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RecordAndPosition = functions.searchPosition(fileName, textBoxSearch.Text, false);
                if (RecordAndPosition.Item2 == -1)
                {
                    MessageBox.Show("Il record cercato non è presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxSearch.Text = "";
                }
                else
                {
                    panelSearch.Visible = false;
                    panelComune.Visible = true;
                    panelProvincia.Visible = true;
                    panelRegione.Visible = true;
                    panelNome.Visible = true;
                    panelAnno.Visible = true;
                    panelData.Visible = true;
                    panelIdOSM.Visible = true;
                    panelLongitudine.Visible = true;
                    panelLatitudine.Visible = true;
                    buttonModify.Visible = true;
                }
            }
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            int fields = functions.countFields(fileName);
            inputs = new string[fields];
            inputs[0] = textBoxComune.Text;
            inputs[1] = textBoxProvincia.Text;
            inputs[2] = textBoxRegione.Text;
            inputs[3] = textBoxNome.Text;
            inputs[4] = textBoxAnno.Text;
            inputs[5] = textBoxData.Text;
            inputs[6] = textBoxIdOSM.Text;
            inputs[7] = textBoxLongitudine.Text;
            inputs[8] = textBoxLatitudine.Text;
            if (functions.checkMyValue(fileName))
            {
                inputs[9] = rnd.Next(10, 21).ToString();
                inputs[10] = "0";
            }
            if (!functions.checkInputLen(fields, inputs))
            {
                if (!functions.checkMyValue(fileName))
                    MessageBox.Show("Uno o più campi sono vuoti o troppo lunghi\nLa lunghezza totale non deve superare i 242 caratteri", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Uno o più campi sono vuoti o troppo lunghi\nLa lunghezza totale non deve superare i 245 caratteri", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!functions.checkInputChars(fields, inputs))
                MessageBox.Show("Uno o più campi contengono caratteri non validi\n ';', '#', '\\'", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                functions.modifyRecord(fileName, fields, inputs, RecordAndPosition.Item2, recordLen);
            }
            this.Close();
        }
    }
}
