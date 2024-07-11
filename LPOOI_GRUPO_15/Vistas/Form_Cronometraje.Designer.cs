namespace Vistas
{
    partial class Form_Cronometraje
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxCompetencias = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dtvParticipantes = new System.Windows.Forms.DataGridView();
            this.pnlTopEventos = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Competencia";
            // 
            // cmbxCompetencias
            // 
            this.cmbxCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxCompetencias.FormattingEnabled = true;
            this.cmbxCompetencias.Location = new System.Drawing.Point(279, 164);
            this.cmbxCompetencias.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxCompetencias.Name = "cmbxCompetencias";
            this.cmbxCompetencias.Size = new System.Drawing.Size(263, 24);
            this.cmbxCompetencias.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(584, 155);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 41);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dtvParticipantes);
            this.gbxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(13, 219);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(4);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(4);
            this.gbxLista.Size = new System.Drawing.Size(805, 310);
            this.gbxLista.TabIndex = 3;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Participantes";
            // 
            // dtvParticipantes
            // 
            this.dtvParticipantes.AllowUserToAddRows = false;
            this.dtvParticipantes.AllowUserToDeleteRows = false;
            this.dtvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvParticipantes.Location = new System.Drawing.Point(25, 23);
            this.dtvParticipantes.Margin = new System.Windows.Forms.Padding(4);
            this.dtvParticipantes.Name = "dtvParticipantes";
            this.dtvParticipantes.ReadOnly = true;
            this.dtvParticipantes.Size = new System.Drawing.Size(761, 251);
            this.dtvParticipantes.TabIndex = 0;
            this.dtvParticipantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvParticipantes_CellDoubleClick);
            this.dtvParticipantes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvParticipantes_CellValueChanged);
            // 
            // pnlTopEventos
            // 
            this.pnlTopEventos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlTopEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopEventos.Location = new System.Drawing.Point(0, 0);
            this.pnlTopEventos.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopEventos.Name = "pnlTopEventos";
            this.pnlTopEventos.Size = new System.Drawing.Size(849, 37);
            this.pnlTopEventos.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 615);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 37);
            this.panel1.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(356, 94);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(136, 24);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cronometraje";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(768, 61);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 39);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Atras";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form_Cronometraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 652);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopEventos);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbxCompetencias);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Cronometraje";
            this.Text = "Form_Cronometraje";
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxCompetencias;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dtvParticipantes;
        private System.Windows.Forms.Panel pnlTopEventos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnClose;
    }
}