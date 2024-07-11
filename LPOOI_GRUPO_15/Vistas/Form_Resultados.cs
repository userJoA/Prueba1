using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Vistas
{
    public partial class Form_Resultados : Form
    {
        public Form_Resultados()
        {
            InitializeComponent();
            cargar_competencias();
        }

        private void cargar_competencias() 
        {
            cmbCompetencias.DisplayMember = "Nombre";
            cmbCompetencias.ValueMember = "ID";
            cmbCompetencias.DataSource = Form_AltaCompetencias.lista_Competencias();
        }

        private void cmbCompetencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string competencia = cmbCompetencias.Text;
            dtvEventos.DataSource = Form_AltaEventos.filtroCompetenciaEventoByOrden(competencia,"Acreditado");

            gbxInformacionCompetencia.Visible = true;
            gbxInformacionCompetencia.Text = competencia;
            lblAbandonos.Text = "Numero de Abandonos: "+ Form_AltaEventos.contadorCompetenciasxEstado(competencia, "Abandono");
            lblDescalificaciones.Text = "Numero de Descalificados: " + Form_AltaEventos.contadorCompetenciasxEstado(competencia, "Descalificado");
            lbltotal.Text = "Numero de total de Participantes(Inscriptos,Anulados,Acreditados,Abandonos,Descalificados): " + Form_AltaEventos.contadorAtlxCompetencias(competencia);

        }


    }


}
