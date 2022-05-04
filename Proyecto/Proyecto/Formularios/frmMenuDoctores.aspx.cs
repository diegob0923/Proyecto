using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Formularios
{
    public partial class frmMenuDoctores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "Bienvenid@ " + Session["NombreUsuario"].ToString();
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            switch (ddlMenuDoctores.SelectedValue)
            {
                case "Ver Citas":
                    Response.Redirect("FrmRegistroCitasLista.aspx");    
                    break;

                case "Cancelar Citas":
                    Response.Redirect("FrmRegistroCitasEliminar");
                    break;

                case "Ver Reportes":
                    Response.Redirect("frmrReporteExpediente.aspx");
                    break;

            }
        }
    }
}