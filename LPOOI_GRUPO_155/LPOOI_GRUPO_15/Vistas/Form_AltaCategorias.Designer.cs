namespace Vistas
{
    partial class Form_AltaCategorias
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
            this.lblNuevaCategotia = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlTopCategoria = new System.Windows.Forms.Panel();
            this.pnlBottomCategoria = new System.Windows.Forms.Panel();
            this.errpFormularioAltaCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbxCategoriaDatos = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbxListaCategorias = new System.Windows.Forms.GroupBox();
            this.dtgwCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errpFormularioAltaCategoria)).BeginInit();
            this.grbxCategoriaDatos.SuspendLayout();
            this.grbxListaCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevaCategotia
            // 
            this.lblNuevaCategotia.AutoSize = true;
            this.lblNuevaCategotia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCategotia.ForeColor = System.Drawing.Color.Black;
            this.lblNuevaCategotia.Location = new System.Drawing.Point(31, 51);
            this.lblNuevaCategotia.Name = "lblNuevaCategotia";
            this.lblNuevaCategotia.Size = new System.Drawing.Size(202, 30);
            this.lblNuevaCategotia.TabIndex = 0;
            this.lblNuevaCategotia.Text = "PANEL CATEGORIA";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(126, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(126, 70);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(219, 68);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(233, 63);
            this.txtDescripcion.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(509, 25);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 39);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(692, 49);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 42);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlTopCategoria
            // 
            this.pnlTopCategoria.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlTopCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopCategoria.Location = new System.Drawing.Point(0, 0);
            this.pnlTopCategoria.Name = "pnlTopCategoria";
            this.pnlTopCategoria.Size = new System.Drawing.Size(850, 30);
            this.pnlTopCategoria.TabIndex = 10;
            // 
            // pnlBottomCategoria
            // 
            this.pnlBottomCategoria.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlBottomCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomCategoria.Location = new System.Drawing.Point(0, 622);
            this.pnlBottomCategoria.Name = "pnlBottomCategoria";
            this.pnlBottomCategoria.Size = new System.Drawing.Size(850, 30);
            this.pnlBottomCategoria.TabIndex = 11;
            // 
            // errpFormularioAltaCategoria
            // 
            this.errpFormularioAltaCategoria.ContainerControl = this;
            // 
            // grbxCategoriaDatos
            // 
            this.grbxCategoriaDatos.Controls.Add(this.txtNombre);
            this.grbxCategoriaDatos.Controls.Add(this.btnEliminar);
            this.grbxCategoriaDatos.Controls.Add(this.lblNombre);
            this.grbxCategoriaDatos.Controls.Add(this.lblDescripcion);
            this.grbxCategoriaDatos.Controls.Add(this.txtDescripcion);
            this.grbxCategoriaDatos.Controls.Add(this.btnGuardar);
            this.grbxCategoriaDatos.Location = new System.Drawing.Point(58, 98);
            this.grbxCategoriaDatos.Name = "grbxCategoriaDatos";
            this.grbxCategoriaDatos.Size = new System.Drawing.Size(718, 156);
            this.grbxCategoriaDatos.TabIndex = 12;
            this.grbxCategoriaDatos.TabStop = false;
            this.grbxCategoriaDatos.Text = "DATOS CATEGORIA";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(219, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(509, 89);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 42);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Location = new System.Drawing.Point(537, 49);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(119, 42);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nueva Categoria";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grbxListaCategorias
            // 
            this.grbxListaCategorias.Controls.Add(this.dtgwCategorias);
            this.grbxListaCategorias.Location = new System.Drawing.Point(58, 286);
            this.grbxListaCategorias.Name = "grbxListaCategorias";
            this.grbxListaCategorias.Size = new System.Drawing.Size(718, 219);
            this.grbxListaCategorias.TabIndex = 14;
            this.grbxListaCategorias.TabStop = false;
            this.grbxListaCategorias.Text = "LISTA DE CATEGORIAS";
            // 
            // dtgwCategorias
            // 
            this.dtgwCategorias.AllowUserToAddRows = false;
            this.dtgwCategorias.AllowUserToDeleteRows = false;
            this.dtgwCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwCategorias.Location = new System.Drawing.Point(34, 28);
            this.dtgwCategorias.Name = "dtgwCategorias";
            this.dtgwCategorias.ReadOnly = true;
            this.dtgwCategorias.Size = new System.Drawing.Size(658, 150);
            this.dtgwCategorias.TabIndex = 0;
            this.dtgwCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwCategorias_CellClick);
            // 
            // Form_AltaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 652);
            this.Controls.Add(this.grbxListaCategorias);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grbxCategoriaDatos);
            this.Controls.Add(this.pnlBottomCategoria);
            this.Controls.Add(this.pnlTopCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblNuevaCategotia);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AltaCategorias";
            this.Text = "Form_AltaCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.errpFormularioAltaCategoria)).EndInit();
            this.grbxCategoriaDatos.ResumeLayout(false);
            this.grbxCategoriaDatos.PerformLayout();
            this.grbxListaCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCategotia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlTopCategoria;
        private System.Windows.Forms.Panel pnlBottomCategoria;
        private System.Windows.Forms.ErrorProvider errpFormularioAltaCategoria;
        private System.Windows.Forms.GroupBox grbxCategoriaDatos;
        private System.Windows.Forms.GroupBox grbxListaCategorias;
        private System.Windows.Forms.DataGridView dtgwCategorias;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombre;
    }
}