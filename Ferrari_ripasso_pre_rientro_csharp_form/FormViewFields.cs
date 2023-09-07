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
    public partial class FormViewFields : Form
    {
        #region dichiarazioni
        funzioni_form functions;
        string fileName;
        #endregion
        public FormViewFields()
        {
            InitializeComponent();
            functions = new funzioni_form();
            fileName = "ferrari.csv";
        }
        private void FormViewFields_Load(object sender, EventArgs e)
        {
            if (functions.countFields(fileName) == 9)
                checkBoxMiovalore.Visible = false;
            else
                checkBoxMiovalore.Visible = true;
        }
        private int checkCheckBoxNumber()
        {
            int checkedNumber = 0;
            if (checkBoxComune.Checked) checkedNumber++;
            if (checkBoxProvincia.Checked) checkedNumber++;
            if (checkBoxRegione.Checked) checkedNumber++;
            if (checkBoxNome.Checked) checkedNumber++;
            if (checkBoxAnno.Checked) checkedNumber++;
            if (checkBoxData.Checked) checkedNumber++;
            if (checkBoxIdOSM.Checked) checkedNumber++;
            if (checkBoxLatitudine.Checked) checkedNumber++;
            if (checkBoxLongitudine.Checked) checkedNumber++;
            if (checkBoxMiovalore.Checked) checkedNumber++;
            return checkedNumber;
        }
        private void viewItems(string fileName)
        {
            listView1.Clear();
            int numFields = functions.countFields(fileName);
            int[] checkEd = new int[numFields];
            for (int i = 0; i < numFields; i++)
                checkEd[i] = 0;
            if (checkBoxComune.Checked) checkEd[0] = 1;
            if (checkBoxProvincia.Checked) checkEd[1] = 1;
            if (checkBoxRegione.Checked) checkEd[2] = 1;
            if (checkBoxNome.Checked) checkEd[3] = 1;
            if (checkBoxAnno.Checked) checkEd[4] = 1;
            if (checkBoxData.Checked) checkEd[5] = 1;
            if (checkBoxIdOSM.Checked) checkEd[6] = 1;
            if (checkBoxLongitudine.Checked) checkEd[7] = 1;
            if (checkBoxLatitudine.Checked) checkEd[8] = 1;
            if (numFields > 9)
                if (checkBoxMiovalore.Checked) checkEd[9] = 1;
            string[] names = functions.searchFieldsNames(fileName);
            listView1.View = View.Details;
            listView1.GridLines = true;
            using (StreamReader csvReader = File.OpenText(fileName))
            {
                string lineFromFile;
                
                for (int i = 0; i < numFields; i++)
                {
                    if (checkEd[i] == 1)
                        listView1.Columns.Add(names[i], listView1.Width / checkCheckBoxNumber(), HorizontalAlignment.Center);
                }
                lineFromFile = csvReader.ReadLine();
                while ((lineFromFile = csvReader.ReadLine()) != null)
                {
                    string[] fields = lineFromFile.Split(';');
                    if (numFields == 11)
                    {
                        if (fields[10] == "0")
                        {
                            ListViewItem newItem = new ListViewItem();
                            bool first = false;
                            for (int i = 0; i < numFields; i++)
                            {
                                if (checkEd[i] == 1 && !first)
                                {
                                    newItem.Text = fields[i];
                                    first = true;
                                }
                                else if (checkEd[i] == 1)
                                    newItem.SubItems.Add(fields[i]);
                            }
                            listView1.Items.Add(newItem);
                        }
                    }
                    else
                    {
                        ListViewItem newItem = new ListViewItem();
                        bool first = false;
                        for (int i = 0; i < numFields; i++)
                        {
                            if (checkEd[i] == 1 && !first)
                            {
                                newItem.Text = fields[i];
                                first = true;
                            }
                            else if (checkEd[i] == 1)
                                newItem.SubItems.Add(fields[i]);
                        }
                        listView1.Items.Add(newItem);
                    }
                }
                csvReader.Close();
            }
        }
        private void checkBoxComune_Click(object sender, EventArgs e)
        {
            int checkBoxNumber = checkCheckBoxNumber();
            if (checkBoxNumber > 3)
            {
                MessageBox.Show("Selezionare massimo 3 campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxComune.Checked = false;
            }
            else if (checkBoxNumber > 0)
            {
                viewItems(fileName);
            }
            else
            {
                listView1.Clear();
            }
        }
        private void checkBoxProvincia_Click(object sender, EventArgs e)
        {
            int checkBoxNumber = checkCheckBoxNumber();
            if (checkBoxNumber > 3)
            {
                MessageBox.Show("Selezionare massimo 3 campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxProvincia.Checked = false;
            }
            else if (checkBoxNumber > 0)
            {
                viewItems(fileName);
            }
            else
            {
                listView1.Clear();
            }
        }
        private void checkBoxRegione_Click(object sender, EventArgs e)
        {
            int checkBoxNumber = checkCheckBoxNumber();
            if (checkBoxNumber > 3)
            {
                MessageBox.Show("Selezionare massimo 3 campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxRegione.Checked = false;
            }
            else if (checkBoxNumber > 0)
            {
                viewItems(fileName);
            }
            else
            {
                listView1.Clear();
            }
        }
        private void checkBoxNome_Click(object sender, EventArgs e)
        {
            int checkBoxNumber = checkCheckBoxNumber();
            if (checkBoxNumber > 3)
            {
                MessageBox.Show("Selezionare massimo 3 campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxNome.Checked = false;
            }
            else if (checkBoxNumber > 0)
            {
                viewItems(fileName);
            }
            else
            {
                listView1.Clear();
            }
        }
        private void checkBoxAnno_Click(object sender, EventArgs e)
        {
            int checkBoxNumber = checkCheckBoxNumber();
            if (checkBoxNumber > 3)
            {
                MessageBox.Show("Selezionare massimo 3 campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxAnno.Checked = false;
            }
            else if (checkBoxNumber > 0)
            {
                viewItems(fileName);
            }
            else
            {
                listView1.Clear();
            }
        }
        private void checkBoxData_Click(object sender, EventArgs e)
        {
            int checkBoxNumber = checkCheckBoxNumber();
            if (checkBoxNumber > 3)
            {
                MessageBox.Show("Selezionare massimo 3 campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxData.Checked = false;
            }
            else if (checkBoxNumber > 0)
            {
                viewItems(fileName);
            }
            else
            {
                listView1.Clear();
            }
        }
        private void checkBoxIdOSM_Click(object sender, EventArgs e)
        {
            int checkBoxNumber = checkCheckBoxNumber();
            if (checkBoxNumber > 3)
            {
                MessageBox.Show("Selezionare massimo 3 campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxIdOSM.Checked = false;
            }
            else if (checkBoxNumber > 0)
            {
                viewItems(fileName);
            }
            else
            {
                listView1.Clear();
            }
        }
        private void checkBoxLongitudine_Click(object sender, EventArgs e)
        {
            int checkBoxNumber = checkCheckBoxNumber();
            if (checkBoxNumber > 3)
            {
                MessageBox.Show("Selezionare massimo 3 campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxLongitudine.Checked = false;
            }
            else if (checkBoxNumber > 0)
            {
                viewItems(fileName);
            }
            else
            {
                listView1.Clear();
            }
        }
        private void checkBoxLatitudine_Click(object sender, EventArgs e)
        {
            int checkBoxNumber = checkCheckBoxNumber();
            if (checkBoxNumber > 3)
            {
                MessageBox.Show("Selezionare massimo 3 campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxLatitudine.Checked = false;
            }
            else if (checkBoxNumber > 0)
            {
                viewItems(fileName);
            }
            else
            {
                listView1.Clear();
            }
        }
        private void checkBoxMiovalore_Click(object sender, EventArgs e)
        {
            int checkBoxNumber = checkCheckBoxNumber();
            if (checkBoxNumber > 3)
            {
                MessageBox.Show("Selezionare massimo 3 campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBoxMiovalore.Checked = false;
            }
            else if (checkBoxNumber > 0)
            {
                viewItems(fileName);
            }
            else
            {
                listView1.Clear();
            }
        }
    }
}
