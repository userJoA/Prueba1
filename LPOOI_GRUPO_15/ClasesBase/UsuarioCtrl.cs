using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class UsuarioCtrl
    {


        public static bool verificar_Usuario_Contraseña(string usuario, string password) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
            
         
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM Usuario WHERE Usu_NombreUsuario = @user AND Usu_Contraseña = @pass";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@user", usuario);
            cmd.Parameters.AddWithValue("@pass", password);

            cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            cnn.Close();

            return count > 0;

        }

        public static Usuario obtenerUsuario(string usuario, string password)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Usu_ID, Usu_NombreUsuario, Usu_Contraseña, Usu_ApellidoNombre, Rol_Codigo FROM Usuario WHERE (Usu_NombreUsuario LIKE @user) AND (Usu_Contraseña LIKE @pass)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@user", usuario);
            cmd.Parameters.AddWithValue("@pass", password);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                Usuario oUsu = new Usuario();
                oUsu.Usu_ID = (int)row["Usu_ID"];
                oUsu.Usu_NombreUsuario = row["Usu_NombreUsuario"].ToString();
                oUsu.Usu_Contraseña = row["Usu_Contraseña"].ToString();
                oUsu.Usu_ApellidoNombre = row["Usu_ApellidoNombre"].ToString();
                oUsu.Rol_Codigo = (int)row["Rol_Codigo"];

                return oUsu;
            }
            else
            {
                return null; 
            }
        }

        public static DataTable lista_roles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void insertar_Usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(Usu_NombreUsuario,Usu_Contraseña,Usu_ApellidoNombre,Rol_Codigo) values(@user,@pass,@nya,@rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@user", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@nya", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void eliminar_Usuario(int usuarioId)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuario WHERE Usu_Id = @usuarioId";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usuarioId", usuarioId);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static DataTable lista_usuarios() {
        SqlConnection cnn = new SqlConnection (ClasesBase.Properties.Settings.Default.comdepConnectionString);
        
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT ";
        cmd.CommandText += " Usu_ID as 'ID', ";
        cmd.CommandText += " Rol_Descripcion as 'Rol', ";
        cmd.CommandText += " Usu_NombreUsuario as 'Usuario', ";
        cmd.CommandText += " Usu_Contraseña as 'Contraseña', ";
        cmd.CommandText += " Usu_ApellidoNombre as 'Nombre Y Apellido', ";
        cmd.CommandText += " U.Rol_Codigo ";
        cmd.CommandText += " FROM Usuario as U";
        cmd.CommandText += " LEFT JOIN Roles as R ON (R.Rol_Codigo=U.Rol_Codigo)";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cnn;
        
        // Ejecuta la consulta
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        
        // Llena los datos de la consulta en el DataTable
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
}

        public static DataTable search_usuarios(string sPattern) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Consulta_Usuarios_Nombre";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@Nombre", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = sPattern;
            cmd.Parameters.Add(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                cnn.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }

            return dt;
        }

        public static void modificar_Usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario SET Usu_NombreUsuario = @user, Usu_Contraseña = @pass, Usu_ApellidoNombre = @nya, Rol_Codigo = @rol WHERE Usu_Id = @usuarioId";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@user", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@nya", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@usuarioId", user.Usu_ID); 

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
