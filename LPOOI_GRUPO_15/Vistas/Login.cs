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
    public partial class fmrlogin : Form
    {

        public bool logginSuccess { get; private set; }

        Roles oAdministrador = new Roles(1, "administrador");
        Roles oVendedor = new Roles(2, "vendedor");
        Roles oOperador = new Roles(3, "operador");

        Usuario oUserAdmin = new Usuario("admin", "admin", 1);
        Usuario oUserVendedor = new Usuario("vendedor", "vendedor", 2);
        Usuario oUserOperador = new Usuario("operador", "operador", 3);
        List<Usuario> listaUsuarios = new List<Usuario>();
        

        public void cargarUsuarios() 
        {
            listaUsuarios.AddRange(new List<Usuario> { oUserAdmin, oUserOperador, oUserVendedor });
        }

        public fmrlogin()
        {
            InitializeComponent();
            cargarUsuarios();
            logginSuccess = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool validacionDeCamposVacios() 
        {
            bool esValido=true;
            if(txtUsuario.Text=="")
            {
                esValido=false;
                errpFormularioLogin.SetError(txtUsuario,"Debe Ingresar un usuario");
            }
            else
            {
                errpFormularioLogin.SetError(txtUsuario,"");
            }

            if(txtPassword.Text=="")
            {
                esValido=false;
                errpFormularioLogin.SetError(txtPassword,"Debe Ingresar un password");
            }
            else
            {
                errpFormularioLogin.SetError(txtPassword,"");
            }
            return esValido;
        }

        public void limpiar() 
        {
            txtPassword.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(validacionDeCamposVacios())
            {
                bool usuarioEncontrado = false;
                foreach(var item in listaUsuarios)
                {
                    if (item.Usu_NombreUsuario.Equals(txtUsuario.Text) && item.Usu_Contraseña.Equals(txtPassword.Text))
                    {
                        usuarioEncontrado = true;
                    }
                }
                if (usuarioEncontrado)
                {
                    this.logginSuccess = true;
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("No se Encontro al usuario, compruebe el usuario y el password.");
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Debe completar el formulario.");
            }

            
        }
    }
}
