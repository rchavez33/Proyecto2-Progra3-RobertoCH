using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Proyecto2.Capa_Negocio
{
    public class DBconn
    {
        public static SqlConnection obtenerConexion()
        {
            string rutaconexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(rutaconexion);
            conexion.Open();
            return conexion;
        }    
    }
}