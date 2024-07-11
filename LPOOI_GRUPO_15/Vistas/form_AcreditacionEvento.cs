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
    public partial class form_AcreditacionEvento : UserControl
    {
        public form_AcreditacionEvento()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }



        public static DataTable lista_Eventos_filtro(int dni,string estado) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Consulta_ViewEvento_Filtro_DNI_Estado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@dni", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = dni;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@estado",SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = estado;
            cmd.Parameters.Add(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool verificacion_evento_dni(int dni) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Consulta_ViewEvento_Verficacion_AtlDNI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@dni", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = dni;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@cantidad", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            param.Value = 0;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            int contador = (int)cmd.Parameters["@cantidad"].Value;
            return contador>0;
        }

        private void cargar_eventos() 
        {
            int dni = int.Parse(txtDNI.Text);
            if(!verificacion_evento_dni(dni))
            {
                MessageBox.Show("No hay regsitros con el dni ingresado");
                return;
            }
            dtvEventos.DataSource = form_AnularInscripcionEvento.lista_Eventos_Dni(dni);
        }

        private void cargar_eventos_inscriptos() 
        {
            int dni = int.Parse(txtDNI.Text);
            if (!verificacion_evento_dni(dni))
            {
                MessageBox.Show("No hay regsitros con el dni ingresado");
                return;
            }
            dtvEventos.DataSource = lista_Eventos_filtro(dni, "Inscripto");
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                errorProviderEventoAcreditacion.SetError(txtDNI, "Este campo no puede estar vacio");
                return;
            }
            cargar_eventos_inscriptos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dtvEventos.CurrentRow != null)
            {
                int eveId = int.Parse(dtvEventos.CurrentRow.Cells["Eve_ID"].Value.ToString());
                string estado = "Acreditado";
                form_AnularInscripcionEvento.modificar_evento(eveId, estado);
                int dni = int.Parse(txtDNI.Text);
                cargar_eventos();
                btnActualizar.Visible = false;

            }
        }

        private void dtvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvEventos.CurrentRow != null) 
            {
                btnActualizar.Visible = true;
            }
        }

        private void btnBuscarEventosT_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDNI.Text))
            {
                errorProviderEventoAcreditacion.SetError(txtDNI,"Este campo no puede estar vacio");
                return;
            }
            cargar_eventos();
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            errorProviderEventoAcreditacion.SetError(txtDNI,"");
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }




    }
}
