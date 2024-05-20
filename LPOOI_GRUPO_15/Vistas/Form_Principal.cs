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
        /*Form_AltaCompetencias formAltaCompetencias;
        Form_AltaParticipantes formAltaParticipaciones;
        Form_AltaEventos formAltaEventos;
        Form_AltaCategorias formAltaCategorias;
        Form_AltaDisciplinas formAltaDisciplinas;*/
        public Form_Principal()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
        /*
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltaCompetencias_Click(object sender, EventArgs e)
        {
            if (formAltaCompetencias == null)
            {
                formAltaCompetencias = new Form_AltaCompetencias();
                formAltaCompetencias.MdiParent = this;
                formAltaCompetencias.FormClosed += new FormClosedEventHandler(altasComp_FormClosed);
                formAltaCompetencias.Show();
            }
            else { formAltaCompetencias.Activate(); }
        }

        void altasComp_FormClosed(object sender, EventArgs e)
        {
            formAltaCompetencias = null;
        }


        private void btnAltaPartipantes_Click(object sender, EventArgs e)
        {
            if (formAltaParticipaciones == null)
            {
                formAltaParticipaciones = new Form_AltaParticipantes();
                formAltaParticipaciones.MdiParent = this;
                formAltaParticipaciones.FormClosed += new FormClosedEventHandler(altasPart_FormClosed);
                formAltaParticipaciones.Show();
            }
            else { formAltaParticipaciones.Activate(); }
        }

        void altasPart_FormClosed(object sender, EventArgs e)
        {
            formAltaParticipaciones = null;
        }

        private void btnAltaEventos_Click(object sender, EventArgs e)
        {
            if (formAltaEventos == null)
            {
                formAltaEventos = new Form_AltaEventos();
                formAltaEventos.MdiParent = this;
                formAltaEventos.FormClosed += new FormClosedEventHandler(altasEvent_FormClosed);
                formAltaEventos.Show();
            }
            else { formAltaEventos.Activate(); }
        }

        void altasEvent_FormClosed(object sender, EventArgs e)
        {
            formAltaEventos = null;
        }

        private void btnAltaCategorias_Click(object sender, EventArgs e)
        {
            if (formAltaCategorias == null) {
                formAltaCategorias = new Form_AltaCategorias();
                formAltaCategorias.MdiParent = this;
                formAltaCategorias.FormClosed += new FormClosedEventHandler(altasCat_FormClosed);
                formAltaCategorias.Show();
            }
            else { formAltaCategorias.Activate(); }
        }

        void altasCat_FormClosed(object sender, EventArgs e)
        {
            formAltaCategorias = null;
        }

        private void btnAltaDisciplina_Click(object sender, EventArgs e)
        {
            if(formAltaDisciplinas==null){
                formAltaDisciplinas = new Form_AltaDisciplinas();
                formAltaDisciplinas.MdiParent = this;
                formAltaDisciplinas.FormClosed += new FormClosedEventHandler(altasDisc_FormClosed);
                formAltaDisciplinas.Show(); 
            }
            else{}
        }

        void altasDisc_FormClosed(object sender, EventArgs e)
        {
            formAltaDisciplinas = null;
        }
        */
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

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            cargarFormulario(new Form_AltaParticipantes());
        }

        private void btnCompetencias_Click(object sender, EventArgs e)
        {
            cargarFormulario(new Form_AltaCompetencias());
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            cargarFormulario(new Form_AltaEventos());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            cargarFormulario(new Form_AltaCategorias());
        }

        private void btnDisciplinas_Click(object sender, EventArgs e)
        {
            cargarFormulario(new Form_AltaDisciplinas());
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            cargarFormulario(new Form_Sistema());
        }



    }
}
