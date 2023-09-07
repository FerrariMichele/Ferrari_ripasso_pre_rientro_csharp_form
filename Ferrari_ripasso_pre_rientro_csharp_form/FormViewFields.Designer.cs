namespace Ferrari_ripasso_pre_rientro_csharp_form
{
    partial class FormViewFields
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewFields));
            this.panelListView = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelCheckBoxes = new System.Windows.Forms.Panel();
            this.labelCampi = new System.Windows.Forms.Label();
            this.checkBoxMiovalore = new System.Windows.Forms.CheckBox();
            this.checkBoxLatitudine = new System.Windows.Forms.CheckBox();
            this.checkBoxLongitudine = new System.Windows.Forms.CheckBox();
            this.checkBoxIdOSM = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.checkBoxAnno = new System.Windows.Forms.CheckBox();
            this.checkBoxNome = new System.Windows.Forms.CheckBox();
            this.checkBoxRegione = new System.Windows.Forms.CheckBox();
            this.checkBoxProvincia = new System.Windows.Forms.CheckBox();
            this.checkBoxComune = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelListView.SuspendLayout();
            this.panelCheckBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelListView
            // 
            this.panelListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.panelListView.Controls.Add(this.listView1);
            this.panelListView.Location = new System.Drawing.Point(12, 12);
            this.panelListView.Name = "panelListView";
            this.panelListView.Size = new System.Drawing.Size(537, 537);
            this.panelListView.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(106)))));
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(513, 513);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // panelCheckBoxes
            // 
            this.panelCheckBoxes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.panelCheckBoxes.Controls.Add(this.labelCampi);
            this.panelCheckBoxes.Controls.Add(this.checkBoxMiovalore);
            this.panelCheckBoxes.Controls.Add(this.checkBoxLatitudine);
            this.panelCheckBoxes.Controls.Add(this.checkBoxLongitudine);
            this.panelCheckBoxes.Controls.Add(this.checkBoxIdOSM);
            this.panelCheckBoxes.Controls.Add(this.checkBoxData);
            this.panelCheckBoxes.Controls.Add(this.checkBoxAnno);
            this.panelCheckBoxes.Controls.Add(this.checkBoxNome);
            this.panelCheckBoxes.Controls.Add(this.checkBoxRegione);
            this.panelCheckBoxes.Controls.Add(this.checkBoxProvincia);
            this.panelCheckBoxes.Controls.Add(this.checkBoxComune);
            this.panelCheckBoxes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCheckBoxes.Location = new System.Drawing.Point(566, 12);
            this.panelCheckBoxes.Name = "panelCheckBoxes";
            this.panelCheckBoxes.Size = new System.Drawing.Size(200, 273);
            this.panelCheckBoxes.TabIndex = 2;
            // 
            // labelCampi
            // 
            this.labelCampi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampi.Location = new System.Drawing.Point(3, 12);
            this.labelCampi.Name = "labelCampi";
            this.labelCampi.Size = new System.Drawing.Size(194, 26);
            this.labelCampi.TabIndex = 10;
            this.labelCampi.Text = "Campi selezionabili";
            this.labelCampi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxMiovalore
            // 
            this.checkBoxMiovalore.AutoSize = true;
            this.checkBoxMiovalore.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMiovalore.Location = new System.Drawing.Point(6, 248);
            this.checkBoxMiovalore.Name = "checkBoxMiovalore";
            this.checkBoxMiovalore.Size = new System.Drawing.Size(77, 17);
            this.checkBoxMiovalore.TabIndex = 9;
            this.checkBoxMiovalore.Text = "Miovalore";
            this.checkBoxMiovalore.UseVisualStyleBackColor = true;
            this.checkBoxMiovalore.Click += new System.EventHandler(this.checkBoxMiovalore_Click);
            // 
            // checkBoxLatitudine
            // 
            this.checkBoxLatitudine.AutoSize = true;
            this.checkBoxLatitudine.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLatitudine.Location = new System.Drawing.Point(6, 225);
            this.checkBoxLatitudine.Name = "checkBoxLatitudine";
            this.checkBoxLatitudine.Size = new System.Drawing.Size(78, 17);
            this.checkBoxLatitudine.TabIndex = 8;
            this.checkBoxLatitudine.Text = "Latitudine";
            this.checkBoxLatitudine.UseVisualStyleBackColor = true;
            this.checkBoxLatitudine.Click += new System.EventHandler(this.checkBoxLatitudine_Click);
            // 
            // checkBoxLongitudine
            // 
            this.checkBoxLongitudine.AutoSize = true;
            this.checkBoxLongitudine.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLongitudine.Location = new System.Drawing.Point(6, 202);
            this.checkBoxLongitudine.Name = "checkBoxLongitudine";
            this.checkBoxLongitudine.Size = new System.Drawing.Size(89, 17);
            this.checkBoxLongitudine.TabIndex = 7;
            this.checkBoxLongitudine.Text = "Longitudine";
            this.checkBoxLongitudine.UseVisualStyleBackColor = true;
            this.checkBoxLongitudine.Click += new System.EventHandler(this.checkBoxLongitudine_Click);
            // 
            // checkBoxIdOSM
            // 
            this.checkBoxIdOSM.AutoSize = true;
            this.checkBoxIdOSM.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIdOSM.Location = new System.Drawing.Point(6, 179);
            this.checkBoxIdOSM.Name = "checkBoxIdOSM";
            this.checkBoxIdOSM.Size = new System.Drawing.Size(193, 17);
            this.checkBoxIdOSM.TabIndex = 6;
            this.checkBoxIdOSM.Text = "Identificatore in OpenStreetMap";
            this.checkBoxIdOSM.UseVisualStyleBackColor = true;
            this.checkBoxIdOSM.Click += new System.EventHandler(this.checkBoxIdOSM_Click);
            // 
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxData.Location = new System.Drawing.Point(6, 156);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(153, 17);
            this.checkBoxData.TabIndex = 5;
            this.checkBoxData.Text = "Data e Ora di Inerimento";
            this.checkBoxData.UseVisualStyleBackColor = true;
            this.checkBoxData.Click += new System.EventHandler(this.checkBoxData_Click);
            // 
            // checkBoxAnno
            // 
            this.checkBoxAnno.AutoSize = true;
            this.checkBoxAnno.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAnno.Location = new System.Drawing.Point(6, 133);
            this.checkBoxAnno.Name = "checkBoxAnno";
            this.checkBoxAnno.Size = new System.Drawing.Size(131, 17);
            this.checkBoxAnno.TabIndex = 4;
            this.checkBoxAnno.Text = "Anno di Inserimento";
            this.checkBoxAnno.UseVisualStyleBackColor = true;
            this.checkBoxAnno.Click += new System.EventHandler(this.checkBoxAnno_Click);
            // 
            // checkBoxNome
            // 
            this.checkBoxNome.AutoSize = true;
            this.checkBoxNome.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNome.Location = new System.Drawing.Point(6, 110);
            this.checkBoxNome.Name = "checkBoxNome";
            this.checkBoxNome.Size = new System.Drawing.Size(56, 17);
            this.checkBoxNome.TabIndex = 3;
            this.checkBoxNome.Text = "Nome";
            this.checkBoxNome.UseVisualStyleBackColor = true;
            this.checkBoxNome.Click += new System.EventHandler(this.checkBoxNome_Click);
            // 
            // checkBoxRegione
            // 
            this.checkBoxRegione.AutoSize = true;
            this.checkBoxRegione.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRegione.Location = new System.Drawing.Point(6, 87);
            this.checkBoxRegione.Name = "checkBoxRegione";
            this.checkBoxRegione.Size = new System.Drawing.Size(69, 17);
            this.checkBoxRegione.TabIndex = 2;
            this.checkBoxRegione.Text = "Regione";
            this.checkBoxRegione.UseVisualStyleBackColor = true;
            this.checkBoxRegione.Click += new System.EventHandler(this.checkBoxRegione_Click);
            // 
            // checkBoxProvincia
            // 
            this.checkBoxProvincia.AutoSize = true;
            this.checkBoxProvincia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProvincia.Location = new System.Drawing.Point(6, 64);
            this.checkBoxProvincia.Name = "checkBoxProvincia";
            this.checkBoxProvincia.Size = new System.Drawing.Size(72, 17);
            this.checkBoxProvincia.TabIndex = 1;
            this.checkBoxProvincia.Text = "Provincia";
            this.checkBoxProvincia.UseVisualStyleBackColor = true;
            this.checkBoxProvincia.Click += new System.EventHandler(this.checkBoxProvincia_Click);
            // 
            // checkBoxComune
            // 
            this.checkBoxComune.AutoSize = true;
            this.checkBoxComune.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxComune.Location = new System.Drawing.Point(6, 41);
            this.checkBoxComune.Name = "checkBoxComune";
            this.checkBoxComune.Size = new System.Drawing.Size(69, 17);
            this.checkBoxComune.TabIndex = 0;
            this.checkBoxComune.Text = "Comune";
            this.checkBoxComune.UseVisualStyleBackColor = true;
            this.checkBoxComune.Click += new System.EventHandler(this.checkBoxComune_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(566, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 258);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormViewFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelCheckBoxes);
            this.Controls.Add(this.panelListView);
            this.Name = "FormViewFields";
            this.Text = "FormViewFields";
            this.Load += new System.EventHandler(this.FormViewFields_Load);
            this.panelListView.ResumeLayout(false);
            this.panelCheckBoxes.ResumeLayout(false);
            this.panelCheckBoxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelListView;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panelCheckBoxes;
        private System.Windows.Forms.CheckBox checkBoxIdOSM;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.CheckBox checkBoxAnno;
        private System.Windows.Forms.CheckBox checkBoxNome;
        private System.Windows.Forms.CheckBox checkBoxRegione;
        private System.Windows.Forms.CheckBox checkBoxProvincia;
        private System.Windows.Forms.CheckBox checkBoxComune;
        private System.Windows.Forms.CheckBox checkBoxMiovalore;
        private System.Windows.Forms.CheckBox checkBoxLatitudine;
        private System.Windows.Forms.CheckBox checkBoxLongitudine;
        private System.Windows.Forms.Label labelCampi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}