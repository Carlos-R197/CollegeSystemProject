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
using System.IO;

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

            if (RegistroManager.DeterminarCantidadArchivos(Environment.CurrentDirectory + "\\" + ActualEstudiante.ID) >= 1)
            {
                RegistroManager.LlenarListaRegistro(Environment.CurrentDirectory + "\\"
                                                    + ActualEstudiante.ID + "\\Trimestre" + labelNumTrismestre.Text + ".csv");
            }
            AddData();
        }

        public void AddData()
        {
            ThisListView.Items.Clear();
            foreach (Registro registro in RegistroManager.registros)
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            RegistroManager.GuardarTrimestreEspecifico(ActualEstudiante.ID, Int32.Parse(labelNumTrismestre.Text));
            labelNumTrismestre.Text = (RegistroManager.DeterminarCantidadArchivos((Environment.CurrentDirectory + "\\" + ActualEstudiante.ID.ToString())) + 1).ToString();
        }

        private void BtnModifyTri_Click(object sender, EventArgs e)
        {
            int numTrimestres = RegistroManager.DeterminarCantidadArchivos(Environment.CurrentDirectory + "\\" + ActualEstudiante.ID);

            if (Int32.Parse(txtTrimester.Text) > numTrimestres || Int32.Parse(txtTrimester.Text) < 0)
            {
                errorProvider1.SetError(txtTrimester, "trimestre no válido");
                txtTrimester.Clear();
            }
            else
            {
                string path = RegistroManager.ObtenerPathDeArchivo(ActualEstudiante.ID, Int32.Parse(txtTrimester.Text));
                RegistroManager.registros.Clear();
                string[] lineas = File.ReadAllLines(path);
                string[] data;
                for (int i = 1; i < lineas.Length; i++)
                {
                    data = lineas[i].Split(',');
                    RegistroManager.registros.Add(new Registro(data[0], data[1], data[2]));
                }
                AddData();
                labelNumTrismestre.Text = txtTrimester.Text;
                txtTrimester.Text = string.Empty;
            }
        }

        private void ThisListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (ThisListView.Items.Count > 0 && ThisListView.SelectedItems.Count > 0)
            {
                ModifySubjectForm f = new ModifySubjectForm(ThisListView.SelectedItems[0].SubItems[0].Text,
                                                            ThisListView.SelectedItems[0].SubItems[1].Text,
                                                            ThisListView.SelectedItems[0].SubItems[2].Text,
                                                            ActualEstudiante.ID,
                                                            Int32.Parse(labelNumTrismestre.Text));
                f.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar algo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
