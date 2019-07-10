﻿using Clases;
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
        private Seccion ActualSeccion;
        private enum State
        {
            ViendoSecciones,
            ViendoListaEst
        }
        State estado = State.ViendoSecciones;
        public ProfesorInterface()
        {
            InitializeComponent();
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

            ComboItem[] combo =
{
                new ComboItem {ID = 1, Text = "Calculo Diferencial" },
                new ComboItem {ID = 2, Text = "Calculo Integral" }
            };
            comboBoxAsig.DataSource = combo;
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

        //BOTON para guardar los registros del listview en un archivo de trimestres e informarle al usuario
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //int trimestreActual = Int32.Parse(labelNumTrismestre.Text);
            //int PeriodValue = RegistroManager.GuardarTrimestreEspecifico(ActualProfesor.Id, trimestreActual);

            //MessageBox.Show($"El trimestre {PeriodValue} ha sido guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ThisListView.Items.Clear();
            //labelNumTrismestre.Text = (RegistroManager.DeterminarCantidadArchivos(ActualProfesor.Id.ToString()) + 1).ToString();
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

        private void BtnNewSec_Click(object sender, EventArgs e)
        {
            ActualSeccion = new Seccion(ActualProfesor, comboBoxAsig.Text);
            labelNumSec.Text = ActualSeccion.NumeroSeccion.ToString();
            MostrarSeccionActual();
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            if (ThisListView.Items.Count > 0 && ThisListView.SelectedItems.Count > 0)
            {
                ActualSeccion.AñadirEstudiante(ThisListView.SelectedItems[0].SubItems[1].Text);
                MostrarSeccionActual();
            }
            else
                MessageBox.Show("Debe seleccionar un estudiante para añadir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ComboBoxAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath = Environment.CurrentDirectory + "\\" + ActualProfesor.Id + "\\" + comboBoxAsig.Text;
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            MostrarSeccionesExistentes();
        }

        private void MostrarSeccionesExistentes()
        {
            ThisListView.Items.Clear();
            ThisListView.Columns[0].Text = "Sección";
            ThisListView.Columns[1].Text = "Materia";
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

        private void MostrarSeccionActual()
        {
            ThisListView.Items.Clear();
            ThisListView.Columns[0].Text = "Nombre";
            ThisListView.Columns[1].Text = "";

            List<string> estudiantes = ActualSeccion.NombreEstudiantes;

            if (estudiantes.Count > 0)
            {
                foreach (string est in ActualSeccion.NombreEstudiantes)
                {
                    ThisListView.Items.Add(est);
                }
            }
            else
                ThisListView.Items.Add("No hay estudiantes registrados en esta sección");
        }

        private void ThisListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (estado == State.ViendoSecciones)
            {
                List<string> est = SeccionManager.ObtenerListaEstudiantes(comboBoxAsig.Text, ActualProfesor, Int32.Parse(ThisListView.SelectedItems[0].SubItems[0].Text));
                ActualSeccion = new Seccion(ActualProfesor, est, 
                                Int32.Parse(ThisListView.SelectedItems[0].SubItems[0].Text), ThisListView.SelectedItems[0].SubItems[1].Text);
                MostrarSeccionActual();
                estado = State.ViendoListaEst;
            }
        }
    }
}
