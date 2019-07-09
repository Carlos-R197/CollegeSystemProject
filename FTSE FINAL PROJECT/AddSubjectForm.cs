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
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Registro NuevoRegistro = new Registro(txtSubject.Text, txtCred.Text, Int16.Parse(txtGrade.Text));

            RegistroManager.registros.Add(NuevoRegistro);

            txtSubject.Clear();
            txtCred.Clear();
            txtGrade.Clear();
            this.Close();
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
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TxtGrade_TextChanged(object sender, EventArgs e)
        {
            short grade;
            //Si grado no es un numero entre 0 y 100 tirar error.
            if (!Int16.TryParse(this.txtCred.Text, out grade) || Int16.Parse(txtGrade.Text) > 100 || Int16.Parse(txtGrade.Text) < 0)
            {
                errorProvider1.SetError(txtCred, "El grado debe un numero entre 0 y 100.");
                txtCred.Clear();
            }
            else
                errorProvider1.Clear();
        }
    }
}
