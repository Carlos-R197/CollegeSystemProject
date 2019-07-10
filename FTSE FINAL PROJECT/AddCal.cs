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
    public partial class AddCalForm : Form
    {
        public Seccion ActualSeccion { get; set; }
        public string NombreEstudiante { get; set; }
        public string IDEstudiante { get; set; }
        public ProfesorInterface Forma { get; set; }
        public AddCalForm(Seccion sec, string nombreEstudiante, string idEstudiante, ProfesorInterface forma)
        {
            InitializeComponent();
            this.CenterToScreen();
            ActualSeccion = sec;
            NombreEstudiante = nombreEstudiante;
            IDEstudiante = idEstudiante;
            this.Forma = forma;
        }    
        private void btnSave_Click(object sender, EventArgs e)
        {
            ActualSeccion.AñadirCalificacion(new EstudianteSeccion(NombreEstudiante, Int32.Parse(txtGrade.Text)));
            ProfesorInterface.ActualSeccion = ActualSeccion;
            Forma.MostrarSeccionActual();
            RegistroManager.AñadirRegistro(IDEstudiante, Int32.Parse(txtGrade.Text), ActualSeccion.Materia, int.Parse(AddAsignaturaForm.cantCred));
            txtGrade.Clear();
            this.Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtGrade.Clear();
            this.Close();
        }
       
        //Actualiza el boton cada que vez se cambia algo en una de las formas
        private void UpdateButton()
        {
            int grade;
            btnSave.Enabled = Int32.TryParse(txtGrade.Text, out grade) && grade < 101 & grade > 0;
        }

        private void TxtGrade_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (!Int32.TryParse(txtGrade.Text, out num))
            {
                txtGrade.Clear();
                errorProvider1.SetError(txtGrade, "Solo se permiten numeros");
            }
            else
            {
                if (num > -1 && num < 101)
                    errorProvider1.Clear();
                else
                {
                    errorProvider1.SetError(txtGrade, "El valor debe ser un numero de 0 a 100");
                    txtGrade.Clear();
                }
                
            }
        }
    }
}
