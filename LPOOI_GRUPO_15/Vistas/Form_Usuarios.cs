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
    public partial class Form_Usuarios : Form
    {

        public Form_Usuarios()
        {
            InitializeComponent();
        }

        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            load_usuarios();
            load_combo_roles();
        }

        private void load_usuarios() 
        {
            // TODO: esta línea de código carga datos en la tabla 'usersDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            //this.usuarioTableAdapter.Fill(this.usersDataSet.Usuario);
            dgwUsuarios.DataSource = UsuarioCtrl.lista_usuarios();
        }

        private void load_combo_roles()
        {
            cmbRol_ID.DisplayMember = "Rol_Descripcion";
            cmbRol_ID.ValueMember = "Rol_Codigo";
            cmbRol_ID.DataSource = UsuarioCtrl.lista_roles();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (!this.validar_formulario_campos())
            {
                MessageBox.Show("Los campos del formulario no deben estar vacios");
                return;
            }
            
            if (txtID.Text == "")
            {
                Usuario oUser = new Usuario();
                oUser.Rol_Codigo = (int)cmbRol_ID.SelectedValue;
                oUser.Usu_NombreUsuario = txtUsuario.Text;
                oUser.Usu_Contraseña = txtPassword.Text;
                oUser.Usu_ApellidoNombre = txtNombre.Text + " " + txtApellido.Text;

                UsuarioCtrl.insertar_Usuario(oUser);
                limpiar();
            }
            else
            {
                MessageBox.Show("EL usuario ya esta guardado", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPattern.Text != "")
            {
                dgwUsuarios.DataSource = UsuarioCtrl.search_usuarios(txtPattern.Text);

            }
            else 
            {
                load_usuarios();
            }
           
        }

        private bool validar_formulario_campos()
        {
            bool validacion = true;
            if (txtNombre.Text == "")
            {
                validacion = false;
                errpFormularioUsuario.SetError(txtNombre, "Debe ingresar un Nombre");
            }

            if (txtApellido.Text == "")
            {
                validacion = false;
                errpFormularioUsuario.SetError(txtApellido, "Debe ingresar un Apellido");
            }

            if (txtUsuario.Text == "")
            {
                validacion = false;
                errpFormularioUsuario.SetError(txtUsuario, "Debe ingresar un Usuario");
            }

            if (txtPassword.Text == "")
            {
                validacion = false;
                errpFormularioUsuario.SetError(txtPassword, "Debe ingresar una contraseña");
            }

            return validacion;
        }

        private void limpiar() 
        {
            txtID.Text = "";
            txtUsuario.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtPassword.Text = "";
            cmbRol_ID.Refresh();
            txtUsuario.Focus();
            load_usuarios();
        }


       private void txtPattern_TextChanged(object sender, EventArgs e)
        {
            if (txtPattern.Text != "")
            {
                dgwUsuarios.DataSource = UsuarioCtrl.search_usuarios(txtPattern.Text);

            }
            else
            {
                load_usuarios();
            }
        }

       private void btnModificar_Click(object sender, EventArgs e)
       {
           if(!this.validar_formulario_campos())
           {
               MessageBox.Show("Los campos del formulario no deben estar vacios");
               return;
           }
           
           if(txtID.Text != "")
           {
               DialogResult resultado = MessageBox.Show("Deseas Modificar a " + dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString() + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
               if (resultado == DialogResult.Yes) 
               {
                   Usuario oUser = new Usuario();
                   oUser.Rol_Codigo = (int)cmbRol_ID.SelectedValue;
                   oUser.Usu_NombreUsuario = txtUsuario.Text;
                   oUser.Usu_Contraseña = txtPassword.Text;
                   oUser.Usu_ApellidoNombre = txtNombre.Text + " " + txtApellido.Text;
                   oUser.Usu_ID = int.Parse(txtID.Text);

                   UsuarioCtrl.modificar_Usuario(oUser);
                   load_usuarios();
               }
           }
       }


       private void btnNuevo_Click(object sender, EventArgs e)
       {
           limpiar();
       }

       private void btnEliminar_Click(object sender, EventArgs e)
       {
           if(txtID.Text!="")
           {
               DialogResult resultado = MessageBox.Show("Deseas Eliminar a " + dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString() + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
               if(resultado==DialogResult.Yes)
               {
                    UsuarioCtrl.eliminar_Usuario(int.Parse(txtID.Text));
                    limpiar();
                    MessageBox.Show("Usuario Eliminado");
               }
               
           }
       }

       private void dgwUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           if (dgwUsuarios.CurrentRow != null)
           {
               cmbRol_ID.SelectedValue = dgwUsuarios.CurrentRow.Cells["Rol_Codigo"].Value.ToString();

               txtUsuario.Text = dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
               txtPassword.Text = dgwUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
               txtID.Text = dgwUsuarios.CurrentRow.Cells["ID"].Value.ToString();

               var auxNombreYApellido = dgwUsuarios.CurrentRow.Cells["Nombre Y Apellido"].Value.ToString();
               string[] partes = auxNombreYApellido.Split(' ');
               var nombre = partes[0];
               var apellido = partes[1];
               txtNombre.Text = nombre;
               txtApellido.Text = apellido;
           }
       }

       private void btnCancelar_Click(object sender, EventArgs e)
       {
           this.Close();
       }



    }
}
