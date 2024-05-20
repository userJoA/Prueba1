namespace Vistas
{
    partial class Form_AltaDisciplinas
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
            this.lblNuevaDisciplina = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.pnlTopDisciplina = new System.Windows.Forms.Panel();
            this.pnlBottomDiscplina = new System.Windows.Forms.Panel();
            this.errpFormularioAltaDisciplna = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errpFormularioAltaDisciplna)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevaDisciplina
            // 
            this.lblNuevaDisciplina.AutoSize = true;
            this.lblNuevaDisciplina.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaDisciplina.ForeColor = System.Drawing.Color.Black;
            this.lblNuevaDisciplina.Location = new System.Drawing.Point(240, 118);
            this.lblNuevaDisciplina.Name = "lblNuevaDisciplina";
            this.lblNuevaDisciplina.Size = new System.Drawing.Size(305, 37);
            this.lblNuevaDisciplina.TabIndex = 0;
            this.lblNuevaDisciplina.Text = "Nueva Disciplina";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(162, 227);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(162, 294);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(133, 25);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(372, 294);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(316, 139);
            this.txtDescripcion.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(218, 474);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 60);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(457, 474);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 60);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbNombre
            // 
            this.cmbNombre.Font = new System.Drawing.Font("Cascadia Code SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombre.ForeColor = System.Drawing.Color.Black;
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Items.AddRange(new object[] {
            "seleccione una disciplina",
            "Atletismo",
            "Natacion",
            "Ciclismo"});
            this.cmbNombre.Location = new System.Drawing.Point(372, 227);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(316, 33);
            this.cmbNombre.TabIndex = 10;
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbNombre_SelectedIndexChanged);
            // 
            // pnlTopDisciplina
            // 
            this.pnlTopDisciplina.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlTopDisciplina.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopDisciplina.Location = new System.Drawing.Point(0, 0);
            this.pnlTopDisciplina.Name = "pnlTopDisciplina";
            this.pnlTopDisciplina.Size = new System.Drawing.Size(850, 30);
            this.pnlTopDisciplina.TabIndex = 11;
            // 
            // pnlBottomDiscplina
            // 
            this.pnlBottomDiscplina.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlBottomDiscplina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomDiscplina.Location = new System.Drawing.Point(0, 622);
            this.pnlBottomDiscplina.Name = "pnlBottomDiscplina";
            this.pnlBottomDiscplina.Size = new System.Drawing.Size(850, 30);
            this.pnlBottomDiscplina.TabIndex = 12;
            // 
            // errpFormularioAltaDisciplna
            // 
            this.errpFormularioAltaDisciplna.ContainerControl = this;
            // 
            // Form_AltaDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 652);
            this.Controls.Add(this.pnlBottomDiscplina);
            this.Controls.Add(this.pnlTopDisciplina);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNuevaDisciplina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AltaDisciplinas";
            this.Text = "f";
            ((System.ComponentModel.ISupportInitialize)(this.errpFormularioAltaDisciplna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaDisciplina;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Panel pnlTopDisciplina;
        private System.Windows.Forms.Panel pnlBottomDiscplina;
        private System.Windows.Forms.ErrorProvider errpFormularioAltaDisciplna;
    }
}