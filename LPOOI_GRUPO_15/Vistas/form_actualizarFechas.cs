using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using ClasesBase;

namespace Vistas
{
    public partial class form_actualizarFechas : UserControl
    {
        
        public form_actualizarFechas(Form_Cronometraje.Datos info)
        {
            InitializeComponent();
            cargaFormulario(info);     

        }

        public event Action DatosActualizados;

        private void modificarDatos(int dni,string nCompetencia,string estado,DateTime fIni,DateTime fFin) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.comdepConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Modificar_ViewEvento_Evento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param = new SqlParameter("@dni",SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = dni;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@nombreCom", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = nCompetencia;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@eveEstado", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = estado;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@eveInicio", SqlDbType.DateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = fIni;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@eveFin", SqlDbType.DateTime);
            param.Direction = ParameterDirection.Input;
            param.Value = fFin;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        private void cargaFormulario(Form_Cronometraje.Datos info) 
        {
            txtNombre.Text = info.nombre;
            txtApellido.Text = info.apellido;
            txtDNI.Text = info.dni;
            cmbEstado.Text = info.estado;
            txtCompetencia.Text = info.nombreCompetencia;
            if (info.fInicio == "")
            {
                dttpHoraFin.Value = DateTime.Now;
            }
            else
            {
                DateTime fechaIni = Convert.ToDateTime(info.fInicio);
                dttpHoraIni.Value = fechaIni;
            }

            if (info.fFin == "")
            {
                dttpHoraFin.Value = DateTime.Now;
            }
            else
            {
                DateTime fechaFin = Convert.ToDateTime(info.fFin);
                dttpHoraFin.Value = fechaFin;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrarForm();
        }

        private void cerrarForm() 
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }


        private bool validarFechas(DateTime fInicio,DateTime fFin ) 
        {
            return fFin >= fInicio;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            DateTime fechaInicio = dttpHoraIni.Value;
            DateTime fechaFin = dttpHoraFin.Value;
            if(!validarFechas(fechaInicio,fechaFin))
            {
                MessageBox.Show("La fecha de inicio debe ser menor a la fecha de finalizacion");
                return;
            }

            DialogResult resultado = MessageBox.Show("Desea Actualizar los datos del Participante" + txtNombre.Text+" "+ txtApellido.Text , "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
            {
                int dni = int.Parse(txtDNI.Text);
                string nCompetencia = txtCompetencia.Text;
                string estado = cmbEstado.Text;
                try
                {
                    modificarDatos(dni,nCompetencia,estado,fechaInicio,fechaFin);
                    MessageBox.Show("Datos actualizados");
                    // Verificar si hay suscriptores antes de invocar el evento
                    if (DatosActualizados != null)
                    {
                        DatosActualizados();
                    }
                    cerrarForm();
                    
                }
                catch 
                {
                    MessageBox.Show("error al actaulizar datos");
                }
            }
        }
    }
}
