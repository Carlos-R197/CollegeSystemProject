
namespace FTSE_FINAL_PROJECT
{
    partial class ProfesorInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfesorInterface));
			this.labelName = new System.Windows.Forms.Label();
			this.labelCareer = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ThisListView = new System.Windows.Forms.ListView();
			this.Asignatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CantCreditos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAddStudent = new System.Windows.Forms.Button();
			this.btnView = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnNewSec = new System.Windows.Forms.Button();
			this.btnModifyTri = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnDelete = new System.Windows.Forms.Button();
			this.comboBoxAsig = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelNumSec = new System.Windows.Forms.Label();
			this.btnCal = new System.Windows.Forms.Button();
			this.btnCreateAsig = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(12, 102);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(80, 24);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Profesor";
			// 
			// labelCareer
			// 
			this.labelCareer.AutoSize = true;
			this.labelCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCareer.Location = new System.Drawing.Point(103, 146);
			this.labelCareer.Name = "labelCareer";
			this.labelCareer.Size = new System.Drawing.Size(0, 24);
			this.labelCareer.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(42, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(630, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "BIENVENIDO AL SISTEMA DE CALCULO DE INDICE ACADEMICO";
			// 
			// ThisListView
			// 
			this.ThisListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Asignatura,
            this.CantCreditos});
			this.ThisListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ThisListView.FullRowSelect = true;
			this.ThisListView.HideSelection = false;
			this.ThisListView.Location = new System.Drawing.Point(303, 102);
			this.ThisListView.Name = "ThisListView";
			this.ThisListView.Size = new System.Drawing.Size(529, 336);
			this.ThisListView.TabIndex = 2;
			this.ThisListView.UseCompatibleStateImageBehavior = false;
			this.ThisListView.View = System.Windows.Forms.View.Details;
			this.ThisListView.SelectedIndexChanged += new System.EventHandler(this.ThisListView_SelectedIndexChanged);
			// 
			// Asignatura
			// 
			this.Asignatura.Text = "ID";
			this.Asignatura.Width = 200;
			// 
			// CantCreditos
			// 
			this.CantCreditos.Text = "Nombre";
			this.CantCreditos.Width = 200;
			// 
			// btnAddStudent
			// 
			this.btnAddStudent.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddStudent.Location = new System.Drawing.Point(431, 445);
			this.btnAddStudent.Name = "btnAddStudent";
			this.btnAddStudent.Size = new System.Drawing.Size(139, 29);
			this.btnAddStudent.TabIndex = 3;
			this.btnAddStudent.Text = "Agregar estudiante";
			this.btnAddStudent.UseVisualStyleBackColor = false;
			this.btnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
			// 
			// btnView
			// 
			this.btnView.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnView.Location = new System.Drawing.Point(650, 64);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(181, 32);
			this.btnView.TabIndex = 3;
			this.btnView.Text = "Ver lista estudiantes";
			this.btnView.UseVisualStyleBackColor = false;
			this.btnView.Click += new System.EventHandler(this.BtnModify_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(756, 445);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 29);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Salir";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnNewSec
			// 
			this.btnNewSec.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnNewSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewSec.Location = new System.Drawing.Point(576, 445);
			this.btnNewSec.Name = "btnNewSec";
			this.btnNewSec.Size = new System.Drawing.Size(84, 29);
			this.btnNewSec.TabIndex = 3;
			this.btnNewSec.Text = "Crear Sec";
			this.btnNewSec.UseVisualStyleBackColor = false;
			this.btnNewSec.Click += new System.EventHandler(this.BtnNewSec_Click);
			// 
			// btnModifyTri
			// 
			this.btnModifyTri.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnModifyTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModifyTri.Location = new System.Drawing.Point(58, 291);
			this.btnModifyTri.Name = "btnModifyTri";
			this.btnModifyTri.Size = new System.Drawing.Size(144, 29);
			this.btnModifyTri.TabIndex = 4;
			this.btnModifyTri.Text = "Ir a secciones";
			this.btnModifyTri.UseVisualStyleBackColor = false;
			this.btnModifyTri.Click += new System.EventHandler(this.BtnModifyTri_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(666, 445);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(84, 29);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Eliminar";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// comboBoxAsig
			// 
			this.comboBoxAsig.BackColor = System.Drawing.Color.WhiteSmoke;
			this.comboBoxAsig.DisplayMember = "Text";
			this.comboBoxAsig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxAsig.FormattingEnabled = true;
			this.comboBoxAsig.ItemHeight = 16;
			this.comboBoxAsig.Location = new System.Drawing.Point(95, 184);
			this.comboBoxAsig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBoxAsig.Name = "comboBoxAsig";
			this.comboBoxAsig.Size = new System.Drawing.Size(92, 24);
			this.comboBoxAsig.TabIndex = 9;
			this.comboBoxAsig.ValueMember = "ID";
			this.comboBoxAsig.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAsig_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 183);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 19);
			this.label2.TabIndex = 10;
			this.label2.Text = "Asignatura:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(56, 202);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 13);
			this.label4.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(74, 232);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 19);
			this.label5.TabIndex = 12;
			this.label5.Text = "Seccion: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(143, 232);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 19);
			this.label6.TabIndex = 13;
			// 
			// labelNumSec
			// 
			this.labelNumSec.AutoSize = true;
			this.labelNumSec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNumSec.Location = new System.Drawing.Point(148, 232);
			this.labelNumSec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelNumSec.Name = "labelNumSec";
			this.labelNumSec.Size = new System.Drawing.Size(17, 19);
			this.labelNumSec.TabIndex = 15;
			this.labelNumSec.Text = "1";
			// 
			// btnCal
			// 
			this.btnCal.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCal.Location = new System.Drawing.Point(272, 445);
			this.btnCal.Name = "btnCal";
			this.btnCal.Size = new System.Drawing.Size(153, 29);
			this.btnCal.TabIndex = 16;
			this.btnCal.Text = "Agregar calificación";
			this.btnCal.UseVisualStyleBackColor = false;
			this.btnCal.Click += new System.EventHandler(this.BtnCal_Click);
			// 
			// btnCreateAsig
			// 
			this.btnCreateAsig.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnCreateAsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreateAsig.Location = new System.Drawing.Point(173, 447);
			this.btnCreateAsig.Name = "btnCreateAsig";
			this.btnCreateAsig.Size = new System.Drawing.Size(93, 27);
			this.btnCreateAsig.TabIndex = 17;
			this.btnCreateAsig.Text = "Crear Asig";
			this.btnCreateAsig.UseVisualStyleBackColor = false;
			this.btnCreateAsig.Click += new System.EventHandler(this.BtnCreateAsig_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 481);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
			this.statusStrip1.Size = new System.Drawing.Size(841, 22);
			this.statusStrip1.TabIndex = 14;
			this.statusStrip1.Text = "statusStrip1";
			this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
			// 
			// ProfesorInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.ClientSize = new System.Drawing.Size(841, 503);
			this.Controls.Add(this.btnCreateAsig);
			this.Controls.Add(this.btnCal);
			this.Controls.Add(this.labelNumSec);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxAsig);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnModifyTri);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnNewSec);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.btnAddStudent);
			this.Controls.Add(this.ThisListView);
			this.Controls.Add(this.labelCareer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ProfesorInterface";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CALCULO DE INDICE ACADEMICO";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCareer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Asignatura;
        private System.Windows.Forms.ColumnHeader CantCreditos;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewSec;
        private System.Windows.Forms.Button btnModifyTri;
        private System.Windows.Forms.ListView ThisListView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAsig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNumSec;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnCreateAsig;
		private System.Windows.Forms.StatusStrip statusStrip1;
	}
}