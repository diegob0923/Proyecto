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
    public partial class frmTratamientosQuirurgicosModificar : System.Web.UI.Page
    {
        BLTratamientosQuirurgicos oBLTratamientosQuirurgicos = new BLTratamientosQuirurgicos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }
        }

        void CargarDatos()
        {
            string parametro = Request.QueryString["id_tratamiento"];

            if (!String.IsNullOrEmpty(parametro))
            {
                int idRegistro = Convert.ToInt32(parametro);

                sp_ConsultarTratamientosQuirurgicosID_Result datos = new sp_ConsultarTratamientosQuirurgicosID_Result();

                datos = oBLTratamientosQuirurgicos.ConsultarTratamientosQuirurgicosID(idRegistro);

                if (datos != null)
                {
                    txtNombre.Text = datos.nombre.ToString();
                    txtDescripcion.Text = datos.descripcion.ToString();
                    hfIdTratamientoQuirurgico.Value = datos.id_tratamiento.ToString();
                }
            }
        }

        void ModificarTratamientoQuirurgico()
        {
            if (IsValid)
            {
                try
                {
                    oBLTratamientosQuirurgicos.ModificarTratamientoQuirurgico(Convert.ToInt32(hfIdTratamientoQuirurgico.Value), txtNombre.Text, txtDescripcion.Text);
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
            ModificarTratamientoQuirurgico();
        }
    }
}