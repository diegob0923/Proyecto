using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto.BL;
using Proyecto.Modelos;

namespace Proyecto.Formularios
{
    public partial class FrmRegistroCitasModificar : System.Web.UI.Page
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
            if (!string.IsNullOrEmpty(parametro))
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


        protected void btnModificar_Click(object sender, EventArgs e)
        {
            ModificaRegistroCitas();
        }

        void ModificaRegistroCitas()
        {
            if (IsValid)
            {
                try
                {
                    oBLRegistroCitas.ModificaRegistroCitas(Convert.ToInt32(hfIdRegistroCitas.Value), Convert.ToInt32(txtidDoctor.Text), Convert.ToInt32(txtidCliente.Text),
                        txtFechaCita.Text, txtHoraCita.Text, txtEspecialidad.Text, txtObservaciones.Text, txtestadoCita.Text);
                    lblMensaje.Text = "Registro Modificado Correctamente";
                }

                catch (Exception exception)
                {
                    lblMensaje.Text = "Error al Modificar Registro";
                }
            }
        }
    }
}