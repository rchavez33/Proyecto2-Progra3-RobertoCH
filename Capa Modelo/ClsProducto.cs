using Proyecto2.Capa_Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace Proyecto2.Capa_Modelo
{
    public class ClsProducto
    {
        //atributos Clase Usuario
        private static int codigo;
        private static string nombre;
        private static decimal precio;
        public ClsProducto(int codigo, string nombre, float precio)
        {
            codigo = codigo;
            nombre = nombre;
            precio = precio;
        }

        //Getter - Setter
        public static int Getcodigo()
        {
            return codigo;
        }

        public static void Setcodigo(int codigoid)
        {
            codigo = codigoid;
        }
        public static string Getnombre()
        {
            return nombre;
        }

        public static void Setnombre(string nombreid)
        {
            nombre = nombreid;
        }

        public static decimal Getprecio()
        {
            return precio;
        }

        public static void Setprecio(decimal valor)
        {
            precio = valor;
        }

        public ClsProducto() { }

        

    }
}