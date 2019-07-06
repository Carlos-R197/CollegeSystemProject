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
            this.ThisListBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThisListBox.FormattingEnabled = true;
            this.ThisListBox.ItemHeight = 31;
            this.ThisListBox.Location = new System.Drawing.Point(3, 15);
            this.ThisListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ThisListBox.Name = "ThisListBox";
            this.ThisListBox.ScrollAlwaysVisible = true;
            this.ThisListBox.Size = new System.Drawing.Size(1064, 500);
            this.ThisListBox.TabIndex = 0;
            // 
            // btnAlright
            // 
            this.btnAlright.Location = new System.Drawing.Point(968, 544);
            this.btnAlright.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlright.Name = "btnAlright";
            this.btnAlright.Size = new System.Drawing.Size(100, 28);
            this.btnAlright.TabIndex = 1;
            this.btnAlright.Text = "Listo";
            this.btnAlright.UseVisualStyleBackColor = true;
            this.btnAlright.Click += new System.EventHandler(this.BtnAlright_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(860, 544);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 42);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Actualizar Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 587);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAlright);
            this.Controls.Add(this.ThisListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
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