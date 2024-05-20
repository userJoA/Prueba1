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
    public partial class Form_AltaParticipantes : Form
    {
        Atleta oAtletla;
        
        public Form_AltaParticipantes()
        {
            InitializeComponent();
            cmbNacionalidad.SelectedIndex = 0;
            cmbGenero.SelectedIndex = 0;
            
        }

        private bool validacionDeCamposVacios() {
            
            bool validacion=true;
            if (txtNombre.Text == "")
            {
                validacion = false;
                errFormAltaParticipante.SetError(txtNombre, "Debe ingresar un Nombre");
            }


            if (txtApellido.Text == "")
            {
                validacion = false;
                errFormAltaParticipante.SetError(txtApellido, "Debe ingresar un Apellido");
            }


            if (txtDNI.Text == "")
            {
                validacion = false;
                errFormAltaParticipante.SetError(txtDNI, "Debe ingresar el DNI");
            }


            if (cmbNacionalidad.SelectedIndex==0) 
            {
                validacion = false;
                errFormAltaParticipante.SetError(cmbNacionalidad, "Debe Seleccionar una opcion");
            }


            if (txtEntrenador.Text == "")
            {
                validacion = false;
                errFormAltaParticipante.SetError(txtEntrenador, "Debe ingresar el Nombre y Apeliido del Entrenador");
            }


            if (cmbGenero.SelectedIndex == 0)
            {
                validacion = false;
                errFormAltaParticipante.SetError(cmbGenero, "Debe Seleccionar una opcion");
            }


            if (txtAltura.Text == "")
            {
                validacion = false;
                errFormAltaParticipante.SetError(txtAltura, "Debe ingresar la Altura del Participante");
            }


            if (txtPeso.Text == "")
            {
                validacion = false;
                errFormAltaParticipante.SetError(txtPeso, "Debe ingresar el Peso del Participante");
            }

            if (txtDireccion.Text == "")
            {
                validacion = false;
                errFormAltaParticipante.SetError(txtDireccion, "Debe ingresar una direccion");
            }

            if (txtEmail.Text == "")
            {
                validacion = false;
                errFormAltaParticipante.SetError(txtEmail, "Debe ingresar un Email");
            }

            return validacion;
        }

        private void limpiarForm() 
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            cmbNacionalidad.SelectedIndex = 0;
            txtEntrenador.Clear();
            cmbGenero.SelectedIndex = 0;
            txtAltura.Clear();
            txtPeso.Clear();
            //dttmFechaNac.ResetText();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtNombre.Focus();
        }

        private void borrarMsjError() 
        {
            errFormAltaParticipante.SetError(txtNombre, "");
            errFormAltaParticipante.SetError(txtApellido, "");
            errFormAltaParticipante.SetError(txtDNI, "");
            errFormAltaParticipante.SetError(cmbNacionalidad, "");
            errFormAltaParticipante.SetError(txtEntrenador, "");
            errFormAltaParticipante.SetError(cmbGenero, "");
            errFormAltaParticipante.SetError(txtAltura, "");
            errFormAltaParticipante.SetError(txtPeso, "");
            errFormAltaParticipante.SetError(dttmFechaNac, "");
            errFormAltaParticipante.SetError(txtDireccion, "");
            errFormAltaParticipante.SetError(txtEmail, "");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            borrarMsjError();
            if (validacionDeCamposVacios())
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    int d = Convert.ToInt32(txtDNI.Text);
                    double alt = Convert.ToDouble(txtAltura.Text);
                    double pes = Convert.ToDouble(txtPeso.Text);
                    oAtletla = new Atleta(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtDNI.Text), cmbNacionalidad.SelectedItem.ToString(), txtEntrenador.Text, cmbGenero.SelectedItem.ToString(), Convert.ToDouble(txtAltura.Text), Convert.ToDouble(txtPeso.Text), dttmFechaNac.Value, txtDireccion.Text, txtEmail.Text);
                    oAtletla.ToString();
                    limpiarForm(); 
                }
                else
                {
                    MessageBox.Show("Operacion Cancelada");
                }
            }
            else { MessageBox.Show("Debe Completar todos los campos para llenar el formulario", " Hay campos del formulario sin llenar", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        /*private void txtAltura_Validating(object sender, CancelEventArgs e)
        {
            double salida;
            if (!double.TryParse(txtAltura.Text, out salida))
            {
                errFormAltaParticipante.SetError(txtAltura, "Debe ingresar un valor Numerico");
            }
            else 
            {
                errFormAltaParticipante.SetError(txtAltura,"");
            }
        }

        private void txtPeso_Validating(object sender, CancelEventArgs e)
        {
            double salida;
            if (!double.TryParse(txtPeso.Text, out salida))
            {
                errFormAltaParticipante.SetError(txtPeso, "Debe ingresar un valor Numerico");
            }
            else
            {
                errFormAltaParticipante.SetError(txtPeso, "");
            }
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            int salida;
            if (!int.TryParse(txtDNI.Text, out salida))
            {
                errFormAltaParticipante.SetError(txtDNI, "Debe ingresar un valor Numerico");
            }
            else
            {
                errFormAltaParticipante.SetError(txtDNI, "");
            }
        }*/

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

       
    }
}
