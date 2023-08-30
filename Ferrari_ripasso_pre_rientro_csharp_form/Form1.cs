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
        
        #endregion

        #region eventi
        public form1()
        {
            InitializeComponent();
        }
        private void buttonMyValue_Click(object sender, EventArgs e)
        {
            OpenForm<FormMyValue>();
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
