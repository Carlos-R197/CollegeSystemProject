namespace FTSE_FINAL_PROJECT
{
    partial class ReportForm
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
            this.ThisListBox = new System.Windows.Forms.ListBox();
            this.btnAlright = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThisListBox
            // 
            this.ThisListBox.FormattingEnabled = true;
            this.ThisListBox.Location = new System.Drawing.Point(2, 12);
            this.ThisListBox.Name = "ThisListBox";
            this.ThisListBox.ScrollAlwaysVisible = true;
            this.ThisListBox.Size = new System.Drawing.Size(799, 420);
            this.ThisListBox.TabIndex = 0;
            // 
            // btnAlright
            // 
            this.btnAlright.Location = new System.Drawing.Point(726, 442);
            this.btnAlright.Name = "btnAlright";
            this.btnAlright.Size = new System.Drawing.Size(75, 23);
            this.btnAlright.TabIndex = 1;
            this.btnAlright.Text = "Listo";
            this.btnAlright.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(645, 442);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 34);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Actualizar Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 477);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAlright);
            this.Controls.Add(this.ThisListBox);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ThisListBox;
        private System.Windows.Forms.Button btnAlright;
        private System.Windows.Forms.Button btnRefresh;
    }
}