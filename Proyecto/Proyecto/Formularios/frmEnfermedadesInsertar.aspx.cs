using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto.BL;

namespace Proyecto.Formularios
{
    public partial class frmEnfermedadesInsertar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            InsertarEnfermedad();
        }

        void InsertarEnfermedad()
        {
            if (IsValid)
            {
                BLEnfermedad oBLEnfermedad = new BLEnfermedad();

                try
                {
                    oBLEnfermedad.InsertarEnfermedad(txtNombre.Text, txtDescripcion.Text);
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