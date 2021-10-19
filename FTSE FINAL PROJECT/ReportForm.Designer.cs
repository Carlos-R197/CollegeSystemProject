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
			this.SuspendLayout();
			// 
			// ThisListBox
			// 
			this.ThisListBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ThisListBox.FormattingEnabled = true;
			this.ThisListBox.ItemHeight = 25;
			this.ThisListBox.Location = new System.Drawing.Point(2, 12);
			this.ThisListBox.Name = "ThisListBox";
			this.ThisListBox.ScrollAlwaysVisible = true;
			this.ThisListBox.Size = new System.Drawing.Size(799, 404);
			this.ThisListBox.TabIndex = 0;
			// 
			// btnAlright
			// 
			this.btnAlright.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnAlright.Location = new System.Drawing.Point(716, 442);
			this.btnAlright.Name = "btnAlright";
			this.btnAlright.Size = new System.Drawing.Size(75, 23);
			this.btnAlright.TabIndex = 1;
			this.btnAlright.Text = "Listo";
			this.btnAlright.UseVisualStyleBackColor = false;
			this.btnAlright.Click += new System.EventHandler(this.BtnAlright_Click);
			// 
			// ReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.ClientSize = new System.Drawing.Size(803, 477);
			this.Controls.Add(this.btnAlright);
			this.Controls.Add(this.ThisListBox);
			this.MaximizeBox = false;
			this.Name = "ReportForm";
			this.Text = "Reporte Academico";
			this.Load += new System.EventHandler(this.ReportForm_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ThisListBox;
        private System.Windows.Forms.Button btnAlright;
    }
}