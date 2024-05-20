using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class Form_AltaCompetencias : Form
    {
        public Form_AltaCompetencias()
        {
            InitializeComponent();
        }

        Competencia competancia;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void limpiar(){
            txtNombre.Clear();
            txtDescrpcion.Clear();
            txtUbicacion.Clear();
            txtOrganizador.Clear();
            txtSponsors.Clear();
            dttmFechaInicio.ResetText();
            dttmFechaFin.ResetText();
            txtNombre.Focus();
        }

        Boolean formularioCompleto()
        {
            if (txtDescrpcion.Text != "" && txtNombre.Text != "" && txtOrganizador.Text != "" && txtSponsors.Text != "" && txtUbicacion.Text != "")
                {return true;}
            else { return false; }
        }

        Boolean validacionFecha() {
            DateTime hoy = DateTime.Today;
            if (dttmFechaInicio.Value >= hoy && dttmFechaFin.Value >= dttmFechaInicio.Value)
                return true;
            else
                return false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (formularioCompleto() == true && validacionFecha() == true)
            {
                competancia = new Competencia(txtNombre.Text, txtDescrpcion.Text, dttmFechaInicio.Value, dttmFechaFin.Value, txtOrganizador.Text, txtSponsors.Text, txtUbicacion.Text);
                MessageBox.Show("Nombre: " + competancia.Com_Nombre + "\n" +
                                "Descripcion: " + competancia.Com_Descripcion + "\n" +
                                "Ubicacion: " + competancia.Com_Ubicacion + "\n" +
                                "Organizador: " + competancia.Com_Organizador + "\n" +
                                "Sponsors: " + competancia.Com_Sponsors + "\n" +
                                "Fecha de Inicio: " + competancia.Com_FechaInicio + "\n" +
                                "Fecha de Finalizacion: " + competancia.Com_FechaFin + "\n");
            }
            else { MessageBox.Show("Debe completar correctamente los campos del formulario"); }
        }

    }
}
