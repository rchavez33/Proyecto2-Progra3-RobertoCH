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
using Proyecto2.Capa_Modelo;

namespace Proyecto2.Capa_Vistas
{
    public partial class Empleados : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Empleados"))
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
            
            ClsEmpleados.Setid(int.Parse(tid.Text));
            ClsEmpleados.Setnombre(tnombre.Text);
            ClsEmpleados.Setapellidop(tapellidop.Text);
            ClsEmpleados.Setapellidom(tapellidom.Text);
            ClsEmpleados.Setcorreo(tcorreo.Text);

            EmpleadosLogica empleado = new EmpleadosLogica();

            if (empleado.Agregar() > 0)

                MostrarAlerta(this, "Empleado ingresado con exito!");


            else
                MostrarAlerta(this, "Error al ingresar empleado");

            LlenarGrid();
        }

        protected void bborrar_Click(object sender, EventArgs e)
        {
            ClsEmpleados.Setid(int.Parse(tid.Text));


            EmpleadosLogica empleado = new EmpleadosLogica();

            if (empleado.Borrar() > 0)

                MostrarAlerta(this, "Empleado borrado con exito!");


            else
                MostrarAlerta(this, "Error al borrar empleado");

            LlenarGrid();
        }

        protected void bmodificar_Click(object sender, EventArgs e)
        {
            ClsEmpleados.Setid(int.Parse(tid.Text));
            ClsEmpleados.Setnombre(tnombre.Text);
            ClsEmpleados.Setapellidop(tapellidop.Text);
            ClsEmpleados.Setapellidom(tapellidom.Text);
            ClsEmpleados.Setcorreo(tcorreo.Text);


            EmpleadosLogica empleado = new EmpleadosLogica();

            if (empleado.Modificar() > 0)

                MostrarAlerta(this, "Empleado modificado con exito!");


            else
                MostrarAlerta(this, "Error al modificar empleado");

            LlenarGrid();
        }

        protected void bconsultar_Click(object sender, EventArgs e)
        {
            ClsEmpleados.Setid(int.Parse(tid.Text));
            ClsEmpleados.Setnombre(tnombre.Text);
            ClsEmpleados.Setapellidop(tapellidop.Text);
            ClsEmpleados.Setapellidom(tapellidom.Text);
            ClsEmpleados.Setcorreo(tcorreo.Text);

            EmpleadosLogica empleado = new EmpleadosLogica();

            if (empleado.Consultar() > 0)

                MostrarAlerta(this, "Empleado encontrado!");


            else
                MostrarAlerta(this, "Error al emcontrar empleado, posiblemente no exista...");

            LlenarGrid();
        }
        
    }
}
    
