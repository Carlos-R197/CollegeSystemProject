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
    public partial class ModifySubjectForm : Form
    {
        private string Materia { get; set; }
        public ModifySubjectForm(string materia, string creditos, string nota)
        {
            InitializeComponent();
            this.CenterToScreen();

            this.Materia = materia;
            txtSubject.Text = materia;
            txtCred.Text = creditos;
            txtGrade.Text = nota;
        }    
        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Registro reg in RegistroManager.registros)
            {
                if (reg.subject == Materia)
                {
                    reg.subject = txtSubject.Text;
                    reg.credValue = txtCred.Text;
                    reg.grade = Int16.Parse(txtGrade.Text);
                    break;
                }
            }

            txtSubject.Clear();
            txtCred.Clear();
            txtGrade.Clear();
            this.Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtSubject.Clear();
            txtCred.Clear();
            txtGrade.Clear();
            this.Close();
        }
        private void TxtGrade_TextChanged(object sender, EventArgs e)
        {
            short grade;
            //Si el grado es un caracterar tira error.
            if (!Int16.TryParse(this.txtGrade.Text, out grade))
            {
                errorProvider1.SetError(txtGrade, "El grado debe un numero entre 0 y 100.");
                txtGrade.Clear();
            }
            //Si el grado es mayor que 100 tira error.
            else
            {
                if (grade > 100)
                {
                    errorProvider1.SetError(txtGrade, "El grado debe un numero entre 0 y 100.");
                    txtGrade.Clear();
                }
                else
                    errorProvider1.Clear();
            }
            UpdateButton();
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

        private void TxtSubject_TextChanged(object sender, EventArgs e)
        {
            if (txtSubject.Text == string.Empty)
                errorProvider1.SetError(txtSubject, "Debe escribir la asignatura");
            else
                errorProvider1.Clear();
            UpdateButton();
        }
        //Actualiza el boton cada que vez se cambia algo en una de las formas
        private void UpdateButton()
        {
            int num, grade;
            btnSave.Enabled = txtSubject.Text != string.Empty && Int32.TryParse(txtCred.Text, out num) && (Int32.TryParse(txtGrade.Text, out grade) && !(grade > 100));
        }
    }
}
