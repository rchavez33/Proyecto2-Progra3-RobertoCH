using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lmensaje.Text = "Bienvenid@ a La CAFETERIA:  " + ClsUsuario.Getusuario() + "!";
           
        }
    }
}