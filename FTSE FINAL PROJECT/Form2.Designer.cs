namespace FTSE_FINAL_PROJECT
{
    partial class Form2
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCareer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.checkProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnCancel = new System.Windows.Forms.Button();
			this.myCombo = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.checkProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.IndianRed;
			this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(109, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(315, 59);
			this.label1.TabIndex = 1;
			this.label1.Text = "SISTEMA PARA CALCULAR EL INDICE ACADEMICO";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtPassword.Location = new System.Drawing.Point(208, 150);
			this.txtPassword.MaxLength = 20;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(279, 26);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.IndianRed;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(74, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Constraseña:";
			// 
			// txtPasswordConfirm
			// 
			this.txtPasswordConfirm.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPasswordConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtPasswordConfirm.Location = new System.Drawing.Point(208, 199);
			this.txtPasswordConfirm.MaxLength = 20;
			this.txtPasswordConfirm.Name = "txtPasswordConfirm";
			this.txtPasswordConfirm.Size = new System.Drawing.Size(279, 26);
			this.txtPasswordConfirm.TabIndex = 5;
			this.txtPasswordConfirm.UseSystemPasswordChar = true;
			this.txtPasswordConfirm.TextChanged += new System.EventHandler(this.TxtPasswordConfirm_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.IndianRed;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(11, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(187, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Confirmar contraseña:";
			// 
			// txtCareer
			// 
			this.txtCareer.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCareer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCareer.Location = new System.Drawing.Point(209, 245);
			this.txtCareer.MaxLength = 35;
			this.txtCareer.Name = "txtCareer";
			this.txtCareer.Size = new System.Drawing.Size(279, 26);
			this.txtCareer.TabIndex = 7;
			this.txtCareer.TextChanged += new System.EventHandler(this.TxtCareer_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.IndianRed;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(112, 249);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Carrera:";
			// 
			// btnSignUp
			// 
			this.btnSignUp.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignUp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSignUp.Location = new System.Drawing.Point(394, 330);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(93, 29);
			this.btnSignUp.TabIndex = 11;
			this.btnSignUp.Text = "Registrarse";
			this.btnSignUp.UseVisualStyleBackColor = false;
			this.btnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtName.Location = new System.Drawing.Point(209, 102);
			this.txtName.MaxLength = 30;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(279, 26);
			this.txtName.TabIndex = 12;
			this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.IndianRed;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(110, 102);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 20);
			this.label6.TabIndex = 13;
			this.label6.Text = "Nombre:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// checkProvider1
			// 
			this.checkProvider1.ContainerControl = this;
			this.checkProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("checkProvider1.Icon")));
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCancel.Location = new System.Drawing.Point(285, 330);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(93, 29);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Volver";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// myCombo
			// 
			this.myCombo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.myCombo.DisplayMember = "Text";
			this.myCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.myCombo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.myCombo.FormattingEnabled = true;
			this.myCombo.Location = new System.Drawing.Point(208, 293);
			this.myCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.myCombo.Name = "myCombo";
			this.myCombo.Size = new System.Drawing.Size(92, 21);
			this.myCombo.TabIndex = 14;
			this.myCombo.ValueMember = "ID";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.IndianRed;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(53, 292);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Tipo de registro:";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.ClientSize = new System.Drawing.Size(510, 370);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.myCombo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSignUp);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCareer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPasswordConfirm);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registrarse";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.checkProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCareer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider checkProvider1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox myCombo;
    }
}