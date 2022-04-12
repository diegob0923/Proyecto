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
    public partial class frmEspecialidadesMedicasLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCargarRegistros_Click(object sender, EventArgs e)
        {
            CargarRegistros();
        }
        void CargarRegistros()
        {
            BLEspecialidadesMedicas oBLEspecialidadesMedicas = new BLEspecialidadesMedicas();

            List<sp_ConsultarEspecialidadPorNombre_Result> fuenteDatos = oBLEspecialidadesMedicas.ConsultarEspecialidadMedica(txtNombre.Text);

            fuenteDatos = oBLEspecialidadesMedicas.ConsultarEspecialidadMedica(txtNombre.Text);

            grdEspecialidadesMedicas.DataSource = fuenteDatos;

            grdEspecialidadesMedicas.DataBind();

        }
    }
}