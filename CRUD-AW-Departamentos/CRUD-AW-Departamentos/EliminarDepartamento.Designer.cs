namespace CRUD_AW_Departamentos
{
    partial class EliminarDepartamento
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
            this.gbEliminarDepartamento = new System.Windows.Forms.GroupBox();
            this.lblEstadoEliminacion = new System.Windows.Forms.Label();
            this.btnEliminarDepartamento = new System.Windows.Forms.Button();
            this.btnCargarDepartamentos = new System.Windows.Forms.Button();
            this.lstDepartamentos = new System.Windows.Forms.ListBox();
            this.gbEliminarDepartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEliminarDepartamento
            // 
            this.gbEliminarDepartamento.Controls.Add(this.lblEstadoEliminacion);
            this.gbEliminarDepartamento.Controls.Add(this.btnEliminarDepartamento);
            this.gbEliminarDepartamento.Controls.Add(this.btnCargarDepartamentos);
            this.gbEliminarDepartamento.Controls.Add(this.lstDepartamentos);
            this.gbEliminarDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEliminarDepartamento.Location = new System.Drawing.Point(24, 23);
            this.gbEliminarDepartamento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbEliminarDepartamento.Name = "gbEliminarDepartamento";
            this.gbEliminarDepartamento.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbEliminarDepartamento.Size = new System.Drawing.Size(936, 562);
            this.gbEliminarDepartamento.TabIndex = 0;
            this.gbEliminarDepartamento.TabStop = false;
            this.gbEliminarDepartamento.Text = "Eliminar Departamento";
            // 
            // lblEstadoEliminacion
            // 
            this.lblEstadoEliminacion.Location = new System.Drawing.Point(12, 469);
            this.lblEstadoEliminacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEstadoEliminacion.Name = "lblEstadoEliminacion";
            this.lblEstadoEliminacion.Size = new System.Drawing.Size(912, 87);
            this.lblEstadoEliminacion.TabIndex = 3;
            this.lblEstadoEliminacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarDepartamento
            // 
            this.btnEliminarDepartamento.Location = new System.Drawing.Point(506, 292);
            this.btnEliminarDepartamento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEliminarDepartamento.Name = "btnEliminarDepartamento";
            this.btnEliminarDepartamento.Size = new System.Drawing.Size(418, 92);
            this.btnEliminarDepartamento.TabIndex = 2;
            this.btnEliminarDepartamento.Text = "Eliminar Departamento";
            this.btnEliminarDepartamento.UseVisualStyleBackColor = true;
            this.btnEliminarDepartamento.Click += new System.EventHandler(this.btnEliminarDepartamento_Click);
            // 
            // btnCargarDepartamentos
            // 
            this.btnCargarDepartamentos.Location = new System.Drawing.Point(506, 144);
            this.btnCargarDepartamentos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCargarDepartamentos.Name = "btnCargarDepartamentos";
            this.btnCargarDepartamentos.Size = new System.Drawing.Size(418, 92);
            this.btnCargarDepartamentos.TabIndex = 1;
            this.btnCargarDepartamentos.Text = "Cargar listado de departamentos";
            this.btnCargarDepartamentos.UseVisualStyleBackColor = true;
            this.btnCargarDepartamentos.Click += new System.EventHandler(this.btnCargarDepartamentos_Click);
            // 
            // lstDepartamentos
            // 
            this.lstDepartamentos.FormattingEnabled = true;
            this.lstDepartamentos.ItemHeight = 37;
            this.lstDepartamentos.Location = new System.Drawing.Point(32, 71);
            this.lstDepartamentos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstDepartamentos.Name = "lstDepartamentos";
            this.lstDepartamentos.Size = new System.Drawing.Size(458, 374);
            this.lstDepartamentos.TabIndex = 0;
            // 
            // EliminarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 608);
            this.Controls.Add(this.gbEliminarDepartamento);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EliminarDepartamento";
            this.Text = "Eliminar Departamento";
            this.Load += new System.EventHandler(this.EliminarDepartamento_Load);
            this.gbEliminarDepartamento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEliminarDepartamento;
        private System.Windows.Forms.Button btnEliminarDepartamento;
        private System.Windows.Forms.Button btnCargarDepartamentos;
        private System.Windows.Forms.ListBox lstDepartamentos;
        private System.Windows.Forms.Label lblEstadoEliminacion;
    }
}