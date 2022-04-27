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
    public partial class frmClienteModificar : System.Web.UI.Page
    {
        CentroMedicoEntities modeloBD = new CentroMedicoEntities();
        BLCliente oBLCliente = new BLCliente();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaProvincias();
                CargaCantones();
                CargaDistritos();
                CargarDatos();
            }
        }


        void CargaProvincias()
        {
            List<RetornaProvincias_Result> listaProvincias = modeloBD.RetornaProvincias(null).ToList();
            ddlProvincia.DataSource = listaProvincias;
            ddlProvincia.DataBind();
            
        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaCantones();
        }

        void CargaCantones()
        {
            int id_Provincia = Convert.ToInt16(ddlProvincia.SelectedValue);
            List<RetornaCantones_Result> listaCantones = modeloBD.RetornaCantones(null, id_Provincia).ToList();
            ddlCanton.DataSource = listaCantones;
            ddlCanton.DataBind();
            
        }

        protected void ddlCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaDistritos();
        }

        void CargaDistritos()
        {
            int id_Canton = Convert.ToInt16(ddlCanton.SelectedValue);
            List<RetornaDistritos_Result> listaDistritos = modeloBD.RetornaDistritos(null, id_Canton).ToList();
            ddlDistrito.DataSource = listaDistritos;
            ddlDistrito.DataBind();
            
        }


        void CargarDatos()
        {
            string parametro = Request.QueryString["id_cliente"];

            if (!String.IsNullOrEmpty(parametro))
            {
                int idRegistro = Convert.ToInt32(parametro);

                sp_ConsultarClienteId_Result datos = new sp_ConsultarClienteId_Result();

                datos = oBLCliente.RetornarClienteId(idRegistro);

                if (datos !=null)
                {
                    txtCedula.Text = datos.cedula.ToString();
                    txtGenero.Text = datos.genero.ToString(); 
                    txtFechaNacimiento.Text = datos.fecha_nacimiento.ToString();
                    txtNombre.Text = datos.nombre.ToString();
                    txtPrimerApellido.Text = datos.primer_apellido.ToString();
                    txtSegundoApellido.Text = datos.segundo_apellido.ToString();
                    txtTelefono1.Text = datos.telefono1.ToString();
                    txtTelefono2.Text = datos.telefono2.ToString();
                    txtCorreo.Text = datos.correo.ToString();
                    CargaProvincias();
                    ddlProvincia.SelectedValue = datos.id_provincia.ToString();
                    CargaCantones();
                    ddlCanton.SelectedValue = datos.id_canton.ToString();
                    CargaDistritos();
                    ddlDistrito.SelectedValue = datos.id_distrito.ToString();
                    txtDireccion.Text = datos.direccion.ToString();
                    hfIdCliente.Value = datos.id_cliente.ToString();
                }
                else
                {
                    Response.Redirect("");
                }

            }
        }


        protected void ddlDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCliente();
        }

        void ModificarCliente()
        {
            if (IsValid)
            {
                try
                {
                    oBLCliente.ModificarClientes(Convert.ToInt32(hfIdCliente.Value), Convert.ToInt32(txtCedula.Text), txtGenero.Text, txtFechaNacimiento.Text, txtNombre.Text,
                                                txtPrimerApellido.Text, txtSegundoApellido.Text, txtTelefono1.Text, txtTelefono2.Text, txtCorreo.Text,
                                                Convert.ToInt16(ddlProvincia.SelectedValue), Convert.ToInt16(ddlCanton.SelectedValue),
                                                Convert.ToInt16(ddlDistrito.SelectedValue), txtDireccion.Text);
                    lblMensaje.Text = "Registro modificado correctamente";
                }
                catch (Exception exception)
                {
                    lblMensaje.Text = "Error al modificar registro";
                }
            }
        }
    }
}