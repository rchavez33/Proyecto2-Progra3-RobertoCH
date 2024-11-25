using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bingresar_Click(object sender, EventArgs e)
        {
            ValidarLogin(tusuario.Text, tclave.Text);
        }

        private void ValidarLogin(string Usuario, string Clave)
        {
            ClsUsuario.Setusuario(Usuario);
            ClsUsuario.Setclave(Clave);

            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select usuario, clave from Login where usuario = '" + ClsUsuario.Getusuario() + "' " +
                "and clave = '" + ClsUsuario.Getclave() + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                lmensaje.Text = " Usuario o contraseña incorrecto";
            }
            conexion.Close();

        }
    }
}