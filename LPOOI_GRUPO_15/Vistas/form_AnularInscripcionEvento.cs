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
    public partial class form_AnularInscripcionEvento : UserControl
    {
        public form_AnularInscripcionEvento()
        {
            InitializeComponent();
        }

        private void btnCerrarAn_Click(object sender, EventArgs e)
        {

            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }
        public static DataTable lista_Eventos_Dni(int dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Consulta_ViewEvento_Filtro_DNI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@dni",SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = dni;
            cmd.Parameters.Add(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static void modificar_evento(int eveId, string estado) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Modificar_Evento_Estado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@eveId", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = eveId;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@eveEstado", SqlDbType.VarChar,30);
            param.Direction = ParameterDirection.Input;
            param.Value = estado;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                errorProviderAnulaciones.SetError(txtDni, "Este campo no puede estar vacio");
                return;
            }
            int dni = int.Parse(txtDni.Text);
            dtgvEventos.DataSource = lista_Eventos_Dni(dni);
            lblInfo.Text = ParticipanteCtrl.obtenerNombreCompleto(dni);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dtgvEventos.CurrentRow != null) 
            {
                string competencia = dtgvEventos.CurrentRow.Cells["Com_Nombre"].Value.ToString();
                DialogResult resultado = MessageBox.Show("Deseas anular la Inscripcion del participante " + lblInfo.Text + " En la competencia " + competencia + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes) 
                {
                    int eveId = int.Parse(dtgvEventos.CurrentRow.Cells["Eve_ID"].Value.ToString());
                    string estado = "Anulado";
                    modificar_evento(eveId, estado);
                    int dni = int.Parse(txtDni.Text);
                    dtgvEventos.DataSource = lista_Eventos_Dni(dni);
                    btnAnular.Visible = false;
                }               
            }
        }

        private void dtgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAnular.Visible = true;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            errorProviderAnulaciones.SetError(txtDni,"");
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }



    }
}
