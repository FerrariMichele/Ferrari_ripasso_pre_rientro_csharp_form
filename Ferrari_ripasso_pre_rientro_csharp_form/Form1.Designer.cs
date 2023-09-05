namespace Ferrari_ripasso_pre_rientro_csharp_form
{
    partial class form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelExit = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonViewFields = new System.Windows.Forms.Button();
            this.buttonAddToQueue = new System.Windows.Forms.Button();
            this.buttonMaxLen = new System.Windows.Forms.Button();
            this.buttonCountFields = new System.Windows.Forms.Button();
            this.buttonMyValue = new System.Windows.Forms.Button();
            this.buttonAddMyValue = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.panelSideMenu.Controls.Add(this.buttonLogOut);
            this.panelSideMenu.Controls.Add(this.panelButtons);
            this.panelSideMenu.Controls.Add(this.panelTitle);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.Image")));
            this.buttonLogOut.Location = new System.Drawing.Point(0, 481);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(200, 50);
            this.buttonLogOut.TabIndex = 17;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panelExit);
            this.panelButtons.Controls.Add(this.buttonDelete);
            this.panelButtons.Controls.Add(this.buttonModify);
            this.panelButtons.Controls.Add(this.buttonSearch);
            this.panelButtons.Controls.Add(this.buttonViewFields);
            this.panelButtons.Controls.Add(this.buttonAddToQueue);
            this.panelButtons.Controls.Add(this.buttonMaxLen);
            this.panelButtons.Controls.Add(this.buttonCountFields);
            this.panelButtons.Controls.Add(this.buttonMyValue);
            this.panelButtons.Controls.Add(this.buttonAddMyValue);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 84);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(200, 363);
            this.panelButtons.TabIndex = 1;
            // 
            // panelExit
            // 
            this.panelExit.Location = new System.Drawing.Point(0, 366);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(200, 108);
            this.panelExit.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(0, 315);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 45);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Cancella Record";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonModify.FlatAppearance.BorderSize = 0;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Location = new System.Drawing.Point(0, 270);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(200, 45);
            this.buttonModify.TabIndex = 15;
            this.buttonModify.Text = "Modifica Record";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(0, 225);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(200, 45);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Ricerca Record";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonViewFields
            // 
            this.buttonViewFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonViewFields.FlatAppearance.BorderSize = 0;
            this.buttonViewFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewFields.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewFields.Location = new System.Drawing.Point(0, 180);
            this.buttonViewFields.Name = "buttonViewFields";
            this.buttonViewFields.Size = new System.Drawing.Size(200, 45);
            this.buttonViewFields.TabIndex = 13;
            this.buttonViewFields.Text = "Visualizza Campi";
            this.buttonViewFields.UseVisualStyleBackColor = true;
            this.buttonViewFields.Click += new System.EventHandler(this.buttonViewFields_Click);
            // 
            // buttonAddToQueue
            // 
            this.buttonAddToQueue.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddToQueue.FlatAppearance.BorderSize = 0;
            this.buttonAddToQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToQueue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToQueue.Location = new System.Drawing.Point(0, 135);
            this.buttonAddToQueue.Name = "buttonAddToQueue";
            this.buttonAddToQueue.Size = new System.Drawing.Size(200, 45);
            this.buttonAddToQueue.TabIndex = 12;
            this.buttonAddToQueue.Text = "Aggiunta Record In Coda";
            this.buttonAddToQueue.UseVisualStyleBackColor = true;
            this.buttonAddToQueue.Click += new System.EventHandler(this.buttonAddToQueue_Click);
            // 
            // buttonMaxLen
            // 
            this.buttonMaxLen.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMaxLen.FlatAppearance.BorderSize = 0;
            this.buttonMaxLen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaxLen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaxLen.Location = new System.Drawing.Point(0, 90);
            this.buttonMaxLen.Name = "buttonMaxLen";
            this.buttonMaxLen.Size = new System.Drawing.Size(200, 45);
            this.buttonMaxLen.TabIndex = 11;
            this.buttonMaxLen.Text = "Lunghezza Record/Campi";
            this.buttonMaxLen.UseVisualStyleBackColor = true;
            this.buttonMaxLen.Click += new System.EventHandler(this.buttonMaxLen_Click);
            // 
            // buttonCountFields
            // 
            this.buttonCountFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCountFields.FlatAppearance.BorderSize = 0;
            this.buttonCountFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCountFields.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCountFields.Location = new System.Drawing.Point(0, 45);
            this.buttonCountFields.Name = "buttonCountFields";
            this.buttonCountFields.Size = new System.Drawing.Size(200, 45);
            this.buttonCountFields.TabIndex = 10;
            this.buttonCountFields.Text = "Conta Campi";
            this.buttonCountFields.UseVisualStyleBackColor = true;
            this.buttonCountFields.Click += new System.EventHandler(this.buttonCountFields_Click);
            // 
            // buttonMyValue
            // 
            this.buttonMyValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMyValue.FlatAppearance.BorderSize = 0;
            this.buttonMyValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyValue.Location = new System.Drawing.Point(0, 0);
            this.buttonMyValue.Name = "buttonMyValue";
            this.buttonMyValue.Size = new System.Drawing.Size(200, 45);
            this.buttonMyValue.TabIndex = 9;
            this.buttonMyValue.Text = "Aggiunta Miovalore";
            this.buttonMyValue.UseVisualStyleBackColor = true;
            this.buttonMyValue.Click += new System.EventHandler(this.buttonMyValue_Click);
            // 
            // buttonAddMyValue
            // 
            this.buttonAddMyValue.Location = new System.Drawing.Point(0, 0);
            this.buttonAddMyValue.Name = "buttonAddMyValue";
            this.buttonAddMyValue.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMyValue.TabIndex = 8;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(200, 84);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(200, 84);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Pizzerie, Rosticcerie, Fast Food e Kebabbari in Italia";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(0, 25);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(200, 45);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Uscita";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelForm.BackgroundImage")));
            this.panelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(200, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(784, 561);
            this.panelForm.TabIndex = 2;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "form1";
            this.Text = "Registro delle Pizzerie, Rosticcerie, Fast Food e Kebabbari in Italia";
            this.Load += new System.EventHandler(this.form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAddMyValue;
        private System.Windows.Forms.Button buttonMyValue;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonViewFields;
        private System.Windows.Forms.Button buttonAddToQueue;
        private System.Windows.Forms.Button buttonMaxLen;
        private System.Windows.Forms.Button buttonCountFields;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button buttonLogOut;
    }
}

