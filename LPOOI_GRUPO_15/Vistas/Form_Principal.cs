using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        
        public void cargarFormulario(object Form) 
        {
            if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(f);
            this.pnlPrincipal.Tag=f;
            f.Show();
        }

        
        private void ocultarSubmenu() 
        {
            if (pnlSubmenuAdministracion.Visible == true) 
            {
                pnlSubmenuAdministracion.Visible = false;
            }

            if(pnlSubmenuSistema.Visible==true)
            {
                pnlSubmenuSistema.Visible = false;
            }
        }

        private void mostrarSubmenu(Panel submenu) 
        {
            if (submenu.Visible == false)
            {
                ocultarSubmenu();
                submenu.Visible = true;
            }
            else 
            {
                submenu.Visible = false;
            }
        }



        private void btnMenuSistema_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubmenuSistema);
        }

        private void btnMenuAdminstracion_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubmenuAdministracion);
        }

        private void btnSubmenuSistemaUsuario_Click(object sender, EventArgs e)
        {
            cargarFormulario(new Form_Usuarios());
            ocultarSubmenu();
        }

        private void btnSubmenuEventos_Click(object sender, EventArgs e)
        {
            cargarFormulario(new Form_AltaEventos());
            ocultarSubmenu();
        }

        private void btnSubmenuDisciplinas_Click(object sender, EventArgs e)
        {
            cargarFormulario(new Form_AltaDisciplinas());
            ocultarSubmenu();
        }

        private void btnSubmenuCategorias_Click(object sender, EventArgs e)
        {
            cargarFormulario(new Form_AltaCategorias());
            ocultarSubmenu();
        }

        private void btnMenuCompetencias_Click(object sender, EventArgs e)
        {
            cargarFormulario(new Form_AltaCompetencias());
            ocultarSubmenu();
        }

        private void btnMenuParticipantes_Click(object sender, EventArgs e)
        {
            cargarFormulario(new Form_AltaParticipantes());
            ocultarSubmenu();
        }
    

    }
}
