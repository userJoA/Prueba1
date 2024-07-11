using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using ClasesBase;

namespace Vistas
{
    public partial class form_InscripcionEventos : UserControl
    {
        public form_InscripcionEventos()
        {
            InitializeComponent();
            //cargar_eventos();
            cargar_Atletas_Competencias();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Accede al contenedor padre y remueve este control
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);

                // Opcionalmente, puedes llamar al método Dispose para liberar recursos
                this.Dispose();
            }
        }

        private void limpiar()
        {
            
        }

        public static bool comprobar_competencia_atleta(int comid, int atlid)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Consulta_Evento_CompetenciaAtleta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@comId", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = comid;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@atlId", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = atlid;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@existe", SqlDbType.Bit);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            bool verificar = Convert.ToBoolean(cmd.Parameters["@existe"].Value);
            return verificar;

        }

        private DataTable lista_EventosCompetencias(string competencia)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Consulta_ViewEvento_Filtro_Competencias";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@competencia", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = competencia;
            cmd.Parameters.Add(param);

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void cargar_Atletas_Competencias() 
        {
            cmbCompetencias.DisplayMember = "Nombre";
            cmbCompetencias.ValueMember = "ID";
            cmbCompetencias.DataSource = Form_AltaCompetencias.lista_Competencias();

            cmbAtletas.DisplayMember = "DNI";
            cmbAtletas.ValueMember = "ID";
            cmbAtletas.DataSource = ParticipanteCtrl.lista_Participantes();
        }

        public static void insertar_Evento(Evento oevento)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insertar_Evento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@comId", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = oevento.Com_ID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@AtlId", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = oevento.Atl_ID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@eveEst", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = oevento.Eve_Estado;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@eveInicio", SqlDbType.Time);
            param.Direction = ParameterDirection.Input;
            if (oevento.Eve_HoraInicio.HasValue)
                param.Value = oevento.Eve_HoraInicio.Value;
            else
                param.Value = DBNull.Value;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@eveFin", SqlDbType.Time);
            param.Direction = ParameterDirection.Input;
            if (oevento.Eve_HoraFin.HasValue)
                param.Value = oevento.Eve_HoraFin.Value;
            else
                param.Value = DBNull.Value;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        private void cargar_eventos() 
        {
            string competencia = cmbCompetencias.Text;
            dtgwInscripciones.DataSource = lista_EventosCompetencias(competencia);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (Form_AltaCompetencias.comprobarCompetenciaCancelada(cmbCompetencias.Text))
            {
                MessageBox.Show("No se puede inscribir a la competencia, porque esta cancelada");
                return;
            }

            DateTime fec = DateTime.Today;
            int comId = int.Parse(cmbCompetencias.SelectedValue.ToString());
            
            //Validaciones
            if (!Form_AltaCompetencias.comprobar_FInicial(comId, fec)) 
            {
                MessageBox.Show("No se puede inscribir a la competencia, porque ya paso la fecha limite");
                return;
            }

            int atlId = int.Parse(cmbAtletas.SelectedValue.ToString()); 

            if(comprobar_competencia_atleta(comId, atlId))
            {
                MessageBox.Show("El participante ya se encuentra inscripto en la competencia");
                return;
            }


            DialogResult resultado = MessageBox.Show("Deseas Inscribir al participante " + lblInfo.Text + " En la competencia " + cmbCompetencias.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
            {
                Evento oEvento = new Evento();
                oEvento.Com_ID = int.Parse(cmbCompetencias.SelectedValue.ToString());
                oEvento.Atl_ID = int.Parse(cmbAtletas.SelectedValue.ToString());
                oEvento.Eve_Estado = "Inscripto";
                oEvento.Eve_HoraInicio = null;
                oEvento.Eve_HoraFin = null;
                insertar_Evento(oEvento);
                //limpiar();
                cargar_eventos();
            }
        }

        private void cmbAtletas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cmbDni = int.Parse(cmbAtletas.Text);
            lblInfo.Text = ParticipanteCtrl.obtenerNombreCompleto(cmbDni);
        }

        private void cmbCompetencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_eventos();
        }



    }
}
