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
        int idEstudiante;
        private int totalCred;
        private decimal totalGrade;

        public ReportForm()
        {
            InitializeComponent();
        }

        public void GetId(int id)
        {
            idEstudiante = id;
        }

        private void TakeAllData(int id)
        {
            List<Trimestre> trimestres = RegistroManager.ObtenerTodosRegistros(id);

            foreach (Trimestre tri in trimestres)
            {
                foreach (Registro reg in tri.Registros)
                {
                    ThisListBox.Items.Add($"{reg.subject}               {reg.credValue}               {reg.grade}");
                    totalCred += int.Parse(reg.credValue);
                    totalGrade += IndiceManager.TransformarEnValor(reg.grade);
                }

                decimal indice = (totalGrade * totalCred) / totalCred;

                ThisListBox.Items.Add($"Su indice trimestral es: {indice}");
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TakeAllData(idEstudiante);
        }
    }
}
