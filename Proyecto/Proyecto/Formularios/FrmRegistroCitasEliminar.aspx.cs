using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto.Modelos;
using Proyecto.BL;
namespace Proyecto.Formularios
{
    public partial class FrmRegistroCitasEliminar : System.Web.UI.Page
    {
        BLRegistroCitas oBLRegistroCitas = new BLRegistroCitas();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }
        }

        void CargarDatos()
        {
            string parametro = Request.QueryString["id_único"];

            if (!String.IsNullOrEmpty(parametro))
            {
                int idRegistro = Convert.ToInt32(parametro);
                sp_ConsultarRegistroCitas_Result datos = new sp_ConsultarRegistroCitas_Result();

                datos = oBLRegistroCitas.ConsultarRegistroCitasId(idRegistro);

                if (datos != null)
                {
                    txtidDoctor.Text = datos.id_doctor.ToString();
                    txtidCliente.Text = datos.id_cliente.ToString();
                    txtFechaCita.Text = datos.fecha_cita.ToString();
                    txtHoraCita.Text = datos.hora_cita.ToString();
                    txtEspecialidad.Text = datos.especialidad.ToString();
                    txtObservaciones.Text = datos.observaciones.ToString();
                    txtestadoCita.Text = datos.estado_cita.ToString();
                    hfIdRegistroCitas.Value = datos.id_único.ToString();
                }
            }

            }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                oBLRegistroCitas.EliminarRegistroCitas(Convert.ToInt32(hfIdRegistroCitas.Value));
                lblMensaje.Text = "Registro eliminado exitosamente";
            }
            catch (Exception exception)
            {
                lblMensaje.Text = "Error al eliminar";
            }

        }
        
        
    }
}