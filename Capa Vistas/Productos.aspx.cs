using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto2.Capa_Negocio;
using System.Security.Cryptography;
using Proyecto2.Capa_Modelo;

namespace Proyecto2.Capa_Vistas
{
    public partial class Productos : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Productos"))
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
            ClsProducto.Setcodigo(int.Parse(tcodigo.Text));
            ClsProducto.Setnombre(tproducto.Text);
            ClsProducto.Setprecio(decimal.Parse(tprecio.Text));

            ProductoLogica producto = new ProductoLogica();

            if (producto.Agregar() > 0)

                MostrarAlerta(this, "Producto ingresado con exito!");


            else
                MostrarAlerta(this, "Error al ingresar producto");

            LlenarGrid();
        }

        protected void bborrar_Click(object sender, EventArgs e)
        {
            ClsProducto.Setcodigo(int.Parse(tcodigo.Text));


            ProductoLogica producto = new ProductoLogica();

            if (producto.Borrar() > 0)

                MostrarAlerta(this, "Producto borrado con exito!");


            else
                MostrarAlerta(this, "Error al borrar Producto");

            LlenarGrid();
        }

        protected void bmodificar_Click(object sender, EventArgs e)
        {
            ClsProducto.Setcodigo(int.Parse(tcodigo.Text));
            ClsProducto.Setnombre(tproducto.Text);
            ClsProducto.Setprecio(decimal.Parse(tprecio.Text));


            UsuarioLogica usuario = new UsuarioLogica();

            if (usuario.Modificar() > 0)

                MostrarAlerta(this, "Producto modificado con exito!");


            else
                MostrarAlerta(this, "Error al modificar Producto");

            LlenarGrid();
        }

        protected void bconsultar_Click(object sender, EventArgs e)
        {
            ClsProducto.Setcodigo(int.Parse(tcodigo.Text));
            ClsProducto.Setnombre(tproducto.Text);
            ClsProducto.Setprecio(decimal.Parse(tprecio.Text));

            ProductoLogica producto = new ProductoLogica();

            if (producto.Consultar() > 0)

                MostrarAlerta(this, "Producto consultado con exito!");


            else
                MostrarAlerta(this, "Error al encontrar producto");

            LlenarGrid();
        }
    }
}