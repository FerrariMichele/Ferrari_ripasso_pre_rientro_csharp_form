namespace Ferrari_ripasso_pre_rientro_csharp_form
{
    partial class FormSearch
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearchId = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelSearchNum = new System.Windows.Forms.Label();
            this.panelRecord = new System.Windows.Forms.Panel();
            this.labelRecordText = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.panelSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.labelSearchId);
            this.panelSearch.Location = new System.Drawing.Point(275, 25);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(250, 150);
            this.panelSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(106)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(85, 100);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Cerca";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(25, 55);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(200, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // labelSearchId
            // 
            this.labelSearchId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchId.ForeColor = System.Drawing.Color.White;
            this.labelSearchId.Location = new System.Drawing.Point(0, 0);
            this.labelSearchId.Name = "labelSearchId";
            this.labelSearchId.Size = new System.Drawing.Size(250, 50);
            this.labelSearchId.TabIndex = 0;
            this.labelSearchId.Text = "Id OpenStreetMap";
            this.labelSearchId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(22)))), ((int)(((byte)(0)))));
            this.panelResult.Controls.Add(this.labelSearchNum);
            this.panelResult.Controls.Add(this.labelPosition);
            this.panelResult.Location = new System.Drawing.Point(275, 200);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(250, 150);
            this.panelResult.TabIndex = 1;
            // 
            // labelPosition
            // 
            this.labelPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.ForeColor = System.Drawing.Color.White;
            this.labelPosition.Location = new System.Drawing.Point(0, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(250, 50);
            this.labelPosition.TabIndex = 1;
            this.labelPosition.Text = "Posizione:";
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSearchNum
            // 
            this.labelSearchNum.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchNum.ForeColor = System.Drawing.Color.White;
            this.labelSearchNum.Location = new System.Drawing.Point(0, 50);
            this.labelSearchNum.Name = "labelSearchNum";
            this.labelSearchNum.Size = new System.Drawing.Size(250, 77);
            this.labelSearchNum.TabIndex = 2;
            this.labelSearchNum.Text = "####";
            this.labelSearchNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRecord
            // 
            this.panelRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(1)))), ((int)(((byte)(16)))));
            this.panelRecord.Controls.Add(this.labelRecordText);
            this.panelRecord.Controls.Add(this.labelRecord);
            this.panelRecord.Location = new System.Drawing.Point(275, 375);
            this.panelRecord.Name = "panelRecord";
            this.panelRecord.Size = new System.Drawing.Size(250, 150);
            this.panelRecord.TabIndex = 2;
            // 
            // labelRecordText
            // 
            this.labelRecordText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelRecordText.ForeColor = System.Drawing.Color.White;
            this.labelRecordText.Location = new System.Drawing.Point(10, 50);
            this.labelRecordText.Name = "labelRecordText";
            this.labelRecordText.Size = new System.Drawing.Size(230, 90);
            this.labelRecordText.TabIndex = 2;
            this.labelRecordText.Text = "####";
            this.labelRecordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecord
            // 
            this.labelRecord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecord.ForeColor = System.Drawing.Color.White;
            this.labelRecord.Location = new System.Drawing.Point(0, 0);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(250, 50);
            this.labelRecord.TabIndex = 1;
            this.labelRecord.Text = "Record:";
            this.labelRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelRecord);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelSearch);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearchId;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelSearchNum;
        private System.Windows.Forms.Panel panelRecord;
        private System.Windows.Forms.Label labelRecordText;
        private System.Windows.Forms.Label labelRecord;
    }
}