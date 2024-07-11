namespace Vistas
{
    partial class form_InscripcionEventos
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbAtletas = new System.Windows.Forms.ComboBox();
            this.lblParticipantes = new System.Windows.Forms.Label();
            this.cmbCompetencias = new System.Windows.Forms.ComboBox();
            this.lblComptencias = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbxListaEventos = new System.Windows.Forms.GroupBox();
            this.dtgwInscripciones = new System.Windows.Forms.DataGridView();
            this.gbxListaEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(748, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(97, 46);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Atras";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(513, 208);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 46);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbAtletas
            // 
            this.cmbAtletas.FormattingEnabled = true;
            this.cmbAtletas.Location = new System.Drawing.Point(333, 128);
            this.cmbAtletas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAtletas.Name = "cmbAtletas";
            this.cmbAtletas.Size = new System.Drawing.Size(265, 24);
            this.cmbAtletas.TabIndex = 15;
            this.cmbAtletas.SelectedIndexChanged += new System.EventHandler(this.cmbAtletas_SelectedIndexChanged);
            // 
            // lblParticipantes
            // 
            this.lblParticipantes.AutoSize = true;
            this.lblParticipantes.Location = new System.Drawing.Point(151, 132);
            this.lblParticipantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new System.Drawing.Size(150, 16);
            this.lblParticipantes.TabIndex = 14;
            this.lblParticipantes.Text = "Seleccione Participante";
            // 
            // cmbCompetencias
            // 
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(333, 81);
            this.cmbCompetencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(265, 24);
            this.cmbCompetencias.TabIndex = 13;
            this.cmbCompetencias.SelectedIndexChanged += new System.EventHandler(this.cmbCompetencias_SelectedIndexChanged);
            // 
            // lblComptencias
            // 
            this.lblComptencias.AutoSize = true;
            this.lblComptencias.Location = new System.Drawing.Point(151, 85);
            this.lblComptencias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComptencias.Name = "lblComptencias";
            this.lblComptencias.Size = new System.Drawing.Size(159, 16);
            this.lblComptencias.TabIndex = 12;
            this.lblComptencias.Text = "Seleccione Competencia";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(151, 182);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 16);
            this.lblInfo.TabIndex = 25;
            // 
            // gbxListaEventos
            // 
            this.gbxListaEventos.Controls.Add(this.dtgwInscripciones);
            this.gbxListaEventos.Location = new System.Drawing.Point(24, 293);
            this.gbxListaEventos.Name = "gbxListaEventos";
            this.gbxListaEventos.Size = new System.Drawing.Size(796, 257);
            this.gbxListaEventos.TabIndex = 26;
            this.gbxListaEventos.TabStop = false;
            this.gbxListaEventos.Text = "Eventos";
            // 
            // dtgwInscripciones
            // 
            this.dtgwInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwInscripciones.Location = new System.Drawing.Point(27, 32);
            this.dtgwInscripciones.Margin = new System.Windows.Forms.Padding(4);
            this.dtgwInscripciones.Name = "dtgwInscripciones";
            this.dtgwInscripciones.Size = new System.Drawing.Size(740, 199);
            this.dtgwInscripciones.TabIndex = 25;
            // 
            // form_InscripcionEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxListaEventos);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbAtletas);
            this.Controls.Add(this.lblParticipantes);
            this.Controls.Add(this.cmbCompetencias);
            this.Controls.Add(this.lblComptencias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_InscripcionEventos";
            this.Size = new System.Drawing.Size(849, 652);
            this.gbxListaEventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwInscripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbAtletas;
        private System.Windows.Forms.Label lblParticipantes;
        private System.Windows.Forms.ComboBox cmbCompetencias;
        private System.Windows.Forms.Label lblComptencias;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox gbxListaEventos;
        private System.Windows.Forms.DataGridView dtgwInscripciones;

    }
}
