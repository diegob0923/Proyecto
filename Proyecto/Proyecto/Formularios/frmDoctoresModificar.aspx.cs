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
    public partial class frmDoctoresModificar : System.Web.UI.Page
    {

        CentroMedicoEntities modeloBD = new CentroMedicoEntities();
        BlDoctores oBlDoctores = new BlDoctores();

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
            string parametro = Request.QueryString["id_Doctores"];

            if (!String.IsNullOrEmpty(parametro))
            {
                int idRegistro = Convert.ToInt32(parametro);
                sp_ConsultarDoctoresPorCedula_Result datos = new sp_ConsultarDoctoresPorCedula_Result();
                datos = oBlDoctores.ConsultarDoctoresCedula(idRegistro);

                if (datos != null)
                {
                    txtCedula.Text = datos.cedula.ToString();
                    txtGenero.Text = datos.genero.ToString();
                    txtFechaNacimiento.Text = datos.ToString();
                    txtNombre.Text = datos.ToString();
                    txtPrimerApellido.Text = datos.ToString();
                    txtSegundoApellido.Text = datos.ToString();
                    txtCorreo.Text = datos.ToString();
                    txtCarnet.Text = datos.ToString();
                    CargaProvincias();
                    ddlProvincia.SelectedValue = datos.id_provincia.ToString();
                    CargaCantones();
                    ddlCanton.SelectedValue = datos.id_canton.ToString();
                    CargaDistritos();
                    ddlDistrito.SelectedValue = datos.id_distrito.ToString();
                    txtDireccion.Text = datos.direccion.ToString();
                    txtEspecialidad.Text = datos.ToString();
                    txtHoraAlmuerzo.Text = datos.ToString();
                    hfIdDoctores.Value = datos.id_Doctor.ToString();
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
            ModificaDoctores();
        }
        void ModificaDoctores()
        {
            if (IsValid)
            {
                try
                {
                    oBlDoctores.ModificaDoctores(Convert.ToInt32(hfIdDoctores.Value), Convert.ToInt32(txtCedula.Text), txtGenero.Text, txtFechaNacimiento.Text, txtNombre.Text,
                                                txtPrimerApellido.Text, txtSegundoApellido.Text, txtTelefono1.Text, txtTelefono2.Text, txtCorreo.Text, Convert.ToInt32(txtCarnet.Text),
                                                Convert.ToInt16(ddlProvincia.SelectedValue), Convert.ToInt16(ddlCanton.SelectedValue),
                                                Convert.ToInt16(ddlDistrito.SelectedValue), txtDireccion.Text, Convert.ToInt32(txtEspecialidad.Text), txtHoraAlmuerzo.Text);
                    lblMensaje.Text = "Registro Modificado Correctamente";
                }
                catch (Exception exception)
                {
                    lblMensaje.Text = "Error al modificar registro";
                }
            }
            }

       
    }
    }
