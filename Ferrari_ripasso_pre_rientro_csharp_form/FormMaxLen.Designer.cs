namespace Ferrari_ripasso_pre_rientro_csharp_form
{
    partial class FormMaxLen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRecordMaxLen = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFieldsMaxLen = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.labelRecordMaxLen);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 119);
            this.panel1.TabIndex = 0;
            // 
            // labelRecordMaxLen
            // 
            this.labelRecordMaxLen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecordMaxLen.Location = new System.Drawing.Point(30, 0);
            this.labelRecordMaxLen.Name = "labelRecordMaxLen";
            this.labelRecordMaxLen.Size = new System.Drawing.Size(700, 119);
            this.labelRecordMaxLen.TabIndex = 0;
            this.labelRecordMaxLen.Text = "label1";
            this.labelRecordMaxLen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel1.Controls.Add(this.labelFieldsMaxLen);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 147);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(760, 402);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelFieldsMaxLen
            // 
            this.labelFieldsMaxLen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFieldsMaxLen.ForeColor = System.Drawing.Color.White;
            this.labelFieldsMaxLen.Location = new System.Drawing.Point(3, 0);
            this.labelFieldsMaxLen.Name = "labelFieldsMaxLen";
            this.labelFieldsMaxLen.Size = new System.Drawing.Size(757, 402);
            this.labelFieldsMaxLen.TabIndex = 0;
            this.labelFieldsMaxLen.Text = "label1";
            this.labelFieldsMaxLen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMaxLen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FormMaxLen";
            this.Text = "FormMaxLen";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelRecordMaxLen;
        private System.Windows.Forms.Label labelFieldsMaxLen;
    }
}