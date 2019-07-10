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
    public partial class AdministradorInterface: Form
    {

        public AdministradorInterface()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            TipoCombo.Items.Add("Estudiantes");
            TipoCombo.Items.Add("Profesores");
        }


        //Agrega toda la data disponible en la lista de registros al ListView
        public void AddData()
        {
            if (TipoCombo.SelectedIndex == 0)
            {
                ThisListView.Clear();

                ThisListView.Columns.Add("ID").Width = 150;
                ThisListView.Columns.Add("Nombre").Width = 200;
                ThisListView.Columns.Add("Carrera").Width = 300;

                foreach (Estudiante est in Estudiante.ObtenerListaEstudiantes())
                {
                    ListViewItem a = ThisListView.Items.Add(est.ID);

                    a.SubItems.Add(est.Nombre);
                    a.SubItems.Add(est.Carrera);
                }
            }
            else
            {
                ThisListView.Clear();

                ThisListView.Columns.Add("Nombre").Width = 350;
                ThisListView.Columns.Add("ID").Width = 200;

                foreach (Profesor prof in Profesor.ObtenerListaProfesores())
                {
                    ListViewItem a = ThisListView.Items.Add(prof.Nombre);

                    a.SubItems.Add(prof.Id);
                }
            }
        }
        //Muestra el formulario para agregar una nueva asignatura
        public void ShowAddSubjectForm()
        {
            AddSubjectForm F4 = new AddSubjectForm();

            F4.ShowDialog();
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
                    Estudiante.EliminarEstudiante(ThisListView.SelectedItems[0].Text);
                }
                else if (result == DialogResult.No)
                {
                    
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar algo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
