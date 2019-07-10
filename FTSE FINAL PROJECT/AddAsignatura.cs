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
    public partial class AddAsignaturaForm : Form
    {
        public static string cantCred = "4";

        ComboBox comboBox;
        public AddAsignaturaForm(ComboBox combo)
        {
            InitializeComponent();
            this.CenterToScreen();
            comboBox = combo;
        }    
        private void btnSave_Click(object sender, EventArgs e)
        {
            comboBox.Items.Add(txtSubject.Text);
            txtSubject.Clear();
            cantCred = txtCred.Text;
            this.Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtSubject.Clear();
            this.Close();
        }
      

        private void TxtSubject_TextChanged(object sender, EventArgs e)
        {
            if (txtSubject.Text == string.Empty)
                errorProvider1.SetError(txtSubject, "Debe escribir la asignatura");
            else
                errorProvider1.Clear();
            UpdateButton();
        }
        //Actualiza el boton cada que vez se cambia algo en una de las formas
        private void UpdateButton()
        {
            btnSave.Enabled = txtSubject.Text != string.Empty;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
