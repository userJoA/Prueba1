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
            this.pnlTopEventos = new System.Windows.Forms.Panel();
            this.pnlBottomEventos = new System.Windows.Forms.Panel();
            this.lblAltaEventos = new System.Windows.Forms.Label();
            this.btnNuevoEvento = new System.Windows.Forms.Button();
            this.btnAnularInscripcionEvento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlTopEventos
            // 
            this.pnlTopEventos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlTopEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopEventos.Location = new System.Drawing.Point(0, 0);
            this.pnlTopEventos.Name = "pnlTopEventos";
            this.pnlTopEventos.Size = new System.Drawing.Size(834, 30);
            this.pnlTopEventos.TabIndex = 0;
            // 
            // pnlBottomEventos
            // 
            this.pnlBottomEventos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlBottomEventos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomEventos.Location = new System.Drawing.Point(0, 583);
            this.pnlBottomEventos.Name = "pnlBottomEventos";
            this.pnlBottomEventos.Size = new System.Drawing.Size(834, 30);
            this.pnlBottomEventos.TabIndex = 1;
            // 
            // lblAltaEventos
            // 
            this.lblAltaEventos.AutoSize = true;
            this.lblAltaEventos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaEventos.ForeColor = System.Drawing.Color.Black;
            this.lblAltaEventos.Location = new System.Drawing.Point(37, 46);
            this.lblAltaEventos.Name = "lblAltaEventos";
            this.lblAltaEventos.Size = new System.Drawing.Size(177, 30);
            this.lblAltaEventos.TabIndex = 2;
            this.lblAltaEventos.Text = "PANEL EVENTOS";
            // 
            // btnNuevoEvento
            // 
            this.btnNuevoEvento.Location = new System.Drawing.Point(246, 166);
            this.btnNuevoEvento.Name = "btnNuevoEvento";
            this.btnNuevoEvento.Size = new System.Drawing.Size(251, 69);
            this.btnNuevoEvento.TabIndex = 3;
            this.btnNuevoEvento.Text = "Inscripcion a Evento";
            this.btnNuevoEvento.UseVisualStyleBackColor = true;
            this.btnNuevoEvento.Click += new System.EventHandler(this.btnNuevoEvento_Click);
            // 
            // btnAnularInscripcionEvento
            // 
            this.btnAnularInscripcionEvento.Location = new System.Drawing.Point(246, 270);
            this.btnAnularInscripcionEvento.Name = "btnAnularInscripcionEvento";
            this.btnAnularInscripcionEvento.Size = new System.Drawing.Size(251, 69);
            this.btnAnularInscripcionEvento.TabIndex = 4;
            this.btnAnularInscripcionEvento.Text = "Anular Inscripcion";
            this.btnAnularInscripcionEvento.UseVisualStyleBackColor = true;
            this.btnAnularInscripcionEvento.Click += new System.EventHandler(this.btnAnularInscripcionEvento_Click);
            // 
            // Form_AltaEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 613);
            this.Controls.Add(this.btnAnularInscripcionEvento);
            this.Controls.Add(this.btnNuevoEvento);
            this.Controls.Add(this.lblAltaEventos);
            this.Controls.Add(this.pnlBottomEventos);
            this.Controls.Add(this.pnlTopEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AltaEventos";
            this.Text = "Form_AltaEventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopEventos;
        private System.Windows.Forms.Panel pnlBottomEventos;
        private System.Windows.Forms.Label lblAltaEventos;
        private System.Windows.Forms.Button btnNuevoEvento;
        private System.Windows.Forms.Button btnAnularInscripcionEvento;
    }
}