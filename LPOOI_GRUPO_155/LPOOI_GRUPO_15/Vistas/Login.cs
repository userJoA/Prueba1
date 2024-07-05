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
        public Usuario oUser { get; private set; }

        public bool logginSuccess { get; private set; }

        
        public fmrlogin()
        {
            InitializeComponent();
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
              
                if (UsuarioCtrl.verificar_Usuario_Contraseña(txtUsuario.Text,txtPassword.Text))
                {
                    oUser = UsuarioCtrl.obtenerUsuario(txtUsuario.Text,txtPassword.Text);
                    this.logginSuccess = true;
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("no se encontro al usuario ingresado, Compruebe el nombre de usuario y el password.");
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
