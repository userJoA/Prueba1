using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ClasesBase;
namespace ClasesBase
{
    public class ParticipanteCtrl
    {

        public static DataTable lista_Participantes() 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Listar_Atletas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void save_participante(Atleta oAtl) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Atleta(Atl_Nombre,Atl_Apellido,Atl_DNI,Atl_Nacionalidad,Atl_Entrenador,Atl_Genero, Atl_Altura,Atl_Peso,Atl_FechaNac,Atl_Dirección,Atl_Email) values(@nom,@ape,@dni,@nac,@entrenador,@gen,@alt,@peso,@fnac,@dir,@email)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nom", oAtl.Atl_Nombre);
            cmd.Parameters.AddWithValue("@ape", oAtl.Atl_Apellido);
            cmd.Parameters.AddWithValue("@dni", oAtl.Atl_DNI);
            cmd.Parameters.AddWithValue("@nac", oAtl.Atl_Nacionalidad);
            cmd.Parameters.AddWithValue("@entrenador", oAtl.Atl_Entrenador);
            cmd.Parameters.AddWithValue("@gen", oAtl.Atl_Genero);
            cmd.Parameters.AddWithValue("@alt", oAtl.Atl_Altura);
            cmd.Parameters.AddWithValue("@peso", oAtl.Atl_Peso);
            cmd.Parameters.AddWithValue("@fnac", oAtl.Atl_FechaNac);
            cmd.Parameters.AddWithValue("@dir", oAtl.Atl_Direccion);
            cmd.Parameters.AddWithValue("@email", oAtl.Atl_Email);
    

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable orden_DNI() 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Consulta_Atletas_DNI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

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

        public static DataTable orden_Apellido()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Consulta_Atletas_Apellido";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

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

        public static DataTable search_participantes(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Atl_ID as 'ID', ";
            cmd.CommandText += " Atl_Nombre as 'Nombre', ";
            cmd.CommandText += " Atl_Apellido as 'Apellido', ";
            cmd.CommandText += " Atl_DNI as 'DNI', ";
            cmd.CommandText += " Atl_Nacionalidad as 'Nacionalidad', ";
            cmd.CommandText += " Atl_Entrenador as 'Entrenador', ";
            cmd.CommandText += " Atl_Genero as 'Genero', ";
            cmd.CommandText += " Atl_Altura as 'Altura', ";
            cmd.CommandText += " Atl_Peso as 'Peso', ";
            cmd.CommandText += " Atl_FechaNac as 'FechaNac', ";
            cmd.CommandText += " Atl_Dirección as 'Direccion', ";
            cmd.CommandText += " Atl_Email as 'Email' ";
            cmd.CommandText += " FROM Atleta ";
            cmd.CommandText += " WHERE";
            cmd.CommandText += " Atl_DNI LIKE @pattern";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

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

        public static void modificar_participante(Atleta oAtl)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);
           
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Atleta SET Atl_Nombre = @nom, Atl_Apellido = @ape, Atl_DNI = @dni, Atl_Nacionalidad = @nac, Atl_Entrenador = @entrenador, Atl_Genero = @gen, Atl_Altura = @alt, Atl_Peso = @peso, Atl_FechaNac = @fnac, Atl_Dirección = @dir, Atl_Email = @email WHERE Atl_ID = @P_ID";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nom", oAtl.Atl_Nombre);
            cmd.Parameters.AddWithValue("@ape", oAtl.Atl_Apellido);
            cmd.Parameters.AddWithValue("@dni", oAtl.Atl_DNI);
            cmd.Parameters.AddWithValue("@nac", oAtl.Atl_Nacionalidad);
            cmd.Parameters.AddWithValue("@entrenador", oAtl.Atl_Entrenador);
            cmd.Parameters.AddWithValue("@gen", oAtl.Atl_Genero);
            cmd.Parameters.AddWithValue("@alt", oAtl.Atl_Altura);
            cmd.Parameters.AddWithValue("@peso", oAtl.Atl_Peso);
            cmd.Parameters.AddWithValue("@fnac", oAtl.Atl_FechaNac);
            cmd.Parameters.AddWithValue("@dir", oAtl.Atl_Direccion);
            cmd.Parameters.AddWithValue("@email", oAtl.Atl_Email);
            cmd.Parameters.AddWithValue("@P_ID", oAtl.Atl_ID);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static void eliminar_Usuario(int pid)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Atleta WHERE Atl_ID = @pid";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pid", pid);

      
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static string obtenerNombreCompleto(int dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Consulta_Atletas_DNI_Busqueda";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@dni", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = dni;
            cmd.Parameters.Add(param);


            param = new SqlParameter("@nombre", SqlDbType.VarChar,30);
            param.Direction = ParameterDirection.Output;
            param.Value ="";
            cmd.Parameters.Add(param);


            param = new SqlParameter("@apellido", SqlDbType.VarChar,30);
            param.Direction = ParameterDirection.Output;
            param.Value = "";
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            string nombre = Convert.ToString(cmd.Parameters["@nombre"].Value);
            string apellido = Convert.ToString(cmd.Parameters["@apellido"].Value);

            return string.Format("{0} {1} ({2})", nombre, apellido, dni);
                  
        }
    }
}
