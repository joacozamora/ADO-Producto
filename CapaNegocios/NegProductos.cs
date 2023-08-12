using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using CapaDatos;

namespace CapaNegocios
{
    public class NegProductos
    {
        AdminisProductos DatosObjProducto = new AdminisProductos();

        public int abmProductos(string accion, Productos objProducto)
        {
            return DatosObjProducto.abmProductos(accion, objProducto);
        }

        public DataSet listadoProductos(string cual)
        {
            return DatosObjProducto.listadoProductos(cual);
        }
    }
}
