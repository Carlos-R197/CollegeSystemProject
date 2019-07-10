using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace FTSE_FINAL_PROJECT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnSignUp.Enabled = false;
            ComboItem[] combo =
            {
                new ComboItem {ID = 1, Text = "Estudiante" },
                new ComboItem {ID = 2, Text = "Profesor" }
            };
            myCombo.DataSource = combo;
        }
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if ((int) myCombo.SelectedValue == 1)
            {
                string id = Estudiante.AñadirEstudiante(new Estudiante(this.txtPassword.Text, this.txtName.Text, this.txtCareer.Text));
                MessageBox.Show($"El usuario fue creado satisfactoriamente \n Su id es: {id}", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                string id = Profesor.AñadirProfesor(new Profesor(this.txtName.Text, this.txtPassword.Text));
                MessageBox.Show($"El usuario fue creado satisfactoriamente \n Su id es: {id}", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
        } 

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 3)
                errorProvider1.SetError(txtName, "Debe tener por lo menos 3 caracteres.");

            else
                errorProvider1.Clear();

            UpdateButton();
        }
        
        private void TxtCareer_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCareer.Text))
                errorProvider1.SetError(txtCareer, "Debe llenar esta forma.");
            else
                errorProvider1.Clear();
            UpdateButton();
        }

        private void UpdateButton()
        {
            //int num;
            btnSignUp.Enabled = txtName.Text.Length >= 3 && 
                               (txtPassword.Text.Equals(txtPasswordConfirm.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                                && !string.IsNullOrEmpty(txtCareer.Text);

        }

        private void TxtPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                errorProvider1.SetError(txtPasswordConfirm, "Las contraseñas deben ser iguales.");
                checkProvider1.Clear();
            }
                
            else
            {
                errorProvider1.Clear();
                checkProvider1.SetError(txtPasswordConfirm, "Las contraseñas coinciden");
            }
                

            UpdateButton();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
