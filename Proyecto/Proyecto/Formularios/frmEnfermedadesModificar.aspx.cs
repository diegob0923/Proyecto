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
    public partial class frmEnfermedadesModificar : System.Web.UI.Page
    {
        BLEnfermedad oBLEnfermedad = new BLEnfermedad();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }
        }

        void CargarDatos()
        {
            string parametro = Request.QueryString["id_enfermedad"];

            if (!String.IsNullOrEmpty(parametro))
            {
                int idRegistro = Convert.ToInt32(parametro);

                sp_ConsultarEnfermedadesID_Result datos = new sp_ConsultarEnfermedadesID_Result();

                datos = oBLEnfermedad.ConsultarEnfermedadID(idRegistro);

                if (datos != null)
                {
                    txtNombre.Text = datos.nombre.ToString();
                    txtDescripcion.Text = datos.descripcion.ToString();
                    hfIdEnfermedad.Value = datos.id_enfermedad.ToString();
                }
            }

        }

        void ModificarEnfermedad()
        {
            if (IsValid)
            {
                try
                {
                    oBLEnfermedad.ModificarEnfermedad(Convert.ToInt32(hfIdEnfermedad.Value), txtNombre.Text, txtDescripcion.Text);
                    string nombreVerificar = txtNombre.Text;
                    string descripcionVerificar = txtDescripcion.Text;
                    lblMensaje.Text = "Registro modificado correctamente";
                }
                catch (Exception exception)
                {
                    lblMensaje.Text = "Error al modificar registro";
                }
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarEnfermedad();
        }
    }
}