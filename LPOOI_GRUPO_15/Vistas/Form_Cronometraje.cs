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
    public partial class Form_Cronometraje : Form
    {
        public Form_Cronometraje()
        {
            InitializeComponent();
            cargar_competencias();
        }

        public struct Datos
        {
            public string dni;
            public string nombre;
            public string apellido;
            public string estado;
            public string nombreCompetencia;
            public string fInicio;
            public string fFin;
        }

        private void cargar_competencias() 
        {
            cmbxCompetencias.DisplayMember = "Nombre";
            cmbxCompetencias.ValueMember = "ID";
            cmbxCompetencias.DataSource = Form_AltaCompetencias.lista_Competencias();
        }

        public void cargarEventosAcreditados() 
        {
            string nCompetencia = cmbxCompetencias.Text;
            dtvParticipantes.DataSource = Form_AltaEventos.filtroCompetenciaEvento(nCompetencia, "Acreditado");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarEventosAcreditados();
        }

        private void dtvParticipantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Datos info = new Datos();
            info.dni = dtvParticipantes.CurrentRow.Cells["Atl_DNI"].Value.ToString();
            info.nombre = dtvParticipantes.CurrentRow.Cells["Atl_Nombre"].Value.ToString();
            info.apellido = dtvParticipantes.CurrentRow.Cells["Atl_Apellido"].Value.ToString();
            info.nombreCompetencia = dtvParticipantes.CurrentRow.Cells["Com_Nombre"].Value.ToString();
            info.estado = dtvParticipantes.CurrentRow.Cells["Eve_Estado"].Value.ToString();
            info.fInicio = dtvParticipantes.CurrentRow.Cells["Eve_HoraInicio"].Value.ToString();
            info.fFin = dtvParticipantes.CurrentRow.Cells["Eve_HoraFin"].Value.ToString();

            form_actualizarFechas fFechas = new form_actualizarFechas(info);
            fFechas.Dock = DockStyle.Fill;
            this.Controls.Add(fFechas);
            fFechas.BringToFront();

            // Suscribir el evento DatosActualizados
            fFechas.DatosActualizados += fFechas_DatosActualizados;
        }

        private void fFechas_DatosActualizados()
        {
            cargarEventosAcreditados();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void dtvParticipantes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string nCompetencia = cmbxCompetencias.Text;
            dtvParticipantes.DataSource = Form_AltaEventos.filtroCompetenciaEvento(nCompetencia, "Acreditado");
        }
    }
}
