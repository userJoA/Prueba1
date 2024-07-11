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
            this.components = new System.ComponentModel.Container();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxListaDeEventosxAtl = new System.Windows.Forms.GroupBox();
            this.dtgvEventos = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.errorProviderAnulaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxListaDeEventosxAtl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAnulaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(422, 190);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(86, 33);
            this.btnConsulta.TabIndex = 7;
            this.btnConsulta.Text = "Buscar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(159, 195);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(245, 22);
            this.txtDni.TabIndex = 5;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(63, 198);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(79, 16);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "Ingrese DNI";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(775, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(70, 46);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Atras";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrarAn_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(754, 321);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(70, 43);
            this.btnAnular.TabIndex = 9;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Visible = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Anulacion de Inscripciones";
            // 
            // gbxListaDeEventosxAtl
            // 
            this.gbxListaDeEventosxAtl.Controls.Add(this.dtgvEventos);
            this.gbxListaDeEventosxAtl.Location = new System.Drawing.Point(56, 303);
            this.gbxListaDeEventosxAtl.Name = "gbxListaDeEventosxAtl";
            this.gbxListaDeEventosxAtl.Size = new System.Drawing.Size(665, 211);
            this.gbxListaDeEventosxAtl.TabIndex = 11;
            this.gbxListaDeEventosxAtl.TabStop = false;
            this.gbxListaDeEventosxAtl.Text = "Lista de Eventos";
            // 
            // dtgvEventos
            // 
            this.dtgvEventos.AllowUserToAddRows = false;
            this.dtgvEventos.AllowUserToDeleteRows = false;
            this.dtgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEventos.Location = new System.Drawing.Point(25, 18);
            this.dtgvEventos.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvEventos.Name = "dtgvEventos";
            this.dtgvEventos.ReadOnly = true;
            this.dtgvEventos.Size = new System.Drawing.Size(618, 174);
            this.dtgvEventos.TabIndex = 7;
            this.dtgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEventos_CellClick);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(63, 241);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 16);
            this.lblInfo.TabIndex = 12;
            // 
            // errorProviderAnulaciones
            // 
            this.errorProviderAnulaciones.ContainerControl = this;
            // 
            // form_AnularInscripcionEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbxListaDeEventosxAtl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_AnularInscripcionEvento";
            this.Size = new System.Drawing.Size(849, 652);
            this.gbxListaDeEventosxAtl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAnulaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxListaDeEventosxAtl;
        private System.Windows.Forms.DataGridView dtgvEventos;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ErrorProvider errorProviderAnulaciones;

    }
}
