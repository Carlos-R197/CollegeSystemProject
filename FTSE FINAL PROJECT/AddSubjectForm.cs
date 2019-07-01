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
            Registro NuevoRegistro = new Registro(txtSubject.Text, txtCred.Text, txtGrade.Text);

            RegistroManager.registros.Add(NuevoRegistro);

            txtSubject.Clear();
            txtCred.Clear();
            txtGrade.Clear();
            this.Close();
        }
    }
}
