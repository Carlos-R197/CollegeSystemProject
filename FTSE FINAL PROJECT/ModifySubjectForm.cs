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
    public partial class ModifySubjectForm : Form
    {
        public ModifySubjectForm()
        {
            InitializeComponent();

            UserInterface f = new UserInterface();
            txtSubject.Text = f.ThisListView.SelectedItems.
            txtCred.Text = f.ThisListView.SelectedItems[0].SubItems[1].Text;
            txtGrade.Text = f.ThisListView.SelectedItems[0].SubItems[2].Text;
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
