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
    public partial class frmEspecialidadMedicaEliminar : System.Web.UI.Page
    {
        BLEspecialidadesMedicas oBLEspecialidadesMedicas = new BLEspecialidadesMedicas();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }
            
        }

        void CargarDatos()
        {
           
            string parametro = Request.QueryString["id_especialidad"];

            if (!String.IsNullOrEmpty(parametro))
            {
                int idRegistro = Convert.ToInt32(parametro);

                sp_ConsultarEspecialidadId_Result datos = new sp_ConsultarEspecialidadId_Result();

                datos = oBLEspecialidadesMedicas.ConsultarEspecialidadMedicaId(idRegistro);

                if (datos != null)
                {
                    txtNombre.Text = datos.nombre.ToString();
                    txtDescripcion.Text = datos.descripcion.ToString();
                    hfIdEspecialidad.Value = datos.id_especialidad.ToString();
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    oBLEspecialidadesMedicas.EliminarEspecialidadMedica(Convert.ToInt32(hfIdEspecialidad.Value));
                    lblMensaje.Text = "Registro eliminado exitosamente";
                }
                catch (Exception excepcion)
                {
                    lblMensaje.Text = "Error al eliminar";
                }
                
            
        }
    }
}