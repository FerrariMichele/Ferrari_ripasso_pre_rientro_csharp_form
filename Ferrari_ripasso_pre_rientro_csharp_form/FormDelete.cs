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
    public partial class FormDelete : Form
    {
        #region dichiarazioni
        funzioni_form functions;
        string fileName, fileNameTemp;
        int recordLen;
        #endregion
        public FormDelete()
        {
            InitializeComponent();
            functions = new funzioni_form();
            fileName = "ferrari.csv";
            fileNameTemp = "ferrari_temp.csv";
            recordLen = 260;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!functions.checkMyValue(fileName))
            {
                MessageBox.Show("Nel file non sono presenti i campi Miovalore e Cancellazione Logica\nAggiugerli prima di procedere", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                Tuple <string, int> RecordAndPosition = functions.searchPosition(fileName, textBoxDelete.Text, false);
                if (RecordAndPosition.Item2 == -1)
                    MessageBox.Show("Il record cercato non è presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int fields = functions.countFields(fileName);
                    functions.deleteRecord(fileName, fields, RecordAndPosition.Item1, RecordAndPosition.Item2, recordLen);
                    this.Close();
                }
            }
        }
        private void buttonRecover_Click(object sender, EventArgs e)
        {
            if (!functions.checkMyValue(fileName))
            {
                MessageBox.Show("Nel file non sono presenti i campi Miovalore e Cancellazione Logica\nAggiugerli prima di procedere", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                Tuple<string, int> RecordAndPosition = functions.searchPosition(fileName, textBoxDelete.Text, true);
                if (RecordAndPosition.Item2 == -1)
                    MessageBox.Show("Il record cercato non è presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int fields = functions.countFields(fileName);
                    functions.recoverRecord(fileName, fields, RecordAndPosition.Item1, RecordAndPosition.Item2, recordLen);
                    this.Close();
                }
            }
        }
        private void buttonPermDelete_Click(object sender, EventArgs e)
        {
            if (!functions.checkMyValue(fileName))
            {
                MessageBox.Show("Nel file non sono presenti i campi Miovalore e Cancellazione Logica\nAggiugerli prima di procedere", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                var rispExt = MessageBox.Show("Cancellare in modo permanente i record eliminati?", "Ricompattazione Database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rispExt == DialogResult.Yes)
                {
                    functions.permDelete(fileName, fileNameTemp);
                }
            }
            this.Close();
        }
    }
}