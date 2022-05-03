using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Formularios
{
    public partial class frmMenuColaboradores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "Bienvenid@ " + Session["NombreUsuario"].ToString();
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            switch (ddlMenuColaboradores.SelectedValue)
            {
               
                case "Ver Citas":
                    Response.Redirect("FrmRegistroCitasLista.aspx");
                    break;

                case "Cancelar Citas":

                    break;

                case "Modificar datos paciente":
                    Response.Redirect("frmClienteLista.aspx");
                    break;

                case "Ver Reportes":

                    break;

            }
        }

        protected void btnMantenimiento_Click(object sender, EventArgs e)
        {
            switch (ddlCatalogos.SelectedValue)
            {
                

                case "Clientes":
                    Response.Redirect("frmClienteLista.aspx");
                    break;

                case "Especialidades Medicas":
                    Response.Redirect("frmEspecialidadesMedicasLista.aspx");
                    break;

                case "Enfermedades":
                    Response.Redirect("frmEnfermedadesLista.aspx");
                    break;

                case "Tratamientos Quirurgicos":
                    Response.Redirect("frmTratamientosQuirurgicosLista.aspx");
                    break;

                case "Doctores":
                    Response.Redirect("FrmDoctoresLista.aspx");
                    break;

            }
        }
    }
}