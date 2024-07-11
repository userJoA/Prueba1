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
using ClasesBase;

namespace Vistas
{
    public partial class Form_AltaCompetencias : Form
    {
        public Form_AltaCompetencias()
        {
            InitializeComponent();
            cargar_competencias();
            cargar_categorias_disciplinas();
            cmbEstado.SelectedIndex = 0;
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Guardar";
            btnEliminar.Visible = false;
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
            cmbEstado.SelectedIndex = 0;
            dttmFechaInicio.Value = DateTime.Now;
            dttmFechaFin.Value = DateTime.Now;
            dttpHoraFin.Value = DateTime.Now;
            dttpHoraInicio.Value = DateTime.Now;
            txtNombre.Focus();
            cargar_competencias();
        }

        private void cargar_competencias() 
        {
            dtgwCompetencias.DataSource = lista_Competencias();
        }

        Boolean formularioCompleto()
        {
            if (txtDescrpcion.Text != "" && txtNombre.Text != "" && txtOrganizador.Text != "" && txtSponsors.Text != "" && txtUbicacion.Text != "")
                {return true;}
            else { return false; }
        }

        Boolean validacionFecha() {

            if (dttmFechaFin.Value < dttmFechaInicio.Value)
            {
                return false;
            }
            else return true;
        }


        private void cargar_categorias_disciplinas()
        {
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "ID";
            cmbCategoria.DataSource = Form_AltaCategorias.lista_Categorias();

            cmbDisciplina.DisplayMember = "Nombre";
            cmbDisciplina.ValueMember = "ID";
            cmbDisciplina.DataSource = Form_AltaDisciplinas.lista_Disciplinas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(!validacionFecha())
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de finalizacion");
                return;
            }

            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("No puede dejar el campo nombre sin completar");
                return;
            }

