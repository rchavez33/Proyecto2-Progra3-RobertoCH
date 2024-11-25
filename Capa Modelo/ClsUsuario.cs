using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto2
{
    public class ClsUsuario
    {
        //atributos Clase Usuario
        private static int id;
        private static string usuario;
        private static string clave;


        //Constructor
        public ClsUsuario(int id, string usuario, string clave)
        {
            id = id;
            usuario = usuario;
            clave = clave;
        }

        //Getter - Setter
        public static int Getid()
        {
            return id;
        }

        public static void Setid(int usuarioid)
        {
            id = usuarioid;
        }
        public static string Getusuario() 
        {
            return usuario;
        }

        public static void Setusuario(string nombre) 
        { 
            usuario = nombre; 
        }

        public static string Getclave()
        {
            return clave;
        }

        public static void Setclave(string contrasenia)
        {
            clave = contrasenia;
        }
    }
}