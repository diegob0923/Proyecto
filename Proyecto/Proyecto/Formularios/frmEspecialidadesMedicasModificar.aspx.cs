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
    public partial class frmEspecialidadMedicaModificar : System.Web.UI.Page
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

                if (datos!=null)
                {
                    txtNombre.Text = datos.nombre.ToString();
                    txtDescripcion.Text = datos.descripcion.ToString();
                    hfIdEspecialidad.Value = datos.id_especialidad.ToString();
                }
            }
        }


        void ModificarEspecialidad()
        {
            if (IsValid)
            {
                try
                {
                    oBLEspecialidadesMedicas.ModificarEspecialidadMedica(Convert.ToInt32(hfIdEspecialidad.Value), txtNombre.Text, txtDescripcion.Text);
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
            ModificarEspecialidad();
        }
    }
}