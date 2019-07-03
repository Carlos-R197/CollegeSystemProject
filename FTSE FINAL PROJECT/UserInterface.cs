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

        //Obtiene la data del usuario/objeto estudiante que se logueo y la asigna al objeto ActualEstudiante
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
            labelNumTrismestre.Text = "1";

            string pathUsuario = Environment.CurrentDirectory + "\\" + id;
            if (RegistroManager.DeterminarCantidadArchivos(pathUsuario) > 0)
            {
                pathUsuario += "\\Trimestre" + labelNumTrismestre.Text + ".csv";
                RegistroManager.LlenarListaRegistro(pathUsuario);
                AddData();
            }
        }
        //Agrega toda la data disponible en la lista de registros al ListView
        public void AddData()
        {
            ThisListView.Items.Clear();

            foreach (Registro registro in RegistroManager.registros)
            {
                ListViewItem a = ThisListView.Items.Add(registro.subject);

                a.SubItems.Add(registro.credValue);
                a.SubItems.Add(registro.grade.ToString());
            }
        }
        //Muestra el formulario para agregar una nueva asignatura
        public void ShowAddSubjectForm()
        {
            AddSubjectForm F4 = new AddSubjectForm();

            F4.ShowDialog();
        }
        //Accede al archivo del trimestre para reescribirlo
        public void ModifyPeriod()
        {
            int numTrimestres = RegistroManager.DeterminarCantidadArchivos(Environment.CurrentDirectory + "\\" + ActualEstudiante.ID);
            try
            {
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
                        RegistroManager.registros.Add(new Registro(data[0], data[1], Int16.Parse(data[2])));
                    }
                    AddData();
                    labelNumTrismestre.Text = txtTrimester.Text;
                    txtTrimester.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Modificar un registro en el listview
        public void ModifyListViewData()
        {
            if (ThisListView.Items.Count > 0 && ThisListView.SelectedItems.Count > 0)
            {
                ModifySubjectForm f = new ModifySubjectForm(ThisListView.SelectedItems[0].SubItems[0].Text,
                                                            ThisListView.SelectedItems[0].SubItems[1].Text,
                                                            ThisListView.SelectedItems[0].SubItems[2].Text);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar algo para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BOTON para agregar asignatura
        private void BtnAddSubject_Click(object sender, EventArgs e)
        {
            ShowAddSubjectForm();
        }

        //BOTON para actualizar la informacion del listview
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            AddData();
        }

        //BOTON para guardar los registros del listview en un archivo de trimestres e informarle al usuario
        private void BtnSave_Click(object sender, EventArgs e)
        {
            int trimestreActual = Int32.Parse(labelNumTrismestre.Text);
            int PeriodValue = RegistroManager.GuardarTrimestreEspecifico(ActualEstudiante.ID, trimestreActual);

            MessageBox.Show($"El trimestre {PeriodValue} ha sido guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ThisListView.Items.Clear();
            labelNumTrismestre.Text = (RegistroManager.DeterminarCantidadArchivos(ActualEstudiante.ID.ToString()) + 1).ToString();
        }

        //BOTON para modificar el archivo del trimestre seleccionado
        private void BtnModifyTri_Click(object sender, EventArgs e)
        {
            ModifyPeriod();
        }

        //BOTON para modificar un registro del listview
        private void BtnModify_Click(object sender, EventArgs e)
        {
            ModifyListViewData();
        }

        private void BtnWatchReport_Click(object sender, EventArgs e)
        {
            ReportForm F = new ReportForm();
            F.GetId(ActualEstudiante.ID);
            F.ShowDialog();
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }
    }
}