            if (btnGuardar.Text == "Actualizar")
            {
                actualizar_datos();
                btnGuardar.Text = "Guardar";
                btnEliminar.Visible = false;   
                limpiar();           
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseas Ingresar un nueva competencia?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes) 
            {
                DateTime fechaInicio = dttmFechaInicio.Value.Date;
                DateTime HoraInicio = dttpHoraInicio.Value;
                DateTime FechaHoraInicio = fechaInicio.Add(HoraInicio.TimeOfDay);

                DateTime fechaFin = dttmFechaFin.Value.Date;
                DateTime HoraFin = dttpHoraFin.Value;
                DateTime FechaHoraFin= fechaFin.Add(HoraFin.TimeOfDay);


                Competencia oCompetencia;
                oCompetencia = new Competencia(txtNombre.Text, txtDescrpcion.Text, FechaHoraInicio, FechaHoraFin, cmbEstado.SelectedItem.ToString(), txtOrganizador.Text, txtSponsors.Text, txtUbicacion.Text, (int)cmbCategoria.SelectedValue, (int)cmbDisciplina.SelectedValue);
                insertar_competencias(oCompetencia);
                limpiar();
            }

        }


        private void actualizar_datos()
        {
            DialogResult resultado = MessageBox.Show("Deseas Modificar los datos de la competencia" + dtgwCompetencias.CurrentRow.Cells["Nombre"].Value.ToString(), "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
            {
                DateTime fechaInicio = dttmFechaInicio.Value.Date;
                DateTime HoraInicio = dttpHoraInicio.Value;
                DateTime FechaHoraInicio = fechaInicio.Add(HoraInicio.TimeOfDay);

                DateTime fechaFin = dttmFechaFin.Value.Date;
                DateTime HoraFin = dttpHoraFin.Value;
                DateTime FechaHoraFin = fechaFin.Add(HoraFin.TimeOfDay);

                Competencia oCompetencia;
                oCompetencia = new Competencia(txtNombre.Text, txtDescrpcion.Text, FechaHoraInicio, FechaHoraFin, cmbEstado.SelectedItem.ToString(), txtOrganizador.Text, txtSponsors.Text, txtUbicacion.Text, (int)cmbCategoria.SelectedValue, (int)cmbDisciplina.SelectedValue);
                oCompetencia.Com_ID = int.Parse(dtgwCompetencias.CurrentRow.Cells["ID"].Value.ToString());
                modificar_competencia(oCompetencia);
                limpiar();
            }
        }

        public static void insertar_competencias(Competencia ocompetencia) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insertar_Competencia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@nombre", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_Nombre;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@descripcion", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_Descripcion;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@fechaIni", SqlDbType.DateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_FechaInicio;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@fechaFin", SqlDbType.DateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_FechaFin;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@estado", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_Estado;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@organizador", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_Organizador;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@ubicacion", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_Ubicacion;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@sponsor", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_Sponsors;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@catId", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Cat_ID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@disId", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Dis_ID;
            cmd.Parameters.Add(param);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            
        }


        private void modificar_competencia(Competencia ocompetencia)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Modificar_Competencia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@nombre", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_Nombre;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@descripcion", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_Descripcion;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@fechaIni", SqlDbType.DateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_FechaInicio;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@fechaFin", SqlDbType.DateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_FechaFin;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@estado", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_Estado;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@organizador", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_Organizador;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@ubicacion", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_Ubicacion;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@sponsor", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_Sponsors;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@catId", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Cat_ID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@disId", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Dis_ID;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@comid", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = ocompetencia.Com_ID;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        private void eliminar_Competencia(int competenciaid)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Eliminar_Competencia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@comid", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = competenciaid;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable lista_Competencias()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Listar_Competencias";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private bool consulta_competencias(string nombre)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Consulta_Competencias_Nombre";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@nombre", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = nombre;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@existe", SqlDbType.Bit);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            bool existe = Convert.ToBoolean(cmd.Parameters["@existe"].Value);
            return existe;

        }

        public static bool comprobarCompetenciaCancelada(string nCompetencia) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Consulta_Competencia_Estado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@competencia", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = nCompetencia;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@existe", SqlDbType.Bit);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            bool existe = Convert.ToBoolean(cmd.Parameters["@existe"].Value);
            return existe;
        }

        public static bool comprobar_FInicial(int comId, DateTime fecha) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Consulta_Competencia_ComprobarFechaInicial";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@comId", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = comId;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@fecha", SqlDbType.DateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = fecha;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@verificacion", SqlDbType.Bit);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            bool verificar = Convert.ToBoolean(cmd.Parameters["@verificacion"].Value);
            return verificar;

        }

        private void dtgwCompetencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgwCompetencias.CurrentRow != null)
            {
                btnGuardar.Text = "Actualizar";
                btnEliminar.Visible = true;
                DateTime fechaHoraFin = Convert.ToDateTime(dtgwCompetencias.CurrentRow.Cells["FFin"].Value.ToString());
                DateTime fechaHoraInicio = Convert.ToDateTime(dtgwCompetencias.CurrentRow.Cells["FInicio"].Value.ToString());
                txtNombre.Text = dtgwCompetencias.CurrentRow.Cells["Nombre"].Value.ToString();
                txtOrganizador.Text = dtgwCompetencias.CurrentRow.Cells["Organizador"].Value.ToString();
                txtUbicacion.Text = dtgwCompetencias.CurrentRow.Cells["Ubicacion"].Value.ToString();
                dttmFechaInicio.Value = fechaHoraInicio.Date;
                dttpHoraInicio.Value = DateTime.Today.Add(fechaHoraInicio.TimeOfDay);
                //dttmFechaFin.Value = Convert.ToDateTime(dtgwCompetencias.CurrentRow.Cells["FFin"].Value.ToString());
                dttmFechaFin.Value = fechaHoraFin.Date;
                dttpHoraFin.Value = DateTime.Today.Add(fechaHoraFin.TimeOfDay);
                cmbEstado.Text = dtgwCompetencias.CurrentRow.Cells["Estado"].Value.ToString();
                txtSponsors.Text = dtgwCompetencias.CurrentRow.Cells["Sponsors"].Value.ToString();
                cmbCategoria.SelectedValue = dtgwCompetencias.CurrentRow.Cells["Cat_id"].Value.ToString();
                cmbDisciplina.SelectedValue = dtgwCompetencias.CurrentRow.Cells["Dis_id"].Value.ToString();
                txtDescrpcion.Text = dtgwCompetencias.CurrentRow.Cells["Descripcion"].Value.ToString();
            } 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgwCompetencias.CurrentRow.Cells["Nombre"].Value.ToString() == txtNombre.Text && consulta_competencias(txtNombre.Text))
            {
                DialogResult resultado = MessageBox.Show("Deseas Eliminar la disciplina " + dtgwCompetencias.CurrentRow.Cells["Nombre"].Value.ToString() + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    eliminar_Competencia(int.Parse(dtgwCompetencias.CurrentRow.Cells["ID"].Value.ToString()));
                    //
                    btnGuardar.Text = "Guardar";
                    btnEliminar.Visible = false;
                    limpiar();
                    //
                    MessageBox.Show("Competencia Eliminada");
                }

            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
