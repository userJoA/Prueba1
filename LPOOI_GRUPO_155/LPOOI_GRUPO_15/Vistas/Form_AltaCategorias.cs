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
    public partial class Form_AltaCategorias : Form
    {
        
        public Form_AltaCategorias()
        {
            InitializeComponent();
            cargar_Categorias();
            //cmbNombre.SelectedIndex = 0;
        }

        /*private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorSeleccionado = cmbNombre.SelectedItem.ToString();
            switch(valorSeleccionado){
                    case "M35": txtDescripcion.Text = "Hombres de 35 a 39 años";
                    break;
                    case "U23": txtDescripcion.Text = "Sub 23 Mixto";
                    break;
                    case "F35": txtDescripcion.Text = "Mujeres de 35 a 39 años";
                    break;
                    default: Console.Write("Error");
                    break;
            }
        }
        */
        private void insertar_Categoria(Categoria ocategoria) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insertar_Categoria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@Nombre", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocategoria.Cat_Nombre;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@Descripcion", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocategoria.Cat_Descripcion;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        private void modificar_Categoria(Categoria ocategoria)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Modificar_Categoria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@Nombre", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocategoria.Cat_Nombre;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@Descripcion", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = ocategoria.Cat_Descripcion;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@catId", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = ocategoria.Cat_ID;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        private void eliminar_Categoria(int categoriaid)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Eliminar_Categoria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@catid", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = categoriaid;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable lista_Categorias()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Listar_Categorias";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private bool consulta_categorias(string nombre) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Consulta_Categorias_Nombre";
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

        private void cargar_Categorias() 
        {
            dtgwCategorias.DataSource = lista_Categorias(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar() 
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
            cargar_Categorias();
        }

        /*public bool validacionDeCamposVacios() 
        {
            bool esValido = true;
            if(cmbNombre.SelectedIndex==0)
            {
                esValido = false;
                errpFormularioAltaCategoria.SetError(cmbNombre,"Debe Seleccionar una Opcion.");
            }
            else
            {
                errpFormularioAltaCategoria.SetError(cmbNombre, "");
            }
            return esValido;
        }
        */

        private void actualizar_datos() 
        {

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("No puede dejar el campo NOMBRE vacio");
                return;
            }

            if (dtgwCategorias.CurrentRow.Cells["Nombre"].Value.ToString() != txtNombre.Text && consulta_categorias(txtNombre.Text))
            {
                errpFormularioAltaCategoria.SetError(txtNombre,"el nombre ingresado ya existe");
                MessageBox.Show("El nombre ya existe");
                return;
            }

            Categoria oCategoria;
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                oCategoria = new Categoria(txtNombre.Text, txtDescripcion.Text);
                oCategoria.Cat_ID = int.Parse(dtgwCategorias.CurrentRow.Cells["ID"].Value.ToString());
                modificar_Categoria(oCategoria);
                limpiar();
            }
            else { MessageBox.Show("Operación cancelada."); };

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(btnGuardar.Text=="Actualizar")
            {
                actualizar_datos();
                btnGuardar.Text = "Guardar";
                btnEliminar.Visible = false;
                return;
            }
      
            if (consulta_categorias(txtNombre.Text))
            {
                MessageBox.Show("El nombre ya existe.");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe completar los datos del formulario correctamente.");
                return;
            }

            Categoria oCategoria;
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado==DialogResult.Yes)
                {
                    oCategoria = new Categoria(txtNombre.Text,txtDescripcion.Text);
                    insertar_Categoria(oCategoria);
                    limpiar();
                }
            else { MessageBox.Show("Operación cancelada."); };
        }



        private void dtgwCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgwCategorias.CurrentRow != null)
            {
                txtNombre.Text = dtgwCategorias.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dtgwCategorias.CurrentRow.Cells["Descripcion"].Value.ToString();
                btnGuardar.Text = "Actualizar";
                btnEliminar.Visible = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            btnGuardar.Text = "Guardar";
            btnEliminar.Visible=false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgwCategorias.CurrentRow.Cells["Nombre"].Value.ToString() == txtNombre.Text && consulta_categorias(txtNombre.Text) )
            {
                DialogResult resultado = MessageBox.Show("Deseas Eliminar la disciplina " + dtgwCategorias.CurrentRow.Cells["Nombre"].Value.ToString() + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    eliminar_Categoria(int.Parse(dtgwCategorias.CurrentRow.Cells["ID"].Value.ToString()));
                    limpiar();
                    btnGuardar.Text = "Guardar";
                    MessageBox.Show("Categoria Eliminada");
                }

            }
        }


    }
}
