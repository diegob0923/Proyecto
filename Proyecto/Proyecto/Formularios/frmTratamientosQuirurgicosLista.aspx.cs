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
    public partial class frmTratamientosQuirurgicosLista : System.Web.UI.Page
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
            BLTratamientosQuirurgicos oBLTratamientosQuirurgicos = new BLTratamientosQuirurgicos();

            List<sp_ConsultarTratamientosQuirurgicos_Result> fuenteDatos = oBLTratamientosQuirurgicos.ConsultarTratamientosQuirurgicos(txtNombre.Text);

            grdTratamientosQuirurgicos.DataSource = fuenteDatos;

            grdTratamientosQuirurgicos.DataBind();

        }
    }
}