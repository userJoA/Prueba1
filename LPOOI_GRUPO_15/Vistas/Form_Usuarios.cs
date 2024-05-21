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
            // TODO: esta línea de código carga datos en la tabla 'usersDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.usersDataSet.Usuario);

            load_combo_roles();

        }

        private void load_combo_roles()
        {
            cmbRol_ID.DisplayMember = "Rol_Descripcion";
            cmbRol_ID.ValueMember = "Rol_Codigo";
            cmbRol_ID.DataSource= Usuario.lista_roles();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();
            oUser.Rol_Codigo = (int)cmbRol_ID.SelectedValue;
            oUser.Usu_NombreUsuario = txtUsuario.Text;
            oUser.Usu_Contraseña = txtPassword.Text;
            oUser.Usu_ApellidoNombre= txtNombre.Text + " " + txtApellido.Text;

            Usuario.insertar_Usuario(oUser);
        }

    }
}
