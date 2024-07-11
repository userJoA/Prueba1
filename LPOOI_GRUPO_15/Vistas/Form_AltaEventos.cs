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

        private void btnAcreditaciones_Click(object sender, EventArgs e)
        {
            form_AcreditacionEvento fAcreditar = new form_AcreditacionEvento();
            fAcreditar.Dock = DockStyle.Fill;
            this.Controls.Add(fAcreditar);
            fAcreditar.BringToFront();
        }

        public static DataTable filtroEstadoEvento(string estado) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Consulta_ViewEvento_Filtro_Estado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@estado",SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = estado;
            cmd.Parameters.Add(param);

            SqlDataAdapter da = new SqlDataAdapter();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable filtroCompetenciaEvento(string competencia,string estado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Consulta_ViewEvento_Filtro_cAcreditadas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@competencia", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = competencia;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@estado", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = estado;
            cmd.Parameters.Add(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable filtroCompetenciaEventoByOrden(string competencia, string estado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Consulta_ViewEvento_Filtro_cAcreditadasByOrdenTiempo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@competencia", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = competencia;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@estado", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = estado;
            cmd.Parameters.Add(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static int contadorCompetenciasxEstado(string nCompetencia,string estado) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Consulta_ViewEventos_Contador_CompetenciasEstado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@nCompetencia", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = nCompetencia;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@estado", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = estado;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@cantidad", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            param.Value = 0;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            int contador = (int)cmd.Parameters["@cantidad"].Value;
            return contador;
        }

        public static int contadorAtlxCompetencias(string nCompetencia)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Consulta_ViewEvento_Contador_AtlxCompt";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@nCompetencia", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = nCompetencia;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@contador", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            param.Value = 0;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            int contador = (int)cmd.Parameters["@contador"].Value;
            return contador;
        }

        private void btnListaEventos_Click(object sender, EventArgs e)
        {
            if (pnlEventos.Visible == true)
            {
                pnlEventos.Visible = false;
            }
            else 
            {
                pnlEventos.Visible = true;
            }
        }

    }
}
