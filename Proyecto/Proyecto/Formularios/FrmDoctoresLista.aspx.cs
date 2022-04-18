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
    public partial class FrmDoctoresLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }


       
        void cargarDatos()
        {
            BlDoctores oBlDoctores = new BlDoctores();

            try
            {

                List<sp_ConsultarDoctoresPorCedula_Result> listaDoctores = new List<sp_ConsultarDoctoresPorCedula_Result>();
                listaDoctores = oBlDoctores.RetornarDoctores(txtCedula.Text);
                grdDoctores.DataSource = listaDoctores;
                grdDoctores.DataBind();

            }
            catch (Exception excepcion)
            {
                lblMensajeError.Text = "ocurrio un error al retornar los datos" + excepcion;
            }
        }
    }
}