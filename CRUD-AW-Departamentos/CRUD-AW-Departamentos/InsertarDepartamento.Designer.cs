namespace CRUD_AW_Departamentos
{
    partial class InsertarDepartamento
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
            this.gbInsertarDepartamento = new System.Windows.Forms.GroupBox();
            this.lblEstadoInsercion = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.gbInsertarDepartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInsertarDepartamento
            // 
            this.gbInsertarDepartamento.Controls.Add(this.lblEstadoInsercion);
            this.gbInsertarDepartamento.Controls.Add(this.btnInsertar);
            this.gbInsertarDepartamento.Controls.Add(this.lblNombre);
            this.gbInsertarDepartamento.Controls.Add(this.lblNombreGrupo);
            this.gbInsertarDepartamento.Controls.Add(this.lblFechaCreacion);
            this.gbInsertarDepartamento.Controls.Add(this.txtNombre);
            this.gbInsertarDepartamento.Controls.Add(this.txtNombreGrupo);
            this.gbInsertarDepartamento.Controls.Add(this.dtpFechaCreacion);
            this.gbInsertarDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInsertarDepartamento.Location = new System.Drawing.Point(24, 23);
            this.gbInsertarDepartamento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbInsertarDepartamento.Name = "gbInsertarDepartamento";
            this.gbInsertarDepartamento.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbInsertarDepartamento.Size = new System.Drawing.Size(1034, 496);
            this.gbInsertarDepartamento.TabIndex = 0;
            this.gbInsertarDepartamento.TabStop = false;
            this.gbInsertarDepartamento.Text = "Insertar Departamento";
            // 
            // lblEstadoInsercion
            // 
            this.lblEstadoInsercion.Location = new System.Drawing.Point(12, 431);
            this.lblEstadoInsercion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEstadoInsercion.Name = "lblEstadoInsercion";
            this.lblEstadoInsercion.Size = new System.Drawing.Size(1010, 60);
            this.lblEstadoInsercion.TabIndex = 8;
            this.lblEstadoInsercion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(312, 340);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(370, 63);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Insertar departamento";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(144, 92);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(132, 37);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(144, 177);
            this.lblNombreGrupo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(275, 37);
            this.lblNombreGrupo.TabIndex = 2;
            this.lblNombreGrupo.Text = "Nombre del grupo";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(144, 256);
            this.lblFechaCreacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(280, 37);
            this.lblFechaCreacion.TabIndex = 3;
            this.lblFechaCreacion.Text = "Fecha de creación";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(472, 87);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(396, 44);
            this.txtNombre.TabIndex = 4;
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(472, 171);
            this.txtNombreGrupo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(396, 44);
            this.txtNombreGrupo.TabIndex = 5;
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.CustomFormat = "MM/dd/yyyy";
            this.dtpFechaCreacion.Enabled = false;
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(472, 246);
            this.dtpFechaCreacion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(396, 44);
            this.dtpFechaCreacion.TabIndex = 6;
            // 
            // InsertarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 542);
            this.Controls.Add(this.gbInsertarDepartamento);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "InsertarDepartamento";
            this.Text = "Insertar departamento";
            this.gbInsertarDepartamento.ResumeLayout(false);
            this.gbInsertarDepartamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInsertarDepartamento;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Label lblEstadoInsercion;
    }
}