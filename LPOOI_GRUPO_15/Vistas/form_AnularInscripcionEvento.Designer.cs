namespace Vistas
{
    partial class form_AnularInscripcionEvento
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dtgvEventos = new System.Windows.Forms.DataGridView();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(353, 132);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(140, 22);
            this.btnConsulta.TabIndex = 7;
            this.btnConsulta.Text = "Buscar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // dtgvEventos
            // 
            this.dtgvEventos.AllowUserToAddRows = false;
            this.dtgvEventos.AllowUserToDeleteRows = false;
            this.dtgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEventos.Location = new System.Drawing.Point(94, 205);
            this.dtgvEventos.Name = "dtgvEventos";
            this.dtgvEventos.ReadOnly = true;
            this.dtgvEventos.Size = new System.Drawing.Size(648, 141);
            this.dtgvEventos.TabIndex = 6;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(141, 134);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(185, 20);
            this.txtDni.TabIndex = 5;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(69, 137);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(64, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "Ingrese DNI";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(677, 16);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 22);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrarAn_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(652, 166);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(140, 22);
            this.btnAnular.TabIndex = 9;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // form_AnularInscripcionEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.dtgvEventos);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Name = "form_AnularInscripcionEvento";
            this.Size = new System.Drawing.Size(834, 613);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.DataGridView dtgvEventos;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAnular;

    }
}
