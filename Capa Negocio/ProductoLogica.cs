using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Proyecto2.Capa_Modelo;

namespace Proyecto2.Capa_Negocio
{
    public class ProductoLogica
    {
        public int Agregar()
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AgregarProducto", Conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Codigo", ClsProducto.Getcodigo()));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", ClsProducto.Getnombre()));
                    cmd.Parameters.Add(new SqlParameter("@Precio", ClsProducto.Getprecio()));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public int Borrar()
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BorrarProducto", Conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Codigo", ClsProducto.Getcodigo()));


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public int Modificar()
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ModificarProducto", Conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Codigo", ClsProducto.Getcodigo()));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", ClsProducto.Getnombre()));
                    cmd.Parameters.Add(new SqlParameter("@Precio", ClsProducto.Getprecio()));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }


        public int Consultar()
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ConsultarProductos", Conn);

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add(new SqlParameter("@Codigo", ClsProducto.Getcodigo()));

                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("Codigo: {0}", reader["Codigo"]);
                            Console.WriteLine("Nombre: {0}", reader["Nombre"]);
                            Console.WriteLine("Precio: {0}", reader["Precio"]);
                        }
                        retorno = 1; // Consulta exitosa
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún producto con el ID proporcionado.");
                        retorno = 0; // No se encontraron resultados
                    }
                    reader.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
    }
}