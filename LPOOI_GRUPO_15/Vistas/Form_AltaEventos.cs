using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Form_AltaEventos : Form
    {
        public Form_AltaEventos()
        {
            InitializeComponent();
        }

        private void btnNuevoEvento_Click(object sender, EventArgs e)
        {
            form_InscripcionEventos fInscripcion = new form_InscripcionEventos();
            fInscripcion.Dock = DockStyle.Fill;
            this.Controls.Add(fInscripcion);
            fInscripcion.BringToFront();
        }

        private void btnAnularInscripcionEvento_Click(object sender, EventArgs e)
        {
            form_AnularInscripcionEvento fAnularInsc = new form_AnularInscripcionEvento();
            fAnularInsc.Dock = DockStyle.Fill;
            this.Controls.Add(fAnularInsc);
            fAnularInsc.BringToFront();
        }


    }
}
