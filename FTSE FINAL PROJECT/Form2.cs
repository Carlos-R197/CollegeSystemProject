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
        }
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (!Estudiante.VerificarIdExiste(Int32.Parse(txtEnrollment.Text)))
            {
                Estudiante.AñadirEstudiante(new Estudiante(Int32.Parse(this.txtEnrollment.Text), this.txtPassword.Text, this.txtName.Text, this.txtCareer.Text));
                MessageBox.Show("El usuario fue creado satisfactoriamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            else
                MessageBox.Show("Ese id ya existe. Use uno diferente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        } 
        private void TxtEnrollment_TextChanged(object sender, EventArgs e)
        {
            int id;

            if (!Int32.TryParse(this.txtEnrollment.Text, out id))
            {
                errorProvider1.SetError(txtEnrollment, "No puede haber caracteres en el id.");
                txtEnrollment.Clear();

            }
            else
                errorProvider1.Clear();

            UpdateButton();

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 3)
                errorProvider1.SetError(txtName, "Debe tener por lo menos 3 caracteres.");

            else
                errorProvider1.Clear();

            UpdateButton();
        }
        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals(txtPasswordConfirm) || string.IsNullOrEmpty(txtPassword.Text))
                errorProvider1.SetError(txtPassword, "Las contraseñas deben ser iguales.");
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
            int num;
            btnSignUp.Enabled = Int32.TryParse(txtEnrollment.Text, out num) && txtName.Text.Length >= 3 && 
                               (txtPassword.Text.Equals(txtPasswordConfirm.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                                && !string.IsNullOrEmpty(txtCareer.Text);

        }
    }
}
