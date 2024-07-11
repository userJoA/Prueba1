namespace Vistas
{
    partial class Form_AltaEventos
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
            this.pnlTopEventos = new System.Windows.Forms.Panel();
            this.pnlBottomEventos = new System.Windows.Forms.Panel();
            this.lblAltaEventos = new System.Windows.Forms.Label();
            this.btnNuevoEvento = new System.Windows.Forms.Button();
            this.btnAnularInscripcionEvento = new System.Windows.Forms.Button();
            this.btnAcreditaciones = new System.Windows.Forms.Button();
            this.errorProviderEvento = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlEventos = new System.Windows.Forms.Panel();
            this.btnListaEventos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopEventos
            // 
            this.pnlTopEventos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlTopEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopEventos.Location = new System.Drawing.Point(0, 0);
            this.pnlTopEventos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTopEventos.Name = "pnlTopEventos";
            this.pnlTopEventos.Size = new System.Drawing.Size(849, 37);
            this.pnlTopEventos.TabIndex = 0;
            // 
            // pnlBottomEventos
            // 
            this.pnlBottomEventos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlBottomEventos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomEventos.Location = new System.Drawing.Point(0, 615);
            this.pnlBottomEventos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBottomEventos.Name = "pnlBottomEventos";
            this.pnlBottomEventos.Size = new System.Drawing.Size(849, 37);
            this.pnlBottomEventos.TabIndex = 1;
            // 
            // lblAltaEventos
            // 
            this.lblAltaEventos.AutoSize = true;
            this.lblAltaEventos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaEventos.ForeColor = System.Drawing.Color.Black;
            this.lblAltaEventos.Location = new System.Drawing.Point(49, 57);
            this.lblAltaEventos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltaEventos.Name = "lblAltaEventos";
            this.lblAltaEventos.Size = new System.Drawing.Size(177, 30);
            this.lblAltaEventos.TabIndex = 2;
            this.lblAltaEventos.Text = "PANEL EVENTOS";
            // 
            // btnNuevoEvento
            // 
            this.btnNuevoEvento.Location = new System.Drawing.Point(38, 143);
            this.btnNuevoEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevoEvento.Name = "btnNuevoEvento";
            this.btnNuevoEvento.Size = new System.Drawing.Size(236, 52);
            this.btnNuevoEvento.TabIndex = 3;
            this.btnNuevoEvento.Text = "Inscripcion a Evento";
            this.btnNuevoEvento.UseVisualStyleBackColor = true;
            this.btnNuevoEvento.Click += new System.EventHandler(this.btnNuevoEvento_Click);
            // 
            // btnAnularInscripcionEvento
            // 
            this.btnAnularInscripcionEvento.Location = new System.Drawing.Point(291, 143);
            this.btnAnularInscripcionEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnularInscripcionEvento.Name = "btnAnularInscripcionEvento";
            this.btnAnularInscripcionEvento.Size = new System.Drawing.Size(236, 50);
            this.btnAnularInscripcionEvento.TabIndex = 4;
            this.btnAnularInscripcionEvento.Text = "Anular Inscripcion";
            this.btnAnularInscripcionEvento.UseVisualStyleBackColor = true;
            this.btnAnularInscripcionEvento.Click += new System.EventHandler(this.btnAnularInscripcionEvento_Click);
            // 
            // btnAcreditaciones
            // 
            this.btnAcreditaciones.Location = new System.Drawing.Point(547, 143);
            this.btnAcreditaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAcreditaciones.Name = "btnAcreditaciones";
            this.btnAcreditaciones.Size = new System.Drawing.Size(236, 50);
            this.btnAcreditaciones.TabIndex = 5;
            this.btnAcreditaciones.Text = "Acreditaciones";
            this.btnAcreditaciones.UseVisualStyleBackColor = true;
            this.btnAcreditaciones.Click += new System.EventHandler(this.btnAcreditaciones_Click);
            // 
            // errorProviderEvento
            // 
            this.errorProviderEvento.ContainerControl = this;
            // 
            // pnlEventos
            // 
            this.pnlEventos.BackColor = System.Drawing.Color.DarkGray;
            this.pnlEventos.ForeColor = System.Drawing.Color.Black;
            this.pnlEventos.Location = new System.Drawing.Point(38, 309);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(745, 264);
            this.pnlEventos.TabIndex = 6;
            this.pnlEventos.Visible = false;
            // 
            // btnListaEventos
            // 
            this.btnListaEventos.Location = new System.Drawing.Point(38, 242);
            this.btnListaEventos.Name = "btnListaEventos";
            this.btnListaEventos.Size = new System.Drawing.Size(135, 41);
            this.btnListaEventos.TabIndex = 7;
            this.btnListaEventos.Text = "Ver  Lista";
            this.btnListaEventos.UseVisualStyleBackColor = true;
            this.btnListaEventos.Click += new System.EventHandler(this.btnListaEventos_Click);
            // 
            // Form_AltaEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 652);
            this.Controls.Add(this.btnListaEventos);
            this.Controls.Add(this.pnlEventos);
            this.Controls.Add(this.btnAcreditaciones);
            this.Controls.Add(this.btnAnularInscripcionEvento);
            this.Controls.Add(this.btnNuevoEvento);
            this.Controls.Add(this.lblAltaEventos);
            this.Controls.Add(this.pnlBottomEventos);
            this.Controls.Add(this.pnlTopEventos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_AltaEventos";
            this.Text = "Form_AltaEventos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopEventos;
        private System.Windows.Forms.Panel pnlBottomEventos;
        private System.Windows.Forms.Label lblAltaEventos;
        private System.Windows.Forms.Button btnNuevoEvento;
        private System.Windows.Forms.Button btnAnularInscripcionEvento;
        private System.Windows.Forms.Button btnAcreditaciones;
        private System.Windows.Forms.ErrorProvider errorProviderEvento;
        private System.Windows.Forms.Button btnListaEventos;
        private System.Windows.Forms.Panel pnlEventos;
    }
}