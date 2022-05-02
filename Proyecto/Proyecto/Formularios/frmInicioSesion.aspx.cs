using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto.BL;

namespace Proyecto.Formularios
{
    public partial class frmInicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Autenticacion();
        }

        public void Autenticacion()
        {
            BLInicioSesion oBLInicioSesion = new BLInicioSesion();

            bool respuesta = oBLInicioSesion.Autenticacion(txtUsuario.Text, txtContrasena.Text);

            if (!respuesta)
            {
                lblMensaje.Text = "Usuario o contraseña incorrectos";
                Session.Add("NombreUsuario", null);
                Session.Add("UsuarioLogueado", null);
            }
            else
            {
                Session.Add("NombreUsuario", oBLInicioSesion.nombre);
                Session.Add("UsuarioLogueado", true);

                if (oBLInicioSesion.tipo.Equals("DOC"))
                {
                    Response.Redirect("frmMenuDoctores.aspx");
                }
                else
                {
                    //el usuario es colaborador
                    Response.Redirect("frmMenuColaboradores.aspx");
                }

                lblMensaje.Text = "datos correctos";
            }
        }
    }
}