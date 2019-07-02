namespace FTSE_FINAL_PROJECT
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.labelName = new System.Windows.Forms.Label();
            this.labelCareer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewPeriod = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNumTrismestre = new System.Windows.Forms.Label();
            this.btnWatchReport = new System.Windows.Forms.Button();
            this.ThisListView = new System.Windows.Forms.ListView();
            this.Asignatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantCreditos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Calificacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModifyTri = new System.Windows.Forms.Button();
            this.txtTrimester = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 102);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(285, 24);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "John Marcos Espinal Hernandez";
            // 
            // labelCareer
            // 
            this.labelCareer.AutoSize = true;
            this.labelCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCareer.Location = new System.Drawing.Point(103, 146);
            this.labelCareer.Name = "labelCareer";
            this.labelCareer.Size = new System.Drawing.Size(197, 24);
            this.labelCareer.TabIndex = 0;
            this.labelCareer.Text = "Ingenieria de Software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Carrera:";
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
            // btnNewPeriod
            // 
            this.btnNewPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPeriod.Location = new System.Drawing.Point(67, 260);
            this.btnNewPeriod.Name = "btnNewPeriod";
            this.btnNewPeriod.Size = new System.Drawing.Size(126, 44);
            this.btnNewPeriod.TabIndex = 1;
            this.btnNewPeriod.Text = "Nuevo Registro de trimestre";
            this.btnNewPeriod.UseVisualStyleBackColor = true;
            this.btnNewPeriod.Click += new System.EventHandler(this.BtnNewPeriod_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trimestre:";
            // 
            // labelNumTrismestre
            // 
            this.labelNumTrismestre.AutoSize = true;
            this.labelNumTrismestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumTrismestre.Location = new System.Drawing.Point(122, 213);
            this.labelNumTrismestre.Name = "labelNumTrismestre";
            this.labelNumTrismestre.Size = new System.Drawing.Size(20, 24);
            this.labelNumTrismestre.TabIndex = 0;
            this.labelNumTrismestre.Text = "1";
            // 
            // btnWatchReport
            // 
            this.btnWatchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchReport.Location = new System.Drawing.Point(67, 327);
            this.btnWatchReport.Name = "btnWatchReport";
            this.btnWatchReport.Size = new System.Drawing.Size(126, 44);
            this.btnWatchReport.TabIndex = 1;
            this.btnWatchReport.Text = "Ver Reporte Academico";
            this.btnWatchReport.UseVisualStyleBackColor = true;
            this.btnWatchReport.Click += new System.EventHandler(this.BtnWatchReport_Click);
            // 
            // ThisListView
            // 
            this.ThisListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Asignatura,
            this.CantCreditos,
            this.Calificacion});
            this.ThisListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThisListView.FullRowSelect = true;
            this.ThisListView.HideSelection = false;
            this.ThisListView.Location = new System.Drawing.Point(303, 102);
            this.ThisListView.Name = "ThisListView";
            this.ThisListView.Size = new System.Drawing.Size(529, 336);
            this.ThisListView.TabIndex = 2;
            this.ThisListView.UseCompatibleStateImageBehavior = false;
            this.ThisListView.View = System.Windows.Forms.View.Details;
            // 
            // Asignatura
            // 
            this.Asignatura.Text = "Asignatura";
            this.Asignatura.Width = 306;
            // 
            // CantCreditos
            // 
            this.CantCreditos.Text = "Cant. Creditos";
            this.CantCreditos.Width = 114;
            // 
            // Calificacion
            // 
            this.Calificacion.Text = "Calificacion";
            this.Calificacion.Width = 99;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.Location = new System.Drawing.Point(282, 444);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(128, 29);
            this.btnAddSubject.TabIndex = 3;
            this.btnAddSubject.Text = "Agregar materia";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.BtnAddSubject_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(535, 444);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(84, 29);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(644, 444);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(744, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(430, 444);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 29);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnModifyTri
            // 
            this.btnModifyTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyTri.Location = new System.Drawing.Point(12, 444);
            this.btnModifyTri.Name = "btnModifyTri";
            this.btnModifyTri.Size = new System.Drawing.Size(144, 29);
            this.btnModifyTri.TabIndex = 4;
            this.btnModifyTri.Text = "Ir al trimestre";
            this.btnModifyTri.UseVisualStyleBackColor = true;
            this.btnModifyTri.Click += new System.EventHandler(this.BtnModifyTri_Click);
            // 
            // txtTrimester
            // 
            this.txtTrimester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrimester.Location = new System.Drawing.Point(162, 445);
            this.txtTrimester.Name = "txtTrimester";
            this.txtTrimester.Size = new System.Drawing.Size(65, 26);
            this.txtTrimester.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "De los trimestres que ha guardado, puede modificar el que desee agregando su nume" +
    "ro y presionando el boton:";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrimester);
            this.Controls.Add(this.btnModifyTri);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.ThisListView);
            this.Controls.Add(this.btnWatchReport);
            this.Controls.Add(this.btnNewPeriod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNumTrismestre);
            this.Controls.Add(this.labelCareer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CALCULO DE INDICE ACADEMICO";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCareer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNumTrismestre;
        private System.Windows.Forms.Button btnWatchReport;
        private System.Windows.Forms.ColumnHeader Asignatura;
        private System.Windows.Forms.ColumnHeader CantCreditos;
        private System.Windows.Forms.ColumnHeader Calificacion;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnModifyTri;
        private System.Windows.Forms.TextBox txtTrimester;
        private System.Windows.Forms.ListView ThisListView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}