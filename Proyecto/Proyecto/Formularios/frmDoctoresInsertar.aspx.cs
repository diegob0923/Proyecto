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
    public partial class frmDoctoresInsertar : System.Web.UI.Page
    {
        CentroMedicoEntities modeloBD = new CentroMedicoEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaProvincias();
            }
        }

        void seleccionPorDefectoDropDownList(DropDownList dropDownList)
        {
            dropDownList.Items.Insert(0, new ListItem("Seleccione una opción", ""));
            dropDownList.SelectedValue = "";
        }

        void cargaProvincias()
        {
            List<RetornaProvincias_Result> listaProvincias = modeloBD.RetornaProvincias(null).ToList();
            ddlProvincia.DataSource = listaProvincias;
            ddlProvincia.DataBind();
            seleccionPorDefectoDropDownList(ddlProvincia);
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
            seleccionPorDefectoDropDownList(ddlCanton);
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
            seleccionPorDefectoDropDownList(ddlDistrito);
        }


        protected void ddlDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click()
        {
            if (IsValid)
            {
                BlDoctores oBlDoctores = new BlDoctores();

                try
                {
                    oBlDoctores.InsertarDoctores(Convert.ToInt32(txtCedula.Text), txtGenero.Text, txtFechaNacimiento.Text, txtNombre.Text,
                                                txtPrimerApellido.Text, txtSegundoApellido.Text, txtTelefono1.Text, txtTelefono2.Text, txtCorreo.Text,
                                                Convert.ToInt16(ddlProvincia.SelectedValue), Convert.ToInt16(ddlCanton.SelectedValue),
                                                Convert.ToInt16(ddlDistrito.SelectedValue), txtDireccion.Text, Convert.ToInt32(txtEspecialidades.Text), txthoraAlmuerzo.Text);

                    lblMensaje.Text = "Registro insertado correctamente";
                }
                catch (Exception excepcion)
                {
                    lblMensaje.Text = "Ocurrió un error al insertar";
                }

            }
        }
    }
}