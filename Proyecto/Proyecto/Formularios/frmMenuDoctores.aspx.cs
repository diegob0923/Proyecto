﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Formularios
{
    public partial class frmMenuDoctores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "Bienvenid@ " + Session["NombreUsuario"].ToString() + " Ultima fecha ingreso";
        }
    }
}