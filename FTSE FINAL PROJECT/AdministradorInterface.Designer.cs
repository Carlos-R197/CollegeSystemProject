
namespace FTSE_FINAL_PROJECT
{
    partial class AdministradorInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorInterface));
            this.labelName = new System.Windows.Forms.Label();
            this.labelCareer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ThisListView = new System.Windows.Forms.ListView();
            this.Asignatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantCreditos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Calificacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.TipoCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(31, 150);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(295, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Administrador del Sistema";
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
            // ThisListView
            // 
            this.ThisListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Asignatura,
            this.CantCreditos,
            this.Calificacion});
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
            this.Calificacion.Text = "Profesor";
            this.Calificacion.Width = 99;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(867, 546);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TipoCombo
            // 
            this.TipoCombo.FormattingEnabled = true;
            this.TipoCombo.Location = new System.Drawing.Point(119, 283);
            this.TipoCombo.Margin = new System.Windows.Forms.Padding(4);
            this.TipoCombo.Name = "TipoCombo";
            this.TipoCombo.Size = new System.Drawing.Size(160, 24);
            this.TipoCombo.TabIndex = 8;
            this.TipoCombo.SelectedIndexChanged += new System.EventHandler(this.TipoCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 183);
            this.label1.TabIndex = 0;
            this.label1.Text = "Como administrador, puede controlar los profesores y estudiantes registrados en e" +
    "l sistema, teniendo a acceso a la lista de ambos, como tambien a eliminarlos si " +
    "es preciso.";
            // 
            // AdministradorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 609);
            this.Controls.Add(this.TipoCombo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ThisListView);
            this.Controls.Add(this.labelCareer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AdministradorInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CALCULO DE INDICE ACADEMICO";
            this.Load += new System.EventHandler(this.AdministradorInterface_Load);
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
        private System.Windows.Forms.ColumnHeader Calificacion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView ThisListView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox TipoCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}