using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClasesBase
{
    public class Usuario
    {
        public Usuario(string usuario, string password, int? rolID) {
            this.usu_NombreUsuario = usuario;
            this.usu_Contraseña = password;
            this.rol_Codigo = rolID.HasValue ? rolID.Value : 0;
        }

        public Usuario() { }

        private int usu_ID;

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        private string usu_NombreUsuario;

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }
        private string usu_Contraseña;

        public string Usu_Contraseña
        {
            get { return usu_Contraseña; }
            set { usu_Contraseña = value; }
        }
        private string usu_ApellidoNombre;

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }
        private int rol_Codigo;

        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        public void ToString() 
        {
            MessageBox.Show("Usuario: " + this.usu_NombreUsuario + "\n" +
                            "Contraseña: " + this.usu_Contraseña + "\n" +
                            "Nombre y Apellido: " + this.usu_ApellidoNombre + "\n" +
                            "ID: " + this.usu_ID + "\n" +
                            "Rol_Codigo: " + this.rol_Codigo + "\n");
        }
    }
}
