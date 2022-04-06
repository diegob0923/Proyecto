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
    public partial class frmRegistroCitas : System.Web.UI.Page
    {
        CentroMedicoEntities modeloBD = new CentroMedicoEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                BLRegistroCitas oBLRegistroCitas = new BLRegistroCitas();
                try
                {

                    oBLRegistroCitas.InsertarRegistroCitas(Convert.ToInt32(txtidDoctor.Text), Convert.ToInt32(txtidCliente.Text),
                        txtFechaCita.Text, txtHoraCita.Text, Convert.ToInt32((txtEspecialidad.Text)), txtObservaciones.Text, txtestadoCita.Text);

                    lblMensaje.Text = "Registro insertado correctamente";
                }
                catch (Exception excepcion)
                {
                    lblMensaje.Text = "Ocurrió un error al insertar";
                }
            }
        }
    }
}