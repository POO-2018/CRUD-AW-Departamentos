namespace CRUD_AW_Departamentos
{
    partial class ListarDepartamentos
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
            this.gbDepartamentos = new System.Windows.Forms.GroupBox();
            this.txtDepartamentos = new System.Windows.Forms.TextBox();
            this.gbDepartamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDepartamentos
            // 
            this.gbDepartamentos.Controls.Add(this.txtDepartamentos);
            this.gbDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDepartamentos.Location = new System.Drawing.Point(24, 0);
            this.gbDepartamentos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDepartamentos.Name = "gbDepartamentos";
            this.gbDepartamentos.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDepartamentos.Size = new System.Drawing.Size(1556, 665);
            this.gbDepartamentos.TabIndex = 0;
            this.gbDepartamentos.TabStop = false;
            this.gbDepartamentos.Text = "Departamentos existentes";
            // 
            // txtDepartamentos
            // 
            this.txtDepartamentos.Location = new System.Drawing.Point(12, 48);
            this.txtDepartamentos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDepartamentos.Multiline = true;
            this.txtDepartamentos.Name = "txtDepartamentos";
            this.txtDepartamentos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDepartamentos.Size = new System.Drawing.Size(1528, 577);
            this.txtDepartamentos.TabIndex = 0;
            // 
            // ListarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 688);
            this.Controls.Add(this.gbDepartamentos);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ListarDepartamentos";
            this.Text = "Listar Departamentos";
            this.Load += new System.EventHandler(this.ListarDepartamentos_Load);
            this.gbDepartamentos.ResumeLayout(false);
            this.gbDepartamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDepartamentos;
        private System.Windows.Forms.TextBox txtDepartamentos;
    }
}