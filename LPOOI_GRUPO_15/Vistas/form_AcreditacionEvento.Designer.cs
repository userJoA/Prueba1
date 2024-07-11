namespace Vistas
{
    partial class form_AcreditacionEvento
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
            this.components = new System.ComponentModel.Container();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtvEventos = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscarEventosT = new System.Windows.Forms.Button();
            this.errorProviderEventoAcreditacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEventoAcreditacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(43, 199);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(83, 16);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "Ingresar DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(167, 195);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(204, 22);
            this.txtDNI.TabIndex = 1;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtvEventos);
            this.groupBox1.Location = new System.Drawing.Point(38, 279);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(680, 293);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Eventos";
            // 
            // dtvEventos
            // 
            this.dtvEventos.AllowUserToAddRows = false;
            this.dtvEventos.AllowUserToDeleteRows = false;
            this.dtvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvEventos.Location = new System.Drawing.Point(19, 38);
            this.dtvEventos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtvEventos.Name = "dtvEventos";
            this.dtvEventos.ReadOnly = true;
            this.dtvEventos.Size = new System.Drawing.Size(630, 219);
            this.dtvEventos.TabIndex = 0;
            this.dtvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvEventos_CellClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(788, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(57, 45);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Atras";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(414, 185);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(181, 44);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Ver Inscripciones";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(744, 317);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 54);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Acreditar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscarEventosT
            // 
            this.btnBuscarEventosT.Location = new System.Drawing.Point(57, 124);
            this.btnBuscarEventosT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarEventosT.Name = "btnBuscarEventosT";
            this.btnBuscarEventosT.Size = new System.Drawing.Size(236, 44);
            this.btnBuscarEventosT.TabIndex = 6;
            this.btnBuscarEventosT.Text = "Ver Todos lo Eventos Asociados";
            this.btnBuscarEventosT.UseVisualStyleBackColor = true;
            this.btnBuscarEventosT.Visible = false;
            this.btnBuscarEventosT.Click += new System.EventHandler(this.btnBuscarEventosT_Click);
            // 
            // errorProviderEventoAcreditacion
            // 
            this.errorProviderEventoAcreditacion.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Acreditaciones";
            // 
            // form_AcreditacionEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarEventosT);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_AcreditacionEvento";
            this.Size = new System.Drawing.Size(849, 652);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEventoAcreditacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtvEventos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscarEventosT;
        private System.Windows.Forms.ErrorProvider errorProviderEventoAcreditacion;
        private System.Windows.Forms.Label label1;
    }
}
