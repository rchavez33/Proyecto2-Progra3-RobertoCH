using Proyecto2.Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Proyecto2.Capa_Negocio
{
    public class EmpleadosLogica
    {
        public int Agregar()
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("CrearEmpleado", Conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@EmpleadoID", ClsEmpleados.Getid()));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", ClsEmpleados.Getnombre()));
                    cmd.Parameters.Add(new SqlParameter("@ApellidoPaterno", ClsEmpleados.Getapellidop()));
                    cmd.Parameters.Add(new SqlParameter("@ApellidoMaterno", ClsEmpleados.Getapellidom()));
                    cmd.Parameters.Add(new SqlParameter("@Email", ClsEmpleados.Getcorreo()));

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
                    SqlCommand cmd = new SqlCommand("BorrarEmpleado", Conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@EmpleadoID", ClsEmpleados.Getid()));


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
                    SqlCommand cmd = new SqlCommand("ModificarEmpleado", Conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@EmpleadoID", ClsEmpleados.Getid()));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", ClsEmpleados.Getnombre()));
                    cmd.Parameters.Add(new SqlParameter("@ApellidoPaterno", ClsEmpleados.Getapellidop()));
                    cmd.Parameters.Add(new SqlParameter("@ApellidoMaterno", ClsEmpleados.Getapellidom()));
                    cmd.Parameters.Add(new SqlParameter("@Email", ClsEmpleados.Getcorreo()));

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
                    SqlCommand cmd = new SqlCommand("ConsultarEmpleado", Conn);

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add(new SqlParameter("@EmpleadoID", ClsEmpleados.Getid()));

                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("EmpleadoId: {0}", reader["UsuarioId"]);
                            Console.WriteLine("Nombre: {0}", reader["Nombre"]);
                            Console.WriteLine("Apellidop: {0}", reader["Apellidop"]);
                            Console.WriteLine("Apellidom: {0}", reader["Apellidom"]);
                            Console.WriteLine("Correo: {0}", reader["Correo"]);
                        }
                        retorno = 1; // Consulta exitosa
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún empleado con el ID proporcionado.");
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