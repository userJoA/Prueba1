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
            this.lblAltaEventos.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaEventos.ForeColor = System.Drawing.Color.Black;
            this.lblAltaEventos.Location = new System.Drawing.Point(301, 288);
            this.lblAltaEventos.Name = "lblAltaEventos";
            this.lblAltaEventos.Size = new System.Drawing.Size(233, 37);
            this.lblAltaEventos.TabIndex = 2;
            this.lblAltaEventos.Text = "Nuevo Evento";
            // 
            // Form_AltaEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 613);
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
    }
}