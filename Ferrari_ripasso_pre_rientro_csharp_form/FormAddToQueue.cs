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
    public partial class FormAddToQueue : Form
    {
        #region dichiarazioni
        funzioni_form functions;
        string fileName, fileNameTemp;
        Random rnd;
        string[] inputs;
        #endregion
        public FormAddToQueue()
        {
            InitializeComponent();
            functions = new funzioni_form();
            fileName = "ferrari.csv";
            fileNameTemp = "ferrari_temp.csv";
            rnd = new Random();
        }

        private void buttonAddToQueue_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Errore: uno o più campi sono vuoti o troppo lunghi\nLa lunghezza totale non deve superare i 242 caratteri", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Errore: uno o più campi sono vuoti o troppo lunghi\nLa lunghezza totale non deve superare i 245 caratteri", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!functions.checkInputChars(fields, inputs))
                MessageBox.Show("Uno o più campi contengono caratteri non validi\n ';', '#', '\\'", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                functions.addToQueue(fileName, fields, inputs);
            }
            this.Close();
        }
    }
}
