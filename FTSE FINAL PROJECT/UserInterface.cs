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
    public partial class UserInterface : Form
    {
        private Estudiante ActualEstudiante;

        public UserInterface()
        {
            InitializeComponent();
        }

        public void ObtenerDataUser(string id)
        {
            foreach (Estudiante Estudiante in Estudiante.ObtenerListaEstudiantes())
            {
                if (Estudiante.ID == Convert.ToInt32(id))
                {
                    ActualEstudiante = Estudiante;
                    break;
                }
            }

            labelName.Text = ActualEstudiante.Nombre;
            labelCareer.Text = ActualEstudiante.Carrera;
        }

        public void AddData()
        {
            foreach(Registro registro in RegistroManager.registros)
            {
                ListViewItem a = ThisListView.Items.Add(registro.subject);

                a.SubItems.Add(registro.credValue);
                a.SubItems.Add(registro.grade);
            }
        }

        private void BtnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubjectForm F4 = new AddSubjectForm();

            F4.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            AddData();
        }
    }
}
