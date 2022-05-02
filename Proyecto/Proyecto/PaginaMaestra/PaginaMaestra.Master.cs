using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.PaginaMaestra
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["UsuarioLogueado"]) != true)
            {
                Response.Redirect("frmInicioSesion.aspx");
            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Add("NombreUsuario", null);
            Session.Add("UsuarioLogueado", null);
            Response.Redirect("frmInicioSesion.aspx");
        }
    }
}