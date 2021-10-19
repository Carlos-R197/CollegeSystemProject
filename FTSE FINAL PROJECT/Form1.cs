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
using System.IO;

namespace FTSE_FINAL_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Estudiante.CrearArchivo();
            Profesor.CrearArchivo();
            CrearArchivoAdministrador();
            
        }

        private void CrearArchivoAdministrador()
        {
            string path = Environment.CurrentDirectory + "\\" + Administrador.ID;

            Directory.CreateDirectory(path);

            File.AppendAllText((path + "\\" + Administrador.ID + ".csv"), (Administrador.ID + "," + Administrador.Nombre + "," + Administrador.Password));
        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            if (txtEnrollment.Text.StartsWith("1"))
            {
                if (Estudiante.VerificarEstudianteExiste(this.txtEnrollment.Text, this.txtPassword.Text))
                {
                    AbrirUserInterface();
                }
                else
                {
                    if (!Estudiante.VerificarIdExiste(txtEnrollment.Text))
                        MessageBox.Show("El id no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    else if (!Estudiante.VerificarPasswordExiste(txtPassword.Text))
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    else
                        MessageBox.Show("Datos incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txtEnrollment.Text.StartsWith("2"))
            {
                if (Profesor.VerificarProfesorExiste(this.txtEnrollment.Text, this.txtPassword.Text))
                {
                    this.Hide();
                    ProfesorInterface F3 = new ProfesorInterface();
                    F3.ObtenerDataUser(txtEnrollment.Text);
                    F3.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (!Profesor.VerificarIdExiste(txtEnrollment.Text))
                        MessageBox.Show("El id no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    else if (!Profesor.VerificarPasswordExiste(txtPassword.Text))
                        MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    else
                        MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            /*
            else if (txtEnrollment.Text.StartsWith("x"))
            {
                if (txtPassword.Text.Equals("654123"))
                {
                    this.Hide();
                    AdministradorInterface F3 = new AdministradorInterface();
                    F3.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            */
            else
            if (txtEnrollment.Text.StartsWith("3"))
            {
                if (txtEnrollment.Text == Administrador.ID && txtPassword.Text == Administrador.Password)
                {
                    this.Hide();
                    AdministradorInterface F = new AdministradorInterface();
                    F.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (Administrador.Password != txtPassword.Text)
                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    MessageBox.Show("Datos incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("El id no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void AbrirUserInterface()
        {
            this.Hide();
            UserInterface F3 = new UserInterface();
            F3.ObtenerDataUser(txtEnrollment.Text);
            F3.ShowDialog();
            this.Close();
        }

        private void TxtEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (!(txtEnrollment.Text.StartsWith("1") || txtEnrollment.Text.StartsWith("2") || txtEnrollment.Text.StartsWith("3")))
            {
                errorProvider1.SetError(txtEnrollment, "Los ids registrados empiezan por 1, 2, 3");
                txtEnrollment.Clear();
            }
        }

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
