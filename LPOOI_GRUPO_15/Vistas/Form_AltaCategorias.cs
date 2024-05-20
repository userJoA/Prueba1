using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class Form_AltaCategorias : Form
    {
        Categoria oCategoria;
        public Form_AltaCategorias()
        {
            InitializeComponent();
            cmbNombre.SelectedIndex = 0;
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar() 
        {
            cmbNombre.SelectedIndex = 0;
            txtDescripcion.Clear();
            cmbNombre.Focus();
        }

        public bool validacionDeCamposVacios() 
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(validacionDeCamposVacios())
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado==DialogResult.Yes)
                {
                    oCategoria = new Categoria(cmbNombre.SelectedItem.ToString(), txtDescripcion.Text);
                    oCategoria.ToString();
                    limpiar();
                }
                else { MessageBox.Show("Operación cancelada."); };
            }
            else 
            {
               MessageBox.Show("Debe Completar los campos correctamente.");
            }

        }


    }
}
