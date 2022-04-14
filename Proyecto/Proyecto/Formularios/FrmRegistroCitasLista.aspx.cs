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
    public partial class FrmRegistroCitasLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        void cargarDatos()
        {
            BLRegistroCitas oBLRegistroCitas = new BLRegistroCitas();

            try
            {

                List<sp_ConsultarRegistroPorIdCliente_Result> listaRegistroCliente = new List<sp_ConsultarRegistroPorIdCliente_Result>();
                listaRegistroCliente = oBLRegistroCitas.RetornarCitaCliente(txtIdCliente.Text);
                grdRegistroCitas.DataSource = listaRegistroCliente;
                grdRegistroCitas.DataBind();

            }
            catch (Exception excepcion)
            {
                lblMensajeError.Text = "ocurrio un error al retornar los datos" + excepcion;
            }
        }
    }
}