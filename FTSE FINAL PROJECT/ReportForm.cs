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
    public partial class ReportForm : Form
    {
        private int Cred;
        private float Grade;
        private float totalMult;
        private int totalCred;
        private string idEstudiante;
        public ReportForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public void GetId(string id)
        {
            idEstudiante = id;
        }

        private void TakeAllData(string id)
        {
            try
            {
                List<Trimestre> trimestres = RegistroManager.ObtenerTodosRegistros(id);

                foreach (Trimestre tri in trimestres)
                {
                    foreach (Registro reg in tri.Registros)
                    {
                        ThisListBox.Items.Add($"{reg.subject}               {reg.credValue}               {IndiceManager.TransformarEnValor(reg.grade)}");
                        Cred = int.Parse(reg.credValue);
                        Grade = IndiceManager.TransformarEnValor(reg.grade);
                        totalCred += Cred;

                        totalMult += (Cred * Grade);
                    }

                    float indice = totalMult / totalCred;

                    ThisListBox.Items.Add($"Su indice trimestral es: {Math.Round(indice, 2)}");
                }

                float indiceAcumulado = (float)Math.Round(IndiceManager.ObtenerIndiceAcumulado(id), 2);
                ThisListBox.Items.Add("");
                ThisListBox.Items.Add($"Su indice general es: {indiceAcumulado} {IndiceManager.Honor(indiceAcumulado)}");
            }
            catch(Exception)
            {
                MessageBox.Show("Debe tener trimestres registrados para poder obtener su reporte académico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            TakeAllData(idEstudiante);
        }

        private void BtnAlright_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
