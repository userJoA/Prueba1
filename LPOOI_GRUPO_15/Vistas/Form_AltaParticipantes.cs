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
            load_participantes();
            
        }

        private void load_participantes() 
        {
            dtgwListaParticipantes.DataSource = ParticipanteCtrl.lista_Participantes();
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
            dttmFechaNac.Value = dttmFechaNac.MaxDate ;
            txtDireccion.Clear();
            txtEmail.Clear();
            txtNombre.Focus();
            txtID.Clear();
            load_participantes();
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
            if (ParticipanteCtrl.verificar_dni(int.Parse(txtDNI.Text))) 
            {
                errFormAltaParticipante.SetError(txtDNI,"DNI ya registrado");
                return;
            }

            borrarMsjError();
            if (txtID.Text == "")
            {
                if (validacionDeCamposVacios())
                {
                    DialogResult resultado = MessageBox.Show("¿Quiere registrar al participante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        Atleta oAtl = new Atleta();
                        oAtl.Atl_Nombre = txtNombre.Text;
                        oAtl.Atl_Apellido = txtApellido.Text;
                        oAtl.Atl_DNI = Convert.ToInt32(txtDNI.Text);
                        oAtl.Atl_Nacionalidad = cmbNacionalidad.SelectedItem.ToString();
                        oAtl.Atl_Entrenador = txtEntrenador.Text;
                        oAtl.Atl_Genero = cmbGenero.SelectedItem.ToString();
                        oAtl.Atl_Altura = Convert.ToDouble(txtAltura.Text);
                        oAtl.Atl_Peso = Convert.ToDouble(txtPeso.Text);
                        oAtl.Atl_Email = txtEmail.Text;
                        oAtl.Atl_Direccion = txtDireccion.Text;
                        oAtl.Atl_FechaNac = dttmFechaNac.Value;

                        ParticipanteCtrl.save_participante(oAtl);
                        MessageBox.Show("Participante agregado correctamente", "operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarForm();
                    }
                    else
                    {
                        MessageBox.Show("Operacion Cancelada");
                    }
                }
                else { MessageBox.Show("Debe Completar todos los campos para llenar el formulario", " Hay campos del formulario sin llenar", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else 
            {
                MessageBox.Show("El Participante Ya esta esta registrado");
            }
            
            
        }


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

        private void txtBusquedaPorDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            borrarMsjError();
            limpiarForm();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Deseas Modificar a " + dtgwListaParticipantes.CurrentRow.Cells["Nombre"].Value.ToString() +" "+ dtgwListaParticipantes.CurrentRow.Cells["Apellido"].Value.ToString() + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    Atleta oAtl = new Atleta();
                    oAtl.Atl_ID = Convert.ToInt32(txtID.Text);
                    oAtl.Atl_Nombre = txtNombre.Text;
                    oAtl.Atl_Apellido = txtApellido.Text;
                    oAtl.Atl_DNI = Convert.ToInt32(txtDNI.Text);
                    oAtl.Atl_Entrenador = txtEntrenador.Text;
                    oAtl.Atl_Direccion = txtDireccion.Text;
                    oAtl.Atl_Email = txtEmail.Text;
                    oAtl.Atl_Altura = Convert.ToInt32(txtAltura.Text);
                    oAtl.Atl_Peso = Convert.ToInt32(txtPeso.Text);
                    oAtl.Atl_FechaNac = dttmFechaNac.Value;
                    oAtl.Atl_Nacionalidad = cmbNacionalidad.SelectedItem.ToString();
                    oAtl.Atl_Genero = cmbGenero.SelectedItem.ToString();

                    ParticipanteCtrl.modificar_participante(oAtl);

                    limpiarForm();
                }
            }
            else
            {
                
            }
        }

        private void dtgwListaParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgwListaParticipantes.CurrentRow != null)
            {
                int indiceCmbGenero = cmbGenero.FindString(dtgwListaParticipantes.CurrentRow.Cells["Genero"].Value.ToString());
                int indiceCmbNacionalidad = cmbNacionalidad.FindString(dtgwListaParticipantes.CurrentRow.Cells["Nacionalidad"].Value.ToString());
                
                txtNombre.Text=dtgwListaParticipantes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text=dtgwListaParticipantes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDNI.Text=dtgwListaParticipantes.CurrentRow.Cells["DNI"].Value.ToString();
                txtEntrenador.Text=dtgwListaParticipantes.CurrentRow.Cells["Entrenador"].Value.ToString();
                cmbNacionalidad.SelectedIndex = indiceCmbNacionalidad;
                cmbGenero.SelectedIndex = indiceCmbGenero;
                txtAltura.Text=dtgwListaParticipantes.CurrentRow.Cells["Altura"].Value.ToString();
                txtPeso.Text=dtgwListaParticipantes.CurrentRow.Cells["Peso"].Value.ToString();
                txtDireccion.Text=dtgwListaParticipantes.CurrentRow.Cells["Direccion"].Value.ToString();
                txtID.Text=dtgwListaParticipantes.CurrentRow.Cells["ID"].Value.ToString();
                txtEmail.Text = dtgwListaParticipantes.CurrentRow.Cells["Email"].Value.ToString();
                dttmFechaNac.Value = Convert.ToDateTime (dtgwListaParticipantes.CurrentRow.Cells["FechaNac"].Value.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtID.Text!="")
            {
                DialogResult res = MessageBox.Show("Deseas Eliminar a " + dtgwListaParticipantes.CurrentRow.Cells["Nombre"].Value.ToString() + " " + dtgwListaParticipantes.CurrentRow.Cells["Apellido"].Value.ToString() + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(res == DialogResult.Yes)
                {
                    ParticipanteCtrl.eliminar_Usuario(Convert.ToInt32(txtID.Text));
                    load_participantes();
                }
            }
        }


        private void rdbOrdenarPorDNI_CheckedChanged(object sender, EventArgs e)
        {
            dtgwListaParticipantes.DataSource = ParticipanteCtrl.orden_DNI();
        }

        private void rdbOrdenarPorApellido_CheckedChanged(object sender, EventArgs e)
        {
            dtgwListaParticipantes.DataSource = ParticipanteCtrl.orden_Apellido();
        }

        private void rdbSinOrden_CheckedChanged(object sender, EventArgs e)
        {
            load_participantes();
        }

        private void txtBusquedaPorDNI_TextChanged(object sender, EventArgs e)
        {
            if (txtBusquedaPorDNI.Text != "")
            {
                dtgwListaParticipantes.DataSource = ParticipanteCtrl.search_participantes(txtBusquedaPorDNI.Text);

            }
            else
            {
                load_participantes();
            }
        }





    }
}
