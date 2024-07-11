namespace Vistas
{
    partial class form_actualizarFechas
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
            this.gbxDatosParticipante = new System.Windows.Forms.GroupBox();
            this.txtCompetencia = new System.Windows.Forms.TextBox();
            this.lblNombreComp = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbxFechaFin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dttpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.gbxFechaInicio = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dttpHoraIni = new System.Windows.Forms.DateTimePicker();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbxDatosParticipante.SuspendLayout();
            this.gbxFechaFin.SuspendLayout();
            this.gbxFechaInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatosParticipante
            // 
            this.gbxDatosParticipante.Controls.Add(this.txtCompetencia);
            this.gbxDatosParticipante.Controls.Add(this.lblNombreComp);
            this.gbxDatosParticipante.Controls.Add(this.btnActualizar);
            this.gbxDatosParticipante.Controls.Add(this.gbxFechaFin);
            this.gbxDatosParticipante.Controls.Add(this.gbxFechaInicio);
            this.gbxDatosParticipante.Controls.Add(this.txtDNI);
            this.gbxDatosParticipante.Controls.Add(this.cmbEstado);
            this.gbxDatosParticipante.Controls.Add(this.txtApellido);
            this.gbxDatosParticipante.Controls.Add(this.txtNombre);
            this.gbxDatosParticipante.Controls.Add(this.lblEstado);
            this.gbxDatosParticipante.Controls.Add(this.lblTitulo);
            this.gbxDatosParticipante.Controls.Add(this.lblDNI);
            this.gbxDatosParticipante.Controls.Add(this.lblApellido);
            this.gbxDatosParticipante.Controls.Add(this.lblNombre);
            this.gbxDatosParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosParticipante.Location = new System.Drawing.Point(59, 31);
            this.gbxDatosParticipante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxDatosParticipante.Name = "gbxDatosParticipante";
            this.gbxDatosParticipante.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxDatosParticipante.Size = new System.Drawing.Size(640, 515);
            this.gbxDatosParticipante.TabIndex = 0;
            this.gbxDatosParticipante.TabStop = false;
            this.gbxDatosParticipante.Text = "Formulario de Actualizacion de Datos";
            // 
            // txtCompetencia
            // 
            this.txtCompetencia.Enabled = false;
            this.txtCompetencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetencia.Location = new System.Drawing.Point(297, 209);
            this.txtCompetencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompetencia.Name = "txtCompetencia";
            this.txtCompetencia.Size = new System.Drawing.Size(265, 24);
            this.txtCompetencia.TabIndex = 21;
            // 
            // lblNombreComp
            // 
            this.lblNombreComp.AutoSize = true;
            this.lblNombreComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreComp.Location = new System.Drawing.Point(114, 216);
            this.lblNombreComp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreComp.Name = "lblNombreComp";
            this.lblNombreComp.Size = new System.Drawing.Size(96, 18);
            this.lblNombreComp.TabIndex = 20;
            this.lblNombreComp.Text = "Competencia";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(441, 464);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(191, 43);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gbxFechaFin
            // 
            this.gbxFechaFin.Controls.Add(this.label2);
            this.gbxFechaFin.Controls.Add(this.dttpHoraFin);
            this.gbxFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFechaFin.Location = new System.Drawing.Point(106, 381);
            this.gbxFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxFechaFin.Name = "gbxFechaFin";
            this.gbxFechaFin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxFechaFin.Size = new System.Drawing.Size(456, 75);
            this.gbxFechaFin.TabIndex = 18;
            this.gbxFechaFin.TabStop = false;
            this.gbxFechaFin.Text = "Hora Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hora";
            // 
            // dttpHoraFin
            // 
            this.dttpHoraFin.CustomFormat = "HH:mm";
            this.dttpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttpHoraFin.Location = new System.Drawing.Point(75, 31);
            this.dttpHoraFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dttpHoraFin.Name = "dttpHoraFin";
            this.dttpHoraFin.ShowUpDown = true;
            this.dttpHoraFin.Size = new System.Drawing.Size(170, 24);
            this.dttpHoraFin.TabIndex = 17;
            // 
            // gbxFechaInicio
            // 
            this.gbxFechaInicio.Controls.Add(this.label1);
            this.gbxFechaInicio.Controls.Add(this.dttpHoraIni);
            this.gbxFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFechaInicio.Location = new System.Drawing.Point(106, 293);
            this.gbxFechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxFechaInicio.Name = "gbxFechaInicio";
            this.gbxFechaInicio.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxFechaInicio.Size = new System.Drawing.Size(456, 69);
            this.gbxFechaInicio.TabIndex = 17;
            this.gbxFechaInicio.TabStop = false;
            this.gbxFechaInicio.Text = "Hora De Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hora";
            // 
            // dttpHoraIni
            // 
            this.dttpHoraIni.CustomFormat = "HH:mm";
            this.dttpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttpHoraIni.Location = new System.Drawing.Point(75, 33);
            this.dttpHoraIni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dttpHoraIni.Name = "dttpHoraIni";
            this.dttpHoraIni.ShowUpDown = true;
            this.dttpHoraIni.Size = new System.Drawing.Size(170, 24);
            this.dttpHoraIni.TabIndex = 17;
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(297, 172);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(265, 24);
            this.txtDNI.TabIndex = 12;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Abandono",
            "Descalificado"});
            this.cmbEstado.Location = new System.Drawing.Point(297, 246);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(265, 26);
            this.cmbEstado.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(297, 136);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(265, 24);
            this.txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(297, 100);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 24);
            this.txtNombre.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(114, 249);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(131, 18);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado Del Evento";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(217, 45);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(192, 24);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Datos Del Participante";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(114, 179);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 18);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(114, 140);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 18);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(114, 104);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(757, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(73, 45);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Atras";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // form_actualizarFechas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbxDatosParticipante);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_actualizarFechas";
            this.Size = new System.Drawing.Size(830, 652);
            this.gbxDatosParticipante.ResumeLayout(false);
            this.gbxDatosParticipante.PerformLayout();
            this.gbxFechaFin.ResumeLayout(false);
            this.gbxFechaFin.PerformLayout();
            this.gbxFechaInicio.ResumeLayout(false);
            this.gbxFechaInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatosParticipante;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbxFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttpHoraFin;
        private System.Windows.Forms.GroupBox gbxFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dttpHoraIni;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtCompetencia;
        private System.Windows.Forms.Label lblNombreComp;
    }
}
