using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using Clases;

namespace FTSE_FINAL_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Estudiante.CrearArchivo();
        }     

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            if (Estudiante.VerificarEstudianteExiste(Int32.Parse(this.txtEnrollment.Text), this.txtPassword.Text))
            {
                this.Hide();
                UserInterface F3 = new UserInterface();
                F3.ObtenerDataUser(txtEnrollment.Text);
                F3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
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
            {
                errorProvider1.Clear();
            }
        }
    }
}
