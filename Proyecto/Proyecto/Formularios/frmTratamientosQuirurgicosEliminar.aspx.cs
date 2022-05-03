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
    public partial class frmTratamientosQuirurgicosEliminar : System.Web.UI.Page
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


        void EliminarTratamientoQuirurgico()
        {
            try
            {
                oBLTratamientosQuirurgicos.EliminarTratamientoQuirurgico(Convert.ToInt32(hfIdTratamientoQuirurgico.Value));
                lblMensaje.Text = "Registro eliminado exitosamente";
            }
            catch (Exception excepcion)
            {
                lblMensaje.Text = "Error al eliminar";
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarTratamientoQuirurgico();
        }
    }
}