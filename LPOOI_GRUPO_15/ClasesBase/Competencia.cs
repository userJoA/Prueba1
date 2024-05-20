using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Competencia
    {
        public Competencia(string nombre, string descripcion, System.DateTime fechaInicio, System.DateTime fechaFin, string organizador, string sponsors, string ubicacion) {
            com_Nombre = nombre;
            com_Descripcion = descripcion;
            com_FechaInicio = fechaInicio;
            com_FechaFin = fechaFin;
            com_Organizador = organizador;
            com_Sponsors = sponsors;
            com_Ubicacion = ubicacion;
            com_ID = 102;
            com_Estado = "Programado";
        
        }

        private int com_ID;

        public int Com_ID
        {
            get { return com_ID; }
            set { com_ID = value; }
        }
        private string com_Nombre;

        public string Com_Nombre
        {
            get { return com_Nombre; }
            set { com_Nombre = value; }
        }
        private string com_Descripcion;

        public string Com_Descripcion
        {
            get { return com_Descripcion; }
            set { com_Descripcion = value; }
        }
        private DateTime com_FechaInicio;

        public DateTime Com_FechaInicio
        {
            get { return com_FechaInicio; }
            set { com_FechaInicio = value; }
        }
        private DateTime com_FechaFin;

        public DateTime Com_FechaFin
        {
            get { return com_FechaFin; }
            set { com_FechaFin = value; }
        }
        private string com_Estado;

        public string Com_Estado
        {
            get { return com_Estado; }
            set { com_Estado = value; }
        }
        private string com_Organizador;

        public string Com_Organizador
        {
            get { return com_Organizador; }
            set { com_Organizador = value; }
        }
        private string com_Ubicacion;

        public string Com_Ubicacion
        {
            get { return com_Ubicacion; }
            set { com_Ubicacion = value; }
        }
        private string com_Sponsors;

        public string Com_Sponsors
        {
            get { return com_Sponsors; }
            set { com_Sponsors = value; }
        }
        private int cat_ID;

        public int Cat_ID
        {
            get { return cat_ID; }
            set { cat_ID = value; }
        }
        private int dis_ID;

        public int Dis_ID
        {
            get { return dis_ID; }
            set { dis_ID = value; }
        }
    }
}
