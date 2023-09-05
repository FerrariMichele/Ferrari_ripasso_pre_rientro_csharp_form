namespace Ferrari_ripasso_pre_rientro_csharp_form
{
    partial class FormDelete
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
            this.panelPermDelete = new System.Windows.Forms.Panel();
            this.buttonPermDelete = new System.Windows.Forms.Button();
            this.labelPermDelete = new System.Windows.Forms.Label();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.labelDeleteId = new System.Windows.Forms.Label();
            this.panelRecover = new System.Windows.Forms.Panel();
            this.buttonRecover = new System.Windows.Forms.Button();
            this.textBoxRecover = new System.Windows.Forms.TextBox();
            this.labelRecoverId = new System.Windows.Forms.Label();
            this.labelDeleteTitle = new System.Windows.Forms.Label();
            this.labelPermDeleteTitle = new System.Windows.Forms.Label();
            this.labelRecoverTitle = new System.Windows.Forms.Label();
            this.panelPermDelete.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.panelRecover.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPermDelete
            // 
            this.panelPermDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(1)))), ((int)(((byte)(16)))));
            this.panelPermDelete.Controls.Add(this.buttonPermDelete);
            this.panelPermDelete.Controls.Add(this.labelPermDelete);
            this.panelPermDelete.Location = new System.Drawing.Point(267, 380);
            this.panelPermDelete.Name = "panelPermDelete";
            this.panelPermDelete.Size = new System.Drawing.Size(250, 150);
            this.panelPermDelete.TabIndex = 5;
            // 
            // buttonPermDelete
            // 
            this.buttonPermDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(106)))));
            this.buttonPermDelete.FlatAppearance.BorderSize = 0;
            this.buttonPermDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPermDelete.Location = new System.Drawing.Point(85, 85);
            this.buttonPermDelete.Name = "buttonPermDelete";
            this.buttonPermDelete.Size = new System.Drawing.Size(80, 23);
            this.buttonPermDelete.TabIndex = 3;
            this.buttonPermDelete.Text = "Ricompatta";
            this.buttonPermDelete.UseVisualStyleBackColor = false;
            this.buttonPermDelete.Click += new System.EventHandler(this.buttonPermDelete_Click);
            // 
            // labelPermDelete
            // 
            this.labelPermDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermDelete.ForeColor = System.Drawing.Color.White;
            this.labelPermDelete.Location = new System.Drawing.Point(0, 0);
            this.labelPermDelete.Name = "labelPermDelete";
            this.labelPermDelete.Size = new System.Drawing.Size(250, 82);
            this.labelPermDelete.TabIndex = 1;
            this.labelPermDelete.Text = "Ricompatta";
            this.labelPermDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.panelDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDelete.Controls.Add(this.buttonDelete);
            this.panelDelete.Controls.Add(this.textBoxDelete);
            this.panelDelete.Controls.Add(this.labelDeleteId);
            this.panelDelete.Location = new System.Drawing.Point(267, 30);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(250, 150);
            this.panelDelete.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(106)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(85, 100);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Cancella";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(25, 55);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(200, 20);
            this.textBoxDelete.TabIndex = 1;
            // 
            // labelDeleteId
            // 
            this.labelDeleteId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteId.ForeColor = System.Drawing.Color.White;
            this.labelDeleteId.Location = new System.Drawing.Point(0, 0);
            this.labelDeleteId.Name = "labelDeleteId";
            this.labelDeleteId.Size = new System.Drawing.Size(250, 50);
            this.labelDeleteId.TabIndex = 0;
            this.labelDeleteId.Text = "Id OpenStreetMap";
            this.labelDeleteId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRecover
            // 
            this.panelRecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(22)))), ((int)(((byte)(0)))));
            this.panelRecover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelRecover.Controls.Add(this.buttonRecover);
            this.panelRecover.Controls.Add(this.textBoxRecover);
            this.panelRecover.Controls.Add(this.labelRecoverId);
            this.panelRecover.Location = new System.Drawing.Point(523, 205);
            this.panelRecover.Name = "panelRecover";
            this.panelRecover.Size = new System.Drawing.Size(250, 150);
            this.panelRecover.TabIndex = 6;
            // 
            // buttonRecover
            // 
            this.buttonRecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(106)))));
            this.buttonRecover.FlatAppearance.BorderSize = 0;
            this.buttonRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecover.Location = new System.Drawing.Point(85, 100);
            this.buttonRecover.Name = "buttonRecover";
            this.buttonRecover.Size = new System.Drawing.Size(80, 23);
            this.buttonRecover.TabIndex = 2;
            this.buttonRecover.Text = "Recupera";
            this.buttonRecover.UseVisualStyleBackColor = false;
            this.buttonRecover.Click += new System.EventHandler(this.buttonRecover_Click);
            // 
            // textBoxRecover
            // 
            this.textBoxRecover.Location = new System.Drawing.Point(25, 55);
            this.textBoxRecover.Name = "textBoxRecover";
            this.textBoxRecover.Size = new System.Drawing.Size(200, 20);
            this.textBoxRecover.TabIndex = 1;
            // 
            // labelRecoverId
            // 
            this.labelRecoverId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecoverId.ForeColor = System.Drawing.Color.White;
            this.labelRecoverId.Location = new System.Drawing.Point(0, 0);
            this.labelRecoverId.Name = "labelRecoverId";
            this.labelRecoverId.Size = new System.Drawing.Size(250, 50);
            this.labelRecoverId.TabIndex = 0;
            this.labelRecoverId.Text = "Id OpenStreetMap";
            this.labelRecoverId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeleteTitle
            // 
            this.labelDeleteTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDeleteTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteTitle.ForeColor = System.Drawing.Color.Black;
            this.labelDeleteTitle.Location = new System.Drawing.Point(14, 30);
            this.labelDeleteTitle.Name = "labelDeleteTitle";
            this.labelDeleteTitle.Size = new System.Drawing.Size(245, 150);
            this.labelDeleteTitle.TabIndex = 7;
            this.labelDeleteTitle.Text = "Cancellazione";
            this.labelDeleteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDeleteTitle.UseWaitCursor = true;
            // 
            // labelPermDeleteTitle
            // 
            this.labelPermDeleteTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermDeleteTitle.ForeColor = System.Drawing.Color.Black;
            this.labelPermDeleteTitle.Location = new System.Drawing.Point(19, 380);
            this.labelPermDeleteTitle.Name = "labelPermDeleteTitle";
            this.labelPermDeleteTitle.Size = new System.Drawing.Size(242, 150);
            this.labelPermDeleteTitle.TabIndex = 9;
            this.labelPermDeleteTitle.Text = "Ricompattazione";
            this.labelPermDeleteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecoverTitle
            // 
            this.labelRecoverTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecoverTitle.ForeColor = System.Drawing.Color.Black;
            this.labelRecoverTitle.Location = new System.Drawing.Point(267, 205);
            this.labelRecoverTitle.Name = "labelRecoverTitle";
            this.labelRecoverTitle.Size = new System.Drawing.Size(250, 150);
            this.labelRecoverTitle.TabIndex = 8;
            this.labelRecoverTitle.Text = "Recupero";
            this.labelRecoverTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelPermDeleteTitle);
            this.Controls.Add(this.labelRecoverTitle);
            this.Controls.Add(this.labelDeleteTitle);
            this.Controls.Add(this.panelRecover);
            this.Controls.Add(this.panelPermDelete);
            this.Controls.Add(this.panelDelete);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            this.panelPermDelete.ResumeLayout(false);
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panelRecover.ResumeLayout(false);
            this.panelRecover.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPermDelete;
        private System.Windows.Forms.Button buttonPermDelete;
        private System.Windows.Forms.Label labelPermDelete;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Label labelDeleteId;
        private System.Windows.Forms.Panel panelRecover;
        private System.Windows.Forms.Button buttonRecover;
        private System.Windows.Forms.TextBox textBoxRecover;
        private System.Windows.Forms.Label labelRecoverId;
        private System.Windows.Forms.Label labelDeleteTitle;
        private System.Windows.Forms.Label labelPermDeleteTitle;
        private System.Windows.Forms.Label labelRecoverTitle;
    }
}