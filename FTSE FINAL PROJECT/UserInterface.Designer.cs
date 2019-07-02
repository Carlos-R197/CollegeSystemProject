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
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(16, 126);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(359, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "John Marcos Espinal Hernandez";
            // 
            // labelCareer
            // 
            this.labelCareer.AutoSize = true;
            this.labelCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCareer.Location = new System.Drawing.Point(137, 180);
            this.labelCareer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCareer.Name = "labelCareer";
            this.labelCareer.Size = new System.Drawing.Size(255, 29);
            this.labelCareer.TabIndex = 0;
            this.labelCareer.Text = "Ingenieria de Software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Carrera:";
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
            // btnNewPeriod
            // 
            this.btnNewPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPeriod.Location = new System.Drawing.Point(89, 320);
            this.btnNewPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewPeriod.Name = "btnNewPeriod";
            this.btnNewPeriod.Size = new System.Drawing.Size(168, 54);
            this.btnNewPeriod.TabIndex = 1;
            this.btnNewPeriod.Text = "Nuevo Registro de trimestre";
            this.btnNewPeriod.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trimestre:";
            // 
            // labelNumTrismestre
            // 
            this.labelNumTrismestre.AutoSize = true;
            this.labelNumTrismestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumTrismestre.Location = new System.Drawing.Point(163, 262);
            this.labelNumTrismestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumTrismestre.Name = "labelNumTrismestre";
            this.labelNumTrismestre.Size = new System.Drawing.Size(26, 29);
            this.labelNumTrismestre.TabIndex = 0;
            this.labelNumTrismestre.Text = "1";
            // 
            // btnWatchReport
            // 
            this.btnWatchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchReport.Location = new System.Drawing.Point(89, 402);
            this.btnWatchReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnWatchReport.Name = "btnWatchReport";
            this.btnWatchReport.Size = new System.Drawing.Size(168, 54);
            this.btnWatchReport.TabIndex = 1;
            this.btnWatchReport.Text = "Ver Reporte Academico";
            this.btnWatchReport.UseVisualStyleBackColor = true;
            // 
            // ThisListView
            // 
            this.ThisListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Asignatura,
            this.CantCreditos,
            this.Calificacion});
            this.ThisListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAddSubject.Location = new System.Drawing.Point(376, 546);
            this.btnAddSubject.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(171, 36);
            this.btnAddSubject.TabIndex = 3;
            this.btnAddSubject.Text = "Agregar materia";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.BtnAddSubject_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(713, 546);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(112, 36);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(859, 546);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(992, 546);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(573, 546);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 36);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnModifyTri
            // 
            this.btnModifyTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyTri.Location = new System.Drawing.Point(8, 503);
            this.btnModifyTri.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyTri.Name = "btnModifyTri";
            this.btnModifyTri.Size = new System.Drawing.Size(192, 36);
            this.btnModifyTri.TabIndex = 4;
            this.btnModifyTri.Text = "Modificar Trimestre";
            this.btnModifyTri.UseVisualStyleBackColor = true;
            this.btnModifyTri.Click += new System.EventHandler(this.BtnModifyTri_Click);
            // 
            // txtTrimester
            // 
            this.txtTrimester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrimester.Location = new System.Drawing.Point(224, 513);
            this.txtTrimester.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrimester.Name = "txtTrimester";
            this.txtTrimester.Size = new System.Drawing.Size(85, 26);
            this.txtTrimester.TabIndex = 5;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 609);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserInterface";
            this.Text = "CALCULO DE INDICE ACADEMICO";
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
        public System.Windows.Forms.ListView ThisListView;
    }
}