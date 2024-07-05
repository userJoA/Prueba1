using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var formLogin = new fmrlogin();
            Application.Run(formLogin);
            if (formLogin.logginSuccess)
            {
                Application.Run(new Form_Principal(formLogin.oUser));
            }
        }
    }
}
