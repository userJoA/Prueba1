using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Data.SqlClient;
using System.Data;

namespace Vistas
{
    public partial class Form_AltaDisciplinas : Form
    {
        private bool actualizar = false;
        
        public Form_AltaDisciplinas()
        {
            InitializeComponent();
            cmbNombre.SelectedIndex = 0;
            cargar_Disciplinas();
        }

        public bool validacionDeCamposVacios() 
        {
            bool esValido=true;
            if (cmbNombre.SelectedIndex == 0)
            {
                esValido = false;
                errpFormularioAltaDisciplna.SetError(cmbNombre, "Debe Seleccionar una Opcion");
            }
            else
            {
                errpFormularioAltaDisciplna.SetError(cmbNombre, "");
            }

            return esValido;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validacionDeCamposVacios())
            {
                Disciplina oDisciplina;
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    oDisciplina = new Disciplina(cmbNombre.SelectedItem.ToString(), txtDescripcion.Text);
                    insertar_Disciplina(oDisciplina);
                    limpiar();
                }
                else { MessageBox.Show("Operación cancelada."); };
            }
            else { MessageBox.Show("Debe completar los datos del formulario correctamente."); }
        }

        private void insertar_Disciplina(Disciplina odisciplina) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insertar_Disciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@nombre",SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = odisciplina.Dis_Nombre;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@descripcion", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = odisciplina.Dis_Descripcion;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        private DataTable lista_Disciplinas() 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Listar_Disciplinas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void cargar_Disciplinas()
        {
            dtgwDisciplina.DataSource = lista_Disciplinas();
        }

        private void modificar_disciplina(Disciplina odisciplina) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Modificar_Disciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@nombre", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = odisciplina.Dis_Nombre;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@descripcion", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = odisciplina.Dis_Descripcion;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        
        }

        private void eliminar_Disciplina() 
        { 
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        void limpiar() {     
            cmbNombre.Text = "";
            txtDescripcion.Clear();
            cmbNombre.Focus();
            cargar_Disciplinas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorSeleccionado = cmbNombre.SelectedItem.ToString();
            switch (valorSeleccionado)
            {
                case "Atletismo": txtDescripcion.Text = "Carrera de velocidad, Carrera de medio fondo, Carrera de fondo, Carrera de valla, Marcha, Etc";
                    break;
                case "Natacion": txtDescripcion.Text = "Libre 50m 100m etc. Espalda 100m 200m. Etc";
                    break;
                case "Ciclismo": txtDescripcion.Text = "Ciclismo en carretera, Ciclismo en pista, Ciclismo de montaña.";
                    break;
                default: Console.Write("Error");
                    break;
            }
        }



        private void dtgwDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgwDisciplina.CurrentCell != null) 
            {
                cmbNombre.Text = dtgwDisciplina.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dtgwDisciplina.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
        }


        
    }
}
