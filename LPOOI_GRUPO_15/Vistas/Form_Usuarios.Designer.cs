namespace Vistas
{
    partial class Form_Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new Vistas.UsersDataSet();
            this.usuarioTableAdapter = new Vistas.UsersDataSetTableAdapters.UsuarioTableAdapter();
            this.pnlTopFmrUsuarios = new System.Windows.Forms.Panel();
            this.pnlBottomFmrUsuarios = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbRol_ID = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuNombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuContraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuApellidoNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.AutoGenerateColumns = false;
            this.dtgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuIDDataGridViewTextBoxColumn,
            this.usuNombreUsuarioDataGridViewTextBoxColumn,
            this.usuContraseñaDataGridViewTextBoxColumn,
            this.usuApellidoNombreDataGridViewTextBoxColumn,
            this.rolCodigoDataGridViewTextBoxColumn});
            this.dtgvUsuarios.DataSource = this.usuarioBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvUsuarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvUsuarios.Location = new System.Drawing.Point(7, 117);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvUsuarios.Size = new System.Drawing.Size(538, 150);
            this.dtgvUsuarios.TabIndex = 0;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // pnlTopFmrUsuarios
            // 
            this.pnlTopFmrUsuarios.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlTopFmrUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopFmrUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlTopFmrUsuarios.Name = "pnlTopFmrUsuarios";
            this.pnlTopFmrUsuarios.Size = new System.Drawing.Size(833, 30);
            this.pnlTopFmrUsuarios.TabIndex = 1;
            // 
            // pnlBottomFmrUsuarios
            // 
            this.pnlBottomFmrUsuarios.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlBottomFmrUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomFmrUsuarios.Location = new System.Drawing.Point(0, 583);
            this.pnlBottomFmrUsuarios.Name = "pnlBottomFmrUsuarios";
            this.pnlBottomFmrUsuarios.Size = new System.Drawing.Size(833, 30);
            this.pnlBottomFmrUsuarios.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnGuardarUsuario);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.cmbRol_ID);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblContraseña);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.Location = new System.Drawing.Point(551, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 346);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos De Usuario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 189);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(80, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(157, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(80, 101);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(157, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // cmbRol_ID
            // 
            this.cmbRol_ID.FormattingEnabled = true;
            this.cmbRol_ID.Location = new System.Drawing.Point(80, 56);
            this.cmbRol_ID.Name = "cmbRol_ID";
            this.cmbRol_ID.Size = new System.Drawing.Size(157, 21);
            this.cmbRol_ID.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 196);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(15, 152);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(15, 108);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(15, 64);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Rol";
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(47, 297);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarUsuario.TabIndex = 12;
            this.btnGuardarUsuario.Text = "button1";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // usuIDDataGridViewTextBoxColumn
            // 
            this.usuIDDataGridViewTextBoxColumn.DataPropertyName = "Usu_ID";
            this.usuIDDataGridViewTextBoxColumn.HeaderText = "Usu_ID";
            this.usuIDDataGridViewTextBoxColumn.Name = "usuIDDataGridViewTextBoxColumn";
            this.usuIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuNombreUsuarioDataGridViewTextBoxColumn
            // 
            this.usuNombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usu_NombreUsuario";
            this.usuNombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Usu_NombreUsuario";
            this.usuNombreUsuarioDataGridViewTextBoxColumn.Name = "usuNombreUsuarioDataGridViewTextBoxColumn";
            // 
            // usuContraseñaDataGridViewTextBoxColumn
            // 
            this.usuContraseñaDataGridViewTextBoxColumn.DataPropertyName = "Usu_Contraseña";
            this.usuContraseñaDataGridViewTextBoxColumn.HeaderText = "Usu_Contraseña";
            this.usuContraseñaDataGridViewTextBoxColumn.Name = "usuContraseñaDataGridViewTextBoxColumn";
            // 
            // usuApellidoNombreDataGridViewTextBoxColumn
            // 
            this.usuApellidoNombreDataGridViewTextBoxColumn.DataPropertyName = "Usu_ApellidoNombre";
            this.usuApellidoNombreDataGridViewTextBoxColumn.HeaderText = "Usu_ApellidoNombre";
            this.usuApellidoNombreDataGridViewTextBoxColumn.Name = "usuApellidoNombreDataGridViewTextBoxColumn";
            // 
            // rolCodigoDataGridViewTextBoxColumn
            // 
            this.rolCodigoDataGridViewTextBoxColumn.DataPropertyName = "Rol_Codigo";
            this.rolCodigoDataGridViewTextBoxColumn.HeaderText = "Rol_Codigo";
            this.rolCodigoDataGridViewTextBoxColumn.Name = "rolCodigoDataGridViewTextBoxColumn";
            this.rolCodigoDataGridViewTextBoxColumn.Width = 80;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(15, 240);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(80, 233);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(157, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // Form_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlBottomFmrUsuarios);
            this.Controls.Add(this.pnlTopFmrUsuarios);
            this.Controls.Add(this.dtgvUsuarios);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Usuarios";
            this.Text = "Form_Usuarios";
            this.Load += new System.EventHandler(this.Form_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private UsersDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Panel pnlTopFmrUsuarios;
        private System.Windows.Forms.Panel pnlBottomFmrUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cmbRol_ID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuNombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuContraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuApellidoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
    }
}