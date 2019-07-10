
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
            this.btnWatchReport = new System.Windows.Forms.Button();
            this.ThisListView = new System.Windows.Forms.ListView();
            this.Asignatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantCreditos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewSec = new System.Windows.Forms.Button();
            this.btnModifyTri = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBoxAsig = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelNumSec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(16, 126);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(105, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Profesor";
            // 
            // labelCareer
            // 
            this.labelCareer.AutoSize = true;
            this.labelCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCareer.Location = new System.Drawing.Point(137, 180);
            this.labelCareer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCareer.Name = "labelCareer";
            this.labelCareer.Size = new System.Drawing.Size(0, 29);
            this.labelCareer.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(786, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "BIENVENIDO AL SISTEMA DE CALCULO DE INDICE ACADEMICO";
            // 
            // btnWatchReport
            // 
            this.btnWatchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchReport.Location = new System.Drawing.Point(93, 363);
            this.btnWatchReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnWatchReport.Name = "btnWatchReport";
            this.btnWatchReport.Size = new System.Drawing.Size(168, 54);
            this.btnWatchReport.TabIndex = 1;
            this.btnWatchReport.Text = "Ver Reporte Academico";
            this.btnWatchReport.UseVisualStyleBackColor = true;
            this.btnWatchReport.Click += new System.EventHandler(this.BtnWatchReport_Click);
            // 
            // ThisListView
            // 
            this.ThisListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Asignatura,
            this.CantCreditos});
            this.ThisListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThisListView.FullRowSelect = true;
            this.ThisListView.HideSelection = false;
            this.ThisListView.Location = new System.Drawing.Point(404, 126);
            this.ThisListView.Margin = new System.Windows.Forms.Padding(4);
            this.ThisListView.Name = "ThisListView";
            this.ThisListView.Size = new System.Drawing.Size(704, 413);
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
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(464, 548);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(171, 36);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Agregar estudiante";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(917, 82);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(191, 36);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "Ver lista estudiantes";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1008, 548);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Salir";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(883, 548);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnNewSec
            // 
            this.btnNewSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSec.Location = new System.Drawing.Point(643, 548);
            this.btnNewSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewSec.Name = "btnNewSec";
            this.btnNewSec.Size = new System.Drawing.Size(112, 36);
            this.btnNewSec.TabIndex = 3;
            this.btnNewSec.Text = "Crear Sec";
            this.btnNewSec.UseVisualStyleBackColor = true;
            this.btnNewSec.Click += new System.EventHandler(this.BtnNewSec_Click);
            // 
            // btnModifyTri
            // 
            this.btnModifyTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyTri.Location = new System.Drawing.Point(78, 532);
            this.btnModifyTri.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyTri.Name = "btnModifyTri";
            this.btnModifyTri.Size = new System.Drawing.Size(192, 36);
            this.btnModifyTri.TabIndex = 4;
            this.btnModifyTri.Text = "Ir a secciones";
            this.btnModifyTri.UseVisualStyleBackColor = true;
            this.btnModifyTri.Click += new System.EventHandler(this.BtnModifyTri_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 455);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "De los trimestres que ha guardado, puede modificar el que desee agregando su nume" +
    "ro y presionando el boton:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(763, 548);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // comboBoxAsig
            // 
            this.comboBoxAsig.DisplayMember = "Text";
            this.comboBoxAsig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAsig.FormattingEnabled = true;
            this.comboBoxAsig.Location = new System.Drawing.Point(180, 225);
            this.comboBoxAsig.Name = "comboBoxAsig";
            this.comboBoxAsig.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAsig.TabIndex = 9;
            this.comboBoxAsig.ValueMember = "ID";
            this.comboBoxAsig.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAsig_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Asignatura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Seccion: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 23);
            this.label6.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1129, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelNumSec
            // 
            this.labelNumSec.AutoSize = true;
            this.labelNumSec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumSec.Location = new System.Drawing.Point(197, 286);
            this.labelNumSec.Name = "labelNumSec";
            this.labelNumSec.Size = new System.Drawing.Size(20, 23);
            this.labelNumSec.TabIndex = 15;
            this.labelNumSec.Text = "1";
            // 
            // ProfesorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 609);
            this.Controls.Add(this.labelNumSec);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAsig);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifyTri);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewSec);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.ThisListView);
            this.Controls.Add(this.btnWatchReport);
            this.Controls.Add(this.labelCareer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnWatchReport;
        private System.Windows.Forms.ColumnHeader Asignatura;
        private System.Windows.Forms.ColumnHeader CantCreditos;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewSec;
        private System.Windows.Forms.Button btnModifyTri;
        private System.Windows.Forms.ListView ThisListView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAsig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNumSec;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}