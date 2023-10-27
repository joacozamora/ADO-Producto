using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Data.OleDb;

namespace CapaDatos
{
    public class AdminisProductos : DatosConexion
    {
        public int abmProductos(string accion, Productos objProductos)
        {
            int resultado = -1; // controlar que se realice la operacion con exito
            string orden = string.Empty; //para guardar consulta sql

            if (accion == "Alta") // para agregar un producto nuevo
                orden = "insert into Productos values (" +"'"+ objProductos.d_nombre +
               "', " + objProductos.d_codigo + ", " + objProductos.d_precio + ", '" + objProductos.d_genero + "');";
            
            if (accion == "Modificar") // para modificar un existente
                orden = $"update Productos set Nombre = '{objProductos.d_nombre}' where Codigo = {objProductos.d_codigo}; update Productos set Precio = '{objProductos.d_precio}' where Codigo = {objProductos.d_codigo}; update Productos set Genero = '{objProductos.d_genero}' where Codigo = {objProductos.d_codigo}; ";
            /*orden = "update Productos set Nombre='" + "' " +objProductos.d_nombre + "', Precio = " + objProductos.d_precio
                + ", Genero = '" + objProductos.d_genero + "'" +
"where Codigo=" + objProductos.d_codigo + "; ";*/

            // falta la orden de borrar
            if (accion == "Borrar")
                orden = "DELETE FROM Productos WHERE Codigo = " + objProductos.d_codigo + "; ";


             SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar de Productos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;


        }

        public DataSet listadoProductos(string cual) //para 1 o todos los datos segun el código
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Productos where Codigo = " + int.Parse(cual) + ";";
            else
                orden = "select * from Productos";
            SqlCommand cmd = new SqlCommand(orden, conexion);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar productos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

        public DataSet ListarProductoEliminar(string id)
        {
            string orden = $"delete from Producto where cod = {id};";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar el producto", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

        //public DataSet ListarCajaEliminar(string id)
        //{

        //	string orden = $"delete from Productos where Id = {id}";

        //	SqlCommand cmd = new SqlCommand(orden, conexion);
        //	DataSet ds = new DataSet();
        //	SqlDataAdapter da = new SqlDataAdapter();
        //	try
        //	{
        //		Abrirconexion();
        //		cmd.ExecuteNonQuery();
        //		da.SelectCommand = cmd;
        //		da.Fill(ds);
        //	}
        //	catch (Exception e)
        //	{
        //		throw new Exception("Error al eliminar los detalles ", e);
        //	}
        //	finally
        //	{
        //		Cerrarconexion();
        //		cmd.Dispose();
        //	}
        //	return ds;
        //}
    }
}
