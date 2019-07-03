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
        private decimal Grade;
        private decimal totalMult;
        private int totalCred;
        private int idEstudiante;
        public ReportForm()
        {
            InitializeComponent();
            this.CenterToScreen();
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
                    ThisListBox.Items.Add($"{reg.subject}               {reg.credValue}               {IndiceManager.TransformarEnValor(reg.grade)}");
                    Cred = int.Parse(reg.credValue);
                    Grade = IndiceManager.TransformarEnValor(reg.grade);
                    totalCred += Cred;

                    totalMult += (Cred * Grade);
                }

                decimal indice = totalMult / totalCred;

                ThisListBox.Items.Add($"Su indice trimestral es: {indice}");
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TakeAllData(idEstudiante);
        }

        private void BtnAlright_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
