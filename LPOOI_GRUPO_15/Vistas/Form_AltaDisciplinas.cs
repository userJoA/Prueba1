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
    public partial class Form_AltaDisciplinas : Form
    {
        Disciplina oDisciplina;
        public Form_AltaDisciplinas()
        {
            InitializeComponent();
            cmbNombre.SelectedIndex = 0;
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

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    oDisciplina = new Disciplina(cmbNombre.SelectedItem.ToString(), txtDescripcion.Text);
                    oDisciplina.ToString();
                    limpiar();
                }
                else { MessageBox.Show("Operación cancelada."); };
            }
            else { MessageBox.Show("Debe completar los datos del formulario correctamente."); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        void limpiar() {     
            cmbNombre.SelectedIndex = 0;
            txtDescripcion.Clear();
            cmbNombre.Focus();
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


        
    }
}
