using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClasesBase
{
    public class Validaciones
    {

        public static void soloLeteras(KeyPressEventArgs v) 
        {

            if (char.IsLetter(v.KeyChar)) 
            {
                v.Handled = false;
            }

            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }

            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                 v.Handled = true;
                 MessageBox.Show("Solo debe Ingresar Letras");
            }
        
        }

        public static void soloNumeros(KeyPressEventArgs v)
        {
            if (char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }

            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }

            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Debe Ingresar Solo Numeros");
            }

        }

        public static void soloDecimales(KeyPressEventArgs v)
        {
            if (char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }

            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }

            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {   v.Handled = true;
                MessageBox.Show("Solo debe Ingresar Letras");
            }

        }


    }
}
