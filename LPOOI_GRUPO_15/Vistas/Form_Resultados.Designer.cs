namespace Vistas
{
    partial class Form_Resultados
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
            this.lblCompetencias = new System.Windows.Forms.Label();
            this.cmbCompetencias = new System.Windows.Forms.ComboBox();
            this.gbxEventosResultados = new System.Windows.Forms.GroupBox();
            this.dtvEventos = new System.Windows.Forms.DataGridView();
            this.gbxInformacionCompetencia = new System.Windows.Forms.GroupBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblAbandonos = new System.Windows.Forms.Label();
            this.lblDescalificaciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxEventosResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEventos)).BeginInit();
            this.gbxInformacionCompetencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompetencias
            // 
            this.lblCompetencias.AutoSize = true;
            this.lblCompetencias.Location = new System.Drawing.Point(93, 70);
            this.lblCompetencias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetencias.Name = "lblCompetencias";
            this.lblCompetencias.Size = new System.Drawing.Size(163, 16);
            this.lblCompetencias.TabIndex = 0;
            this.lblCompetencias.Text = "Seleccionar Competencia";
            // 
            // cmbCompetencias
            // 
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(322, 66);
            this.cmbCompetencias.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(263, 24);
            this.cmbCompetencias.TabIndex = 1;
            this.cmbCompetencias.SelectedIndexChanged += new System.EventHandler(this.cmbCompetencias_SelectedIndexChanged);
            // 
            // gbxEventosResultados
            // 
            this.gbxEventosResultados.Controls.Add(this.dtvEventos);
            this.gbxEventosResultados.Location = new System.Drawing.Point(28, 104);
            this.gbxEventosResultados.Margin = new System.Windows.Forms.Padding(4);
            this.gbxEventosResultados.Name = "gbxEventosResultados";
            this.gbxEventosResultados.Padding = new System.Windows.Forms.Padding(4);
            this.gbxEventosResultados.Size = new System.Drawing.Size(777, 237);
            this.gbxEventosResultados.TabIndex = 2;
            this.gbxEventosResultados.TabStop = false;
            this.gbxEventosResultados.Text = "Posicion General";
            // 
            // dtvEventos
            // 
            this.dtvEventos.AllowUserToAddRows = false;
            this.dtvEventos.AllowUserToDeleteRows = false;
            this.dtvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvEventos.Location = new System.Drawing.Point(19, 23);
            this.dtvEventos.Margin = new System.Windows.Forms.Padding(4);
            this.dtvEventos.Name = "dtvEventos";
            this.dtvEventos.ReadOnly = true;
            this.dtvEventos.Size = new System.Drawing.Size(734, 185);
            this.dtvEventos.TabIndex = 0;
            // 
            // gbxInformacionCompetencia
            // 
            this.gbxInformacionCompetencia.Controls.Add(this.lbltotal);
            this.gbxInformacionCompetencia.Controls.Add(this.lblAbandonos);
            this.gbxInformacionCompetencia.Controls.Add(this.lblDescalificaciones);
            this.gbxInformacionCompetencia.Location = new System.Drawing.Point(28, 348);
            this.gbxInformacionCompetencia.Margin = new System.Windows.Forms.Padding(4);
            this.gbxInformacionCompetencia.Name = "gbxInformacionCompetencia";
            this.gbxInformacionCompetencia.Padding = new System.Windows.Forms.Padding(4);
            this.gbxInformacionCompetencia.Size = new System.Drawing.Size(777, 136);
            this.gbxInformacionCompetencia.TabIndex = 3;
            this.gbxInformacionCompetencia.TabStop = false;
            this.gbxInformacionCompetencia.Text = "groupBox2";
            this.gbxInformacionCompetencia.Visible = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(65, 89);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(12, 16);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "-";
            // 
            // lblAbandonos
            // 
            this.lblAbandonos.AutoSize = true;
            this.lblAbandonos.Location = new System.Drawing.Point(65, 62);
            this.lblAbandonos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAbandonos.Name = "lblAbandonos";
            this.lblAbandonos.Size = new System.Drawing.Size(12, 16);
            this.lblAbandonos.TabIndex = 1;
            this.lblAbandonos.Text = "-";
            // 
            // lblDescalificaciones
            // 
            this.lblDescalificaciones.AutoSize = true;
            this.lblDescalificaciones.Location = new System.Drawing.Point(65, 36);
            this.lblDescalificaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescalificaciones.Name = "lblDescalificaciones";
            this.lblDescalificaciones.Size = new System.Drawing.Size(12, 16);
            this.lblDescalificaciones.TabIndex = 0;
            this.lblDescalificaciones.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resultados";
            // 
            // Form_Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxInformacionCompetencia);
            this.Controls.Add(this.gbxEventosResultados);
            this.Controls.Add(this.cmbCompetencias);
            this.Controls.Add(this.lblCompetencias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Resultados";
            this.Text = "Form_Resultados";
            this.gbxEventosResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvEventos)).EndInit();
            this.gbxInformacionCompetencia.ResumeLayout(false);
            this.gbxInformacionCompetencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompetencias;
        private System.Windows.Forms.ComboBox cmbCompetencias;
        private System.Windows.Forms.GroupBox gbxEventosResultados;
        private System.Windows.Forms.DataGridView dtvEventos;
        private System.Windows.Forms.GroupBox gbxInformacionCompetencia;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblAbandonos;
        private System.Windows.Forms.Label lblDescalificaciones;
        private System.Windows.Forms.Label label1;
    }
}