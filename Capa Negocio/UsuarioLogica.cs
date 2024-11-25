using Proyecto2.Capa_Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Proyecto2.Capa_Negocio
{
    public class UsuarioLogica
    {
        public int Agregar()
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AgregarUsuario", Conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@UsuarioId", ClsUsuario.Getid()));
                    cmd.Parameters.Add(new SqlParameter("@Usuario", ClsUsuario.Getusuario()));
                    cmd.Parameters.Add(new SqlParameter("@Clave", ClsUsuario.Getclave()));

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
                    SqlCommand cmd = new SqlCommand("BorrarUsuario", Conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@UsuarioId", ClsUsuario.Getid()));


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
                    SqlCommand cmd = new SqlCommand("ModificarUsuario", Conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@UsuarioId", ClsUsuario.Getid()));
                    cmd.Parameters.Add(new SqlParameter("@Usuario", ClsUsuario.Getusuario()));
                    cmd.Parameters.Add(new SqlParameter("@Clave", ClsUsuario.Getclave()));

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
                    SqlCommand cmd = new SqlCommand("ConsultarUsuario", Conn);

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add(new SqlParameter("@UsuarioId", ClsUsuario.Getid()));

                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("UsuarioId: {0}", reader["UsuarioId"]);
                            Console.WriteLine("Usuario: {0}", reader["Usuario"]);
                            Console.WriteLine("Clave: {0}", reader["Clave"]);
                        }
                        retorno = 1; // Consulta exitosa
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún usuario con el ID proporcionado.");
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



