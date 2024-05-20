using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClasesBase
{
    public class Categoria
    {
        private static int NEXTID = 0;
        public Categoria(string nombre, string descripcion) {
            NEXTID++;
            cat_ID = NEXTID;
            cat_Nombre = nombre;
            cat_Descripcion = descripcion;
        }

        private int cat_ID;

        public int Cat_ID
        {
            get { return cat_ID; }
            set { cat_ID = value; }
        }
        private string cat_Nombre;

        public string Cat_Nombre
        {
            get { return cat_Nombre; }
            set { cat_Nombre = value; }
        }
        private string cat_Descripcion;

        public string Cat_Descripcion
        {
            get { return cat_Descripcion; }
            set { cat_Descripcion = value; }
        }

        public void ToString() 
        {
            MessageBox.Show("Nombre: " + this.Cat_Nombre + "\n" +
                            "Descripcion: " + this.Cat_Descripcion + "\n" +
                            "ID: " + this.cat_ID + "\n");
        }
    }
}
