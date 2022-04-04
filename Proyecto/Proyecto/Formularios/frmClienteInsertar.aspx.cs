using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto.Modelos;
namespace Proyecto.Formularios
{
    public partial class frmClienteInsertar : System.Web.UI.Page
    {

        CentroMedicoEntities modeloBD = new CentroMedicoEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaProvincias();
            }
        }

        void cargaProvincias()
        { 
            List<RetornaProvincias_Result> listaProvincias = modeloBD.RetornaProvincias(null).ToList();
            ddlProvincia.DataSource = listaProvincias;
            ddlProvincia.DataBind();
            ddlProvincia.Items.Insert(0, new ListItem("Seleccione una opción", ""));
            ddlProvincia.SelectedValue = "";
        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaCantones();
        }

        void cargaCantones()
        {
            int id_Provincia = Convert.ToInt16(ddlProvincia.SelectedValue);
            List<RetornaCantones_Result> listaCantones = modeloBD.RetornaCantones(null, id_Provincia).ToList();
            ddlCanton.DataSource = listaCantones;
            ddlCanton.DataBind();
            ddlCanton.Items.Insert(0, new ListItem("Seleccione una opción", ""));
            ddlCanton.SelectedValue = "";
        }

        protected void ddlCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaDistritos();
        }

        void cargaDistritos()
        {
            int id_Canton = Convert.ToInt16(ddlCanton.SelectedValue);
            List<RetornaDistritos_Result> listaDistritos = modeloBD.RetornaDistritos(null, id_Canton).ToList();
            ddlDistrito.DataSource = listaDistritos;
            ddlDistrito.DataBind();
            ddlDistrito.Items.Insert(0, new ListItem("Seleccione una opción", ""));
            ddlDistrito.SelectedValue = "";
        }

        protected void ddlDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}