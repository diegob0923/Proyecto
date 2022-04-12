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
    public partial class frmClienteLista : System.Web.UI.Page
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
            BLCliente oBLCliente = new BLCliente();

            try
            {

                List<sp_ConsultarClientePorCedula_Result> listaClientes = new List<sp_ConsultarClientePorCedula_Result>();
                listaClientes = oBLCliente.RetornarClientes(txtCedula.Text);
                grdClientes.DataSource = listaClientes;
                grdClientes.DataBind();

            }
            catch (Exception excepcion)
            {
                lblMensajeError.Text = "ocurrio un error al retornar los datos"+ excepcion;
            }
        }

    }
}