using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Capa_Negocio
{
    internal interface IntEmpleados
    {
        int Agregar();
        int Borrar();
        int Modificar();
        int Consultar();
    }
}
