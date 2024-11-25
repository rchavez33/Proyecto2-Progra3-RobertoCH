using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto2.Capa_Modelo
{
    public class ClsEmpleados
    {
        //atributos Clase Usuario
        private static int id;
        private static string nombre;
        private static string apellidop;
        private static string apellidom;
        private static string correo;

        public ClsEmpleados(int id, string nombre, string apellidop, string apellidom, string correo)
        {
            id = id;
            nombre = nombre;
            apellidop = apellidop;
            apellidom = apellidom;
            correo = correo;
        }

        //Getter - Setter
        public static int Getid()
        {
            return id;
        }

        public static void Setid(int empleadoid)
        {
            id = empleadoid;
        }
        public static string Getnombre()
        {
            return nombre;
        }

        public static void Setnombre(string nombreid)
        {
            nombre = nombreid;
        }

        public static string Getapellidop()
        {
            return apellidop;
        }

        public static void Setapellidop(string apellidopaterno)
        {
            apellidop = apellidopaterno;
        }
        public static string Getapellidom()
        {
            return apellidom;
        }

        public static void Setapellidom(string apellidomaterno)
        {
            apellidop = apellidomaterno;
        }
        public static string Getcorreo()
        {
            return correo;
        }

        public static void Setcorreo(string email)
        {
            correo = email;
        }
        public ClsEmpleados() { }
    }
}