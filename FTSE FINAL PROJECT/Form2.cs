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
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            string passwordText = this.txtPassword.Text;
            string confirmPassword = this.txtPasswordConfirm.Text;
            if (passwordText.Equals(confirmPassword) && (!string.IsNullOrEmpty(passwordText) && !string.IsNullOrEmpty(confirmPassword)))
            {
                if (!string.IsNullOrEmpty(this.txtEnrollment.Text) && !Estudiante.VerificarIdExiste(Int32.Parse(this.txtEnrollment.Text)))
                {
                    Estudiante.AñadirEstudiante(new Estudiante(Int32.Parse(this.txtEnrollment.Text), passwordText, this.txtName.Text, this.txtCareer.Text));
                    MessageBox.Show("El usuario fue creado satisfactoriamente", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Ese id ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
