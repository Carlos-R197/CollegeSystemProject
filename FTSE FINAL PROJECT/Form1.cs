﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Estudiante.CrearArchivo();
            Profesor.CrearArchivo();
        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            if (Estudiante.VerificarEstudianteExiste(this.txtEnrollment.Text, this.txtPassword.Text))
            {
                this.Hide();
                UserInterface F3 = new UserInterface();
                F3.ObtenerDataUser(txtEnrollment.Text);
                F3.ShowDialog();
                this.Close();
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

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }


    }
}
