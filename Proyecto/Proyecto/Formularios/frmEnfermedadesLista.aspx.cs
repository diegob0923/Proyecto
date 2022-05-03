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
    public partial class frmEnfermedadesLista : System.Web.UI.Page
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
            BLEnfermedad oBLEnfermedad = new BLEnfermedad();

            List<sp_ConsultarEnfermedades_Result> fuenteDatos = oBLEnfermedad.ConsultarEnfermedad(txtNombre.Text);

            grdEnfermedad.DataSource = fuenteDatos;

            grdEnfermedad.DataBind();

        }
    }
}