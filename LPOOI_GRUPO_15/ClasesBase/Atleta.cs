using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClasesBase
{
    public class Atleta
    {
        private static int NETXID = 0;
        private int atl_ID;

        public int Atl_ID
        {
            get { return atl_ID; }
            set { atl_ID = value; }
        }

        private int atl_DNI;

        public int Atl_DNI
        {
            get { return atl_DNI; }
            set { atl_DNI = value; }
        }
        private string atl_Apellido;

        public string Atl_Apellido
        {
            get { return atl_Apellido; }
            set { atl_Apellido = value; }
        }
        private string atl_Nombre;

        public string Atl_Nombre
        {
            get { return atl_Nombre; }
            set { atl_Nombre = value; }
        }
        private string atl_Nacionalidad;

        public string Atl_Nacionalidad
        {
            get { return atl_Nacionalidad; }
            set { atl_Nacionalidad = value; }
        }
        private string atl_Entrenador;

        public string Atl_Entrenador
        {
            get { return atl_Entrenador; }
            set { atl_Entrenador = value; }
        }
        private string atl_Genero;

        public string Atl_Genero
        {
            get { return atl_Genero; }
            set { atl_Genero = value; }
        }
        private double atl_Altura;

        public double Atl_Altura
        {
            get { return atl_Altura; }
            set { atl_Altura = value; }
        }
        private double atl_Peso;

        public double Atl_Peso
        {
            get { return atl_Peso; }
            set { atl_Peso = value; }
        }
        private DateTime atl_FechaNac;

        public DateTime Atl_FechaNac
        {
            get { return atl_FechaNac; }
            set { atl_FechaNac = value; }
        }
        private string atl_Direccion;

        public string Atl_Direccion
        {
            get { return atl_Direccion; }
            set { atl_Direccion = value; }
        }
        private string atl_Email;

        public string Atl_Email
        {
            get { return atl_Email; }
            set { atl_Email = value; }
        }


        public Atleta() { }

        public Atleta(string nombre, string apellido, int dni, string nacionalidad, string entrenador, string genero, double altura, double peso, DateTime fechaNac, string direccion, string email)
        {
            NETXID++;
            atl_ID = NETXID;
            atl_Nombre = nombre;
            atl_Apellido = apellido;
            atl_DNI = dni;
            atl_Nacionalidad = nacionalidad;
            atl_Entrenador = entrenador;
            atl_Genero = genero;
            atl_Altura = altura;
            atl_Peso = peso;
            atl_FechaNac = fechaNac;
            atl_Direccion = direccion;
            atl_Email = email;
        }
        

        public Atleta(string nombre, string apellido) {
            this.atl_Nombre = nombre;
            this.atl_Apellido = apellido;
        }

        public void ToString(){
           MessageBox.Show("Nombre: " + this.Atl_Nombre + "\n" +
                           "Apellido: " + this.Atl_Apellido + "\n" +
                           "DNI: " + this.Atl_DNI + "\n" +
                           "Nacionalidad: " + this.Atl_Nacionalidad + "\n" +
                           "Entrenador: " + this.Atl_Entrenador + "\n" +
                           "Genero: " + this.Atl_Genero + "\n" +
                           "Altura: " + this.Atl_Altura + "\n" +
                           "Peso: " + this.Atl_Peso + "\n" +
                           "Fecha de Nacimiento: " + this.Atl_FechaNac + "\n" +
                           "Direccion: " + this.Atl_Direccion + "\n" +
                           "Email: " + this.Atl_Email +"\n" +
                           "ID: " + this.Atl_ID + "\n");
        }

    }
}
