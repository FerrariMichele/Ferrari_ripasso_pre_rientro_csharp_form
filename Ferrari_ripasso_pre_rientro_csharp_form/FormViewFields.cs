﻿using System;
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
        string fileName, fileNameTemp;
        private Color backColor;
        private Color foreColor;
        #endregion
        public FormViewFields()
        {
            InitializeComponent();
            functions = new funzioni_form();
            fileName = "ferrari.csv";
            viewData();
        }
        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
            e.DrawText();
        }
        private static void headerDraw(object sender, DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)
        {
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            using (SolidBrush foreBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
            }
        }

        private static void bodyDraw(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
        private void viewData()
        {
            listView1.Clear();
            int numFields = functions.countFields(fileName);
            string[] columns = functions.searchFieldsNames(fileName);
            using (StreamReader csvReader = File.OpenText(fileName))
            {
                string lineFromFile;
                listView1.View = View.Details;
                for (int i = 0; i < columns.Length; i++)
                {
                    listView1.Columns.Add(columns[i], listView1.Width / 3, HorizontalAlignment.Center);
                    listView1.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler((sender, e) => headerDraw(sender, e, backColor, foreColor));
                    listView1.DrawItem += new DrawListViewItemEventHandler(bodyDraw);
                }
                listView1.GridLines = true;
                lineFromFile = csvReader.ReadLine();
                while ((lineFromFile = csvReader.ReadLine()) != null)
                {
                    string[] fields = lineFromFile.Split(';');
                    if (numFields == 11)
                    {
                        if (fields[10] == "0")
                        {
                            ListViewItem newItem = new ListViewItem();
                            newItem.Text = fields[0];
                            for (int j = 1; j < columns.Length - 1; j++)
                            {
                                newItem.SubItems.Add(fields[j]);
                            }
                            listView1.Items.Add(newItem);
                        }
                    }
                    else
                    {
                        ListViewItem newItem = new ListViewItem();
                        newItem.Text = fields[0];
                        for (int j = 1; j < columns.Length; j++)
                        {
                            newItem.SubItems.Add(fields[j]);
                        }
                        listView1.Items.Add(newItem);
                    }
                }
                csvReader.Close();
            }
        }
    }
}