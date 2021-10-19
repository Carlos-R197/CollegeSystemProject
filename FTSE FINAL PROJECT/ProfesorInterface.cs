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
    public partial class ProfesorInterface : Form
    {
        private Profesor ActualProfesor;
        public static Seccion ActualSeccion;
        private enum State
        {
            ViendoSecciones,
            ViendoListaEst,
            ViendoListaEstCal
        }
        State estado = State.ViendoSecciones;
        public ProfesorInterface()
        {
            InitializeComponent();
            labelNumSec.Text = "X";
            //ActualSeccion = SeccionManager.ObtenerPrimeraSeccion(comboBoxAsig.SelectedItem.ToString(), ActualProfesor);
        }

        //Obtiene la data del usuario/objeto estudiante que se logueo y la asigna al objeto ActualProfesor
        public void ObtenerDataUser(string id)
        {
            foreach (Profesor profesor in Profesor.ObtenerListaProfesores())
            {
                if (profesor.Id.Equals(id))
                {
                    ActualProfesor = profesor;
                    break;
                }
            }

            labelName.Text = ActualProfesor.Nombre;

            BuscarAsignaturas();
            //comboBoxAsig.DataSource = combo;
            //comboBoxAsig.Items.Add("Calculo Diferencial");
           // comboBoxAsig.Items.Add("Calculo Integral");
        }
        //Agrega al list view los estudiantes existentes
        public void AddData()
        {
            ThisListView.Items.Clear();

            foreach (Estudiante est in Estudiante.ObtenerListaEstudiantes())
            {
                ListViewItem a = ThisListView.Items.Add(est.ID);

                a.SubItems.Add(est.Nombre);
            }
        }

        public string ConseguirIDEstudiante(string nombre)
        {
            string id = "";
            foreach (Estudiante est in Estudiante.ObtenerListaEstudiantes())
            {
                if (est.Nombre.Equals(nombre))
                {
                    id = est.ID;
                }
            }

            return id;
        }
        //Accede al archivo del trimestre para reescribirlo
        public void ModifyPeriod()
        {
            try
            {
                MostrarSeccionesExistentes();
                estado = State.ViendoSecciones;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BOTON para modificar el archivo del trimestre seleccionado
        private void BtnModifyTri_Click(object sender, EventArgs e)
        {
            ModifyPeriod();
        }

        //BOTON para modificar un registro del listview
        private void BtnModify_Click(object sender, EventArgs e)
        {
            estado = State.ViendoListaEst;
            ThisListView.Columns[0].Text = "ID";
            ThisListView.Columns[1].Text = "Nombre";
            AddData();
        }

        private void BtnWatchReport_Click(object sender, EventArgs e)
        {
            ReportForm F = new ReportForm();
            F.GetId(ActualProfesor.Id);
            F.ShowDialog();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ThisListView.Items.Count > 0 && ThisListView.SelectedItems.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Esta seguro de que desea eliminar al estudiante?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        ActualSeccion.EliminarEstudiante(ThisListView.SelectedItems[0].Text);
                        MostrarSeccionActual();
                    }
                    else if (result == DialogResult.No)
                    {
                        //no...
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un estudiante eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNewSec_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAsig.SelectedItem != null)
                {
                    ActualSeccion = new Seccion(ActualProfesor, comboBoxAsig.Text);
                    labelNumSec.Text = ActualSeccion.NumeroSeccion.ToString();
                    MessageBox.Show("La sección ha sido creada con éxito.", "Importante",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModifyPeriod();
                }
                else 
                {
                    MessageBox.Show("Debe de seleccionar una asignatura antes de intentar crear una sección",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (ThisListView.Items.Count > 0 && ThisListView.SelectedItems.Count > 0 && estado == State.ViendoListaEst)
                {
                    ActualSeccion.AñadirEstudiante(ThisListView.SelectedItems[0].SubItems[1].Text);
                    MostrarSeccionActual();
                }
                else
                    MessageBox.Show("Debe seleccionar un estudiante para añadir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filePath = Environment.CurrentDirectory + "\\" + ActualProfesor.Id + "\\" + comboBoxAsig.Text;
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                MostrarSeccionesExistentes();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarSeccionesExistentes()
        {
            ThisListView.Items.Clear();
            ThisListView.Columns[0].Text = "Sección";
            ThisListView.Columns[1].Text = "Materia";
            labelNumSec.Text = "x";
            estado = State.ViendoSecciones;

            List<Seccion> secciones = SeccionManager.ObtenerSecciones(comboBoxAsig.Text, ActualProfesor);
            if (secciones.Count > 0)
            {
                foreach (Seccion sec in secciones)
                {
                    ListViewItem a = ThisListView.Items.Add(sec.NumeroSeccion.ToString());
                    a.SubItems.Add(sec.Materia);
                }
            }
            else
                ThisListView.Items.Add("No hay secciones registradas");
        }

        public void MostrarSeccionActual()
        {
            ThisListView.Items.Clear();
            ThisListView.Columns[0].Text = "Nombre";
            ThisListView.Columns[1].Text = "Calificación";
            labelNumSec.Text = ActualSeccion.NumeroSeccion.ToString();
            estado = State.ViendoListaEstCal;

            List<EstudianteSeccion> estudiantes = ActualSeccion.Estudiantes;

            if (estudiantes.Count > 0)
            {
                foreach (EstudianteSeccion est in estudiantes)
                {
                    ListViewItem a = ThisListView.Items.Add(est.Nombre);
                    a.SubItems.Add(est.Cal.ToString());
                }
            }
            else
                ThisListView.Items.Add("No hay estudiantes registrados en esta sección");
        }

        private void ThisListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
                if (estado == State.ViendoSecciones)
                {
                    List<EstudianteSeccion> est = SeccionManager.ObtenerListaEstudiantes(comboBoxAsig.Text, ActualProfesor, Int32.Parse(ThisListView.SelectedItems[0].SubItems[0].Text));
                    ActualSeccion = new Seccion(ActualProfesor, est,
                                    Int32.Parse(ThisListView.SelectedItems[0].SubItems[0].Text), ThisListView.SelectedItems[0].SubItems[1].Text);
                    MostrarSeccionActual();
                    estado = State.ViendoListaEstCal;
                }
            //}
            //catch
            //{
                //MessageBox.Show("Ha ocurrido un error, intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            if (estado == State.ViendoListaEstCal && ThisListView.SelectedItems.Count > 0 && ThisListView.Items.Count > 0)
            {
                AddCalForm F = new AddCalForm(ActualSeccion, ThisListView.SelectedItems[0].SubItems[0].Text, 
                                    ConseguirIDEstudiante(ThisListView.SelectedItems[0].SubItems[0].Text), this);
                F.ShowDialog();
            }
        }

        private void BtnCreateAsig_Click(object sender, EventArgs e)
        {
            AddAsignaturaForm f = new AddAsignaturaForm(comboBoxAsig);
            f.ShowDialog();
        }

        private void BuscarAsignaturas()
        {
            string filePath = Environment.CurrentDirectory + "\\" + ActualProfesor.Id;
            string[] directorios = Directory.GetDirectories(filePath);
            string[] nombreDirectorio;
            if (directorios.Length > 0)
            {
                for (int i = 0; i < directorios.Length; i++)
                {
                    nombreDirectorio = directorios[i].Split('\\');
                    comboBoxAsig.Items.Add(nombreDirectorio[nombreDirectorio.Length - 1]);
                }
            }
        }

		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
