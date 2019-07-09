using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTSE_FINAL_PROJECT
{
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            btnSave.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Registro NuevoRegistro = new Registro(txtSubject.Text, txtCred.Text, short.Parse(txtGrade.Text));
            RegistroManager.registros.Add(NuevoRegistro);

            txtSubject.Clear();
            txtCred.Clear();
            txtGrade.Clear();
            this.Close();

            txtGrade.Clear();
        }
        private void TxtCred_TextChanged(object sender, EventArgs e)
        {
            int id;

            if (!Int32.TryParse(this.txtCred.Text, out id))
            {
                errorProvider1.SetError(txtCred, "No puede haber carácteres en los créditos.");
                txtCred.Clear();
            }
            else
                errorProvider1.Clear();
            UpdateButton();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TxtGrade_TextChanged(object sender, EventArgs e)
        {
            short grade;
            //Si grado no es un numero entre 0 y 100 tirar error.
            if (!Int16.TryParse(this.txtGrade.Text, out grade))
            {
                if (grade > 100 || grade < 0)
                    errorProvider1.SetError(txtGrade, "El grado debe un numero entre 0 y 100.");
                txtGrade.Clear();
            }
            else
                errorProvider1.Clear();
            UpdateButton();
        }
        private void TxtSubject_TextChanged(object sender, EventArgs e)
        {
            if (txtSubject.Text == string.Empty)
                errorProvider1.SetError(txtSubject, "Debe escribir la asignatura");
            else
                errorProvider1.Clear();
            UpdateButton();
        }
        private void UpdateButton()
        {
            int num, grade;
            btnSave.Enabled = txtSubject.Text != string.Empty && Int32.TryParse(txtCred.Text, out num) && (Int32.TryParse(txtGrade.Text, out grade) && !(grade > 100));
        }
    }
}
