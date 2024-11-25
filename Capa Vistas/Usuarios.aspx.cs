using Proyecto2.Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto2.Capa_Logica
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
            }

        }

        private void LlenarGrid()
        {

            DataTable dt = new DataTable();
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Login"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (dt)
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }


            }
        }

        public static void MostrarAlerta(Page page, string message)
        {
            string script = $"<script type='text/javascript'>alert('{message}');</script>";
            ClientScriptManager cs = page.ClientScript;
            cs.RegisterStartupScript(page.GetType(), "AlertScript", script);
        }

        protected void bagregar_Click(object sender, EventArgs e)
        {
            ClsUsuario.Setid(int.Parse(tid.Text));
            ClsUsuario.Setusuario(tnombre.Text);
            ClsUsuario.Setclave(tclave.Text);

            UsuarioLogica usuario = new UsuarioLogica();

            if (usuario.Agregar() > 0)

                MostrarAlerta(this, "Usuario ingresado con exito!");


            else
                MostrarAlerta(this, "Error al ingresar usuario");

            LlenarGrid();
        }

        protected void bborrar_Click(object sender, EventArgs e)
        {
            ClsUsuario.Setid(int.Parse(tid.Text));


            UsuarioLogica usuario = new UsuarioLogica();

            if (usuario.Borrar() > 0)

                MostrarAlerta(this, "Usuario borrado con exito!");


            else
                MostrarAlerta(this, "Error al borrar usuario");

            LlenarGrid();
        }

        protected void bmodificar_Click(object sender, EventArgs e)
        {
            ClsUsuario.Setid(int.Parse(tid.Text));
            ClsUsuario.Setusuario(tnombre.Text);
            ClsUsuario.Setclave(tclave.Text);


            UsuarioLogica usuario = new UsuarioLogica();

            if (usuario.Modificar() > 0)

                MostrarAlerta(this, "Usuario modificado con exito!");


            else
                MostrarAlerta(this, "Error al modificar usuario");

            LlenarGrid();
        }


        protected void bconsultar_Click(object sender, EventArgs e)
        {
            ClsUsuario.Setid(int.Parse(tid.Text));
            ClsUsuario.Setusuario(tnombre.Text);
            ClsUsuario.Setclave(tclave.Text);
            
            UsuarioLogica usuario = new UsuarioLogica();

            if (usuario.Consultar() > 0)

                MostrarAlerta(this, "Usuario consultado con exito!");


            else
                MostrarAlerta(this, "Error al consultar usuario");

            LlenarGrid();
        }
    }
}
    
