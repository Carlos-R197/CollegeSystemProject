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
    }
}
