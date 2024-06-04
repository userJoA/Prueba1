namespace Vistas
{
    partial class Form_AltaParticipantes
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblEntrenador = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtEntrenador = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dttmFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNuevoParticipante = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.errFormAltaParticipante = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTopParticpantes = new System.Windows.Forms.Panel();
            this.pnlBottomParticpantes = new System.Windows.Forms.Panel();
            this.grbxDatosParticpantes = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.grbxBuscarParticipantes = new System.Windows.Forms.GroupBox();
            this.btnBuscarParticipantes = new System.Windows.Forms.Button();
            this.lblBusquedaParticipante = new System.Windows.Forms.Label();
            this.txtBusquedaPorDNI = new System.Windows.Forms.TextBox();
            this.grbListaParicipantes = new System.Windows.Forms.GroupBox();
            this.dtgwListaParticipantes = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errFormAltaParticipante)).BeginInit();
            this.grbxDatosParticpantes.SuspendLayout();
            this.grbxBuscarParticipantes.SuspendLayout();
            this.grbListaParicipantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwListaParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(35, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(35, 79);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(35, 110);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(27, 15);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(35, 141);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(77, 15);
            this.lblNacionalidad.TabIndex = 3;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblEntrenador
            // 
            this.lblEntrenador.AutoSize = true;
            this.lblEntrenador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrenador.Location = new System.Drawing.Point(35, 174);
            this.lblEntrenador.Name = "lblEntrenador";
            this.lblEntrenador.Size = new System.Drawing.Size(65, 15);
            this.lblEntrenador.TabIndex = 4;
            this.lblEntrenador.Text = "Entrenador";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(35, 203);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 15);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Genero";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(369, 48);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(39, 15);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(369, 78);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(32, 15);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(369, 171);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(119, 15);
            this.lblFechaNac.TabIndex = 8;
            this.lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(370, 141);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(370, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(164, 44);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 23);
            this.txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(164, 75);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(184, 23);
            this.txtApellido.TabIndex = 12;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(163, 106);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(185, 23);
            this.txtDNI.TabIndex = 13;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtEntrenador
            // 
            this.txtEntrenador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrenador.Location = new System.Drawing.Point(163, 170);
            this.txtEntrenador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEntrenador.Name = "txtEntrenador";
            this.txtEntrenador.Size = new System.Drawing.Size(185, 23);
            this.txtEntrenador.TabIndex = 15;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(453, 42);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(174, 23);
            this.txtAltura.TabIndex = 17;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(454, 73);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(174, 23);
            this.txtPeso.TabIndex = 18;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(455, 135);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(174, 23);
            this.txtDireccion.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(454, 104);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 23);
            this.txtEmail.TabIndex = 21;
            // 
            // dttmFechaNac
            // 
            this.dttmFechaNac.CustomFormat = "dd-MM-yyyy";
            this.dttmFechaNac.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttmFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttmFechaNac.Location = new System.Drawing.Point(519, 166);
            this.dttmFechaNac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dttmFechaNac.MaxDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dttmFechaNac.Name = "dttmFechaNac";
            this.dttmFechaNac.Size = new System.Drawing.Size(162, 23);
            this.dttmFechaNac.TabIndex = 22;
            this.dttmFechaNac.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Items.AddRange(new object[] {
            "Seleccione una Nacionalidad",
            "Argentino",
            "Boliviano",
            "Chileno",
            "Colombiano",
            "Ecuatoriano",
            "Paraguayo",
            "Venezolano"});
            this.cmbNacionalidad.Location = new System.Drawing.Point(163, 137);
            this.cmbNacionalidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(185, 23);
            this.cmbNacionalidad.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(407, 51);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 39);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(314, 51);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 39);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Nuevo";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(696, 51);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 39);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNuevoParticipante
            // 
            this.lblNuevoParticipante.AutoSize = true;
            this.lblNuevoParticipante.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoParticipante.Location = new System.Drawing.Point(31, 51);
            this.lblNuevoParticipante.Name = "lblNuevoParticipante";
            this.lblNuevoParticipante.Size = new System.Drawing.Size(244, 30);
            this.lblNuevoParticipante.TabIndex = 27;
            this.lblNuevoParticipante.Text = "PANEL PARTICIPANTES";
            // 
            // cmbGenero
            // 
            this.cmbGenero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Seleccionar una Opcion",
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(163, 201);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(185, 23);
            this.cmbGenero.TabIndex = 28;
            // 
            // errFormAltaParticipante
            // 
            this.errFormAltaParticipante.ContainerControl = this;
            // 
            // pnlTopParticpantes
            // 
            this.pnlTopParticpantes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlTopParticpantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopParticpantes.Location = new System.Drawing.Point(0, 0);
            this.pnlTopParticpantes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTopParticpantes.Name = "pnlTopParticpantes";
            this.pnlTopParticpantes.Size = new System.Drawing.Size(849, 30);
            this.pnlTopParticpantes.TabIndex = 29;
            // 
            // pnlBottomParticpantes
            // 
            this.pnlBottomParticpantes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlBottomParticpantes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomParticpantes.Location = new System.Drawing.Point(0, 622);
            this.pnlBottomParticpantes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBottomParticpantes.Name = "pnlBottomParticpantes";
            this.pnlBottomParticpantes.Size = new System.Drawing.Size(849, 30);
            this.pnlBottomParticpantes.TabIndex = 30;
            // 
            // grbxDatosParticpantes
            // 
            this.grbxDatosParticpantes.Controls.Add(this.txtID);
            this.grbxDatosParticpantes.Controls.Add(this.lblID);
            this.grbxDatosParticpantes.Controls.Add(this.txtNombre);
            this.grbxDatosParticpantes.Controls.Add(this.lblNombre);
            this.grbxDatosParticpantes.Controls.Add(this.txtApellido);
            this.grbxDatosParticpantes.Controls.Add(this.cmbGenero);
            this.grbxDatosParticpantes.Controls.Add(this.lblApellido);
            this.grbxDatosParticpantes.Controls.Add(this.txtDNI);
            this.grbxDatosParticpantes.Controls.Add(this.lblDNI);
            this.grbxDatosParticpantes.Controls.Add(this.txtEmail);
            this.grbxDatosParticpantes.Controls.Add(this.dttmFechaNac);
            this.grbxDatosParticpantes.Controls.Add(this.lblEmail);
            this.grbxDatosParticpantes.Controls.Add(this.txtDireccion);
            this.grbxDatosParticpantes.Controls.Add(this.lblDireccion);
            this.grbxDatosParticpantes.Controls.Add(this.cmbNacionalidad);
            this.grbxDatosParticpantes.Controls.Add(this.lblNacionalidad);
            this.grbxDatosParticpantes.Controls.Add(this.txtEntrenador);
            this.grbxDatosParticpantes.Controls.Add(this.txtPeso);
            this.grbxDatosParticpantes.Controls.Add(this.lblFechaNac);
            this.grbxDatosParticpantes.Controls.Add(this.lblEntrenador);
            this.grbxDatosParticpantes.Controls.Add(this.txtAltura);
            this.grbxDatosParticpantes.Controls.Add(this.lblGenero);
            this.grbxDatosParticpantes.Controls.Add(this.lblPeso);
            this.grbxDatosParticpantes.Controls.Add(this.lblAltura);
            this.grbxDatosParticpantes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxDatosParticpantes.Location = new System.Drawing.Point(55, 96);
            this.grbxDatosParticpantes.Name = "grbxDatosParticpantes";
            this.grbxDatosParticpantes.Size = new System.Drawing.Size(721, 259);
            this.grbxDatosParticpantes.TabIndex = 31;
            this.grbxDatosParticpantes.TabStop = false;
            this.grbxDatosParticpantes.Text = "DATOS DEL PARTICIPANTE";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(454, 195);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 23);
            this.txtID.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(369, 199);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 29;
            this.lblID.Text = "ID";
            // 
            // grbxBuscarParticipantes
            // 
            this.grbxBuscarParticipantes.Controls.Add(this.btnBuscarParticipantes);
            this.grbxBuscarParticipantes.Controls.Add(this.lblBusquedaParticipante);
            this.grbxBuscarParticipantes.Controls.Add(this.txtBusquedaPorDNI);
            this.grbxBuscarParticipantes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxBuscarParticipantes.Location = new System.Drawing.Point(55, 367);
            this.grbxBuscarParticipantes.Name = "grbxBuscarParticipantes";
            this.grbxBuscarParticipantes.Size = new System.Drawing.Size(721, 56);
            this.grbxBuscarParticipantes.TabIndex = 32;
            this.grbxBuscarParticipantes.TabStop = false;
            this.grbxBuscarParticipantes.Text = "BUSCAR";
            // 
            // btnBuscarParticipantes
            // 
            this.btnBuscarParticipantes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBuscarParticipantes.FlatAppearance.BorderSize = 0;
            this.btnBuscarParticipantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarParticipantes.Location = new System.Drawing.Point(413, 14);
            this.btnBuscarParticipantes.Name = "btnBuscarParticipantes";
            this.btnBuscarParticipantes.Size = new System.Drawing.Size(75, 32);
            this.btnBuscarParticipantes.TabIndex = 2;
            this.btnBuscarParticipantes.Text = "Buscar";
            this.btnBuscarParticipantes.UseVisualStyleBackColor = false;
            this.btnBuscarParticipantes.Click += new System.EventHandler(this.btnBuscarParticipantes_Click);
            // 
            // lblBusquedaParticipante
            // 
            this.lblBusquedaParticipante.AutoSize = true;
            this.lblBusquedaParticipante.Location = new System.Drawing.Point(35, 23);
            this.lblBusquedaParticipante.Name = "lblBusquedaParticipante";
            this.lblBusquedaParticipante.Size = new System.Drawing.Size(92, 15);
            this.lblBusquedaParticipante.TabIndex = 1;
            this.lblBusquedaParticipante.Text = "Ingrese Apellido";
            // 
            // txtBusquedaPorDNI
            // 
            this.txtBusquedaPorDNI.Location = new System.Drawing.Point(144, 20);
            this.txtBusquedaPorDNI.Name = "txtBusquedaPorDNI";
            this.txtBusquedaPorDNI.Size = new System.Drawing.Size(261, 23);
            this.txtBusquedaPorDNI.TabIndex = 0;
            // 
            // grbListaParicipantes
            // 
            this.grbListaParicipantes.Controls.Add(this.dtgwListaParticipantes);
            this.grbListaParicipantes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaParicipantes.Location = new System.Drawing.Point(55, 435);
            this.grbListaParicipantes.Name = "grbListaParicipantes";
            this.grbListaParicipantes.Size = new System.Drawing.Size(721, 170);
            this.grbListaParicipantes.TabIndex = 33;
            this.grbListaParicipantes.TabStop = false;
            this.grbListaParicipantes.Text = "LISTA DE PARTICIPANTES";
            // 
            // dtgwListaParticipantes
            // 
            this.dtgwListaParticipantes.AllowUserToAddRows = false;
            this.dtgwListaParticipantes.AllowUserToDeleteRows = false;
            this.dtgwListaParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwListaParticipantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgwListaParticipantes.Location = new System.Drawing.Point(3, 19);
            this.dtgwListaParticipantes.Name = "dtgwListaParticipantes";
            this.dtgwListaParticipantes.ReadOnly = true;
            this.dtgwListaParticipantes.Size = new System.Drawing.Size(715, 148);
            this.dtgwListaParticipantes.TabIndex = 0;
            this.dtgwListaParticipantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwListaParticipantes_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(500, 51);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 39);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(603, 51);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 39);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form_AltaParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 652);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grbListaParicipantes);
            this.Controls.Add(this.grbxBuscarParticipantes);
            this.Controls.Add(this.grbxDatosParticpantes);
            this.Controls.Add(this.pnlBottomParticpantes);
            this.Controls.Add(this.pnlTopParticpantes);
            this.Controls.Add(this.lblNuevoParticipante);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_AltaParticipantes";
            this.Text = "Form_AltaParticipantes";
            ((System.ComponentModel.ISupportInitialize)(this.errFormAltaParticipante)).EndInit();
            this.grbxDatosParticpantes.ResumeLayout(false);
            this.grbxDatosParticpantes.PerformLayout();
            this.grbxBuscarParticipantes.ResumeLayout(false);
            this.grbxBuscarParticipantes.PerformLayout();
            this.grbListaParicipantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwListaParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblEntrenador;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtEntrenador;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dttmFechaNac;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNuevoParticipante;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ErrorProvider errFormAltaParticipante;
        private System.Windows.Forms.Panel pnlBottomParticpantes;
        private System.Windows.Forms.Panel pnlTopParticpantes;
        private System.Windows.Forms.GroupBox grbxDatosParticpantes;
        private System.Windows.Forms.GroupBox grbListaParicipantes;
        private System.Windows.Forms.GroupBox grbxBuscarParticipantes;
        private System.Windows.Forms.DataGridView dtgwListaParticipantes;
        private System.Windows.Forms.TextBox txtBusquedaPorDNI;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscarParticipantes;
        private System.Windows.Forms.Label lblBusquedaParticipante;
    }
}