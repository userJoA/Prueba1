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
        public Form_AltaDisciplinas()
        {
            InitializeComponent();
            //cmbNombre.SelectedIndex = 0;
            cargar_Disciplinas();
        }

        public bool validacionDeCamposVacios() 
        {
            bool esValido=true;
            if (txtNombre.Text=="")
            {
                esValido = false;
                errpFormularioAltaDisciplna.SetError(txtNombre, "Debe Seleccionar una Opcion");
            }
            else
            {
                errpFormularioAltaDisciplna.SetError(txtNombre, "");
            }

            return esValido;
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


        public static DataTable lista_Disciplinas() 
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

            param = new SqlParameter("@disId", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = odisciplina.Dis_ID;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        
        }

        private void eliminar_Disciplina(int disciplinaid) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Eliminar_Disciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@disid", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = disciplinaid;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        private bool consulta_nombre(string nombre)
        {   
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Consulta_Disciplina_Nombre";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@nombre",SqlDbType.VarChar);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        void limpiar() {     
            txtNombre.Text = "";
            txtDescripcion.Clear();
            txtNombre.Focus();
            cargar_Disciplinas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
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
        }*/

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text == "Actualizar") 
            {
                actualizar();
                btnEliminar.Visible = false;
                btnGuardar.Text = "Guardar";
                return;
            }

            if (consulta_nombre(txtNombre.Text))
            {
                MessageBox.Show("El nombre ya existe.");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe completar los datos del formulario correctamente.");
                return;
            }

            Disciplina oDisciplina;
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                {
                    oDisciplina = new Disciplina(txtNombre.Text, txtDescripcion.Text);
                    insertar_Disciplina(oDisciplina);
                    limpiar();
                }
            else { MessageBox.Show("Operación cancelada."); };
        }

        private void actualizar() 
        {

            if (!consulta_nombre(txtNombre.Text))
            {
                MessageBox.Show("No existe la disciplina ingresada");
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe completar los datos del formulario correctamente.");
                return;
            }

            Disciplina oDisciplina;
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                oDisciplina = new Disciplina(txtNombre.Text, txtDescripcion.Text);
                oDisciplina.Dis_ID=int.Parse(dtgwDisciplina.CurrentRow.Cells["ID"].Value.ToString());
                modificar_disciplina(oDisciplina);
                limpiar();
            }
            else { MessageBox.Show("Operación cancelada."); };
        
        }

        private void dtgwDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgwDisciplina.CurrentRow != null) 
            {
                txtNombre.Text = dtgwDisciplina.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dtgwDisciplina.CurrentRow.Cells["Descripcion"].Value.ToString();
                btnGuardar.Text = "Actualizar";
                btnEliminar.Visible = true;
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            limpiar();
            btnEliminar.Visible = false;
            btnGuardar.Text = "Guardar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (consulta_nombre(txtNombre.Text))
            {
                DialogResult resultado = MessageBox.Show("Deseas Eliminar la disciplina " + dtgwDisciplina.CurrentRow.Cells["Nombre"].Value.ToString() + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    eliminar_Disciplina(int.Parse(dtgwDisciplina.CurrentRow.Cells["ID"].Value.ToString()));
                    limpiar();
                    btnGuardar.Text = "Guardar";
                    MessageBox.Show("Disciplina Eliminada");
                }

            }
        }


  }
        
}

