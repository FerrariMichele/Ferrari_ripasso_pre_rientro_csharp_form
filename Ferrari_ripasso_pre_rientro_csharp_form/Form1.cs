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
    public partial class form1 : Form
    {
        #region dichiarazioni
        funzioni_form functions;
        string fileName, fileNameTemp;
        #endregion
        #region eventi
        public form1()
        {
            InitializeComponent();
            functions = new funzioni_form();
            fileName = "ferrari.csv";
            fileNameTemp = "ferrari_temp.csv";
        }
        private void form1_Load(object sender, EventArgs e)
        {
            if (!functions.checkFixedLen(fileName))
                functions.createFixedLen(fileName, fileNameTemp);
        }
        private void buttonMyValue_Click(object sender, EventArgs e)
        {
            //OpenForm<FormMyValue>();
            if (!functions.checkMyValue(fileName))
                functions.createMyValue(fileName, fileNameTemp);
            else MessageBox.Show("Nel file sono già presenti i campi Miovalore e Cancellazione Logica","Errore",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void buttonCountFields_Click(object sender, EventArgs e)
        {

        }
        private void buttonMaxLen_Click(object sender, EventArgs e)
        {

        }
        private void buttonAddToQueue_Click(object sender, EventArgs e)
        {

        }
        private void buttonViewFields_Click(object sender, EventArgs e)
        {

        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
        private void buttonModify_Click(object sender, EventArgs e)
        {

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void OpenForm<MyForm>() where MyForm : Form, new()
        {
            Form viewedForm;
            viewedForm = panelForm.Controls.OfType<MyForm>().FirstOrDefault();
            if (viewedForm == null)
            {
                viewedForm = new MyForm();
                viewedForm.TopLevel = false;
                viewedForm.FormBorderStyle = FormBorderStyle.None;
                viewedForm.Dock = DockStyle.Fill;
                panelForm.Controls.Add(viewedForm);
                panelForm.Tag = viewedForm;
                viewedForm.Show();
                viewedForm.BringToFront();
            }
            else
            {
                viewedForm.BringToFront();
            }
        }
    }
}
