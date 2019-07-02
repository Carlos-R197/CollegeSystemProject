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
        private int ID { get; set; }
        private int Trimestre { get; set; }
        public ModifySubjectForm(string materia, string creditos, string nota, int id, int trimestre)
        {
            InitializeComponent();

            this.Materia = materia;
            this.ID = id;
            this.Trimestre = trimestre;
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
                    reg.grade = txtGrade.Text;
                    //RegistroManager.ModificarRegistro(ID, Trimestre);
                    break;
                }
            }

            txtSubject.Clear();
            txtCred.Clear();
            txtGrade.Clear();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtSubject.Clear();
            txtCred.Clear();
            txtGrade.Clear();
            this.Close();
        }
    }
}
