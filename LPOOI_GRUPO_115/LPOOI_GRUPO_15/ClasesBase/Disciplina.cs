using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClasesBase
{
    public class Disciplina
    {
        private static int NEXTID=0;

        public Disciplina(string nombre, string descripcion){
            NEXTID++;
            dis_ID = NEXTID;
            dis_Nombre = nombre;
            dis_Descripcion = descripcion;
        }
        private int dis_ID;

        public int Dis_ID
        {
            get { return dis_ID; }
            set { dis_ID = value; }
        }
        private string dis_Nombre;

        public string Dis_Nombre
        {
            get { return dis_Nombre; }
            set { dis_Nombre = value; }
        }
        private string dis_Descripcion;

        public string Dis_Descripcion
        {
            get { return dis_Descripcion; }
            set { dis_Descripcion = value; }
        }

        public void ToString() 
        {
            MessageBox.Show("Nombre: " + this.Dis_Nombre + "\n" +
                            "Descripcion: " + this.Dis_Descripcion + "\n" +
                            "ID: " + this.Dis_ID + "\n");
        }
    }
}
