using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Descripción breve de DaoProducto
/// </summary>
public class DaoProducto : IDAO<Producto>
{
    public DaoProducto()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public int Insertar(Producto obj)
    {
        //try
        //{
            String sentencia = String.Format("INSERT INTO productos (Nombre, Modelo, Cantidad," +
                " Precio_compra, Precio_venta, Foto, id_proveedor, id_categoria, descripcion) " +
                "VALUES('{0}','{1}',{2},{3},{4},'{5}',{6},{7},{8});",
                obj.Nombre,
                obj.Modelo,
                obj.Cantidad,
                obj.Precio_compra,
                obj.Precio_venta,
                obj.Foto,
                obj.Id_proveedor,
                obj.Id_categoria,
                obj.Descripcion);
            Conexion con = new Conexion();
            return con.ejecutarSentencia(sentencia, true);
        //}
        //catch (Exception ex)
        //{
        //    return 0;
        //}
        //finally
        //{
        //    if (Conexion.conexion != null)
        //    {
        //        Conexion.conexion.Close();
        //    }
        //}
    }

    public int Actualizar(Producto obj)
    {
        //try
        //{
            String sentencia = String.Format("UPDATE productos SET Nombre = '{0}'," +
                " Modelo = '{1}', Cantidad ={2}, Precio_compra = {3}, Precio_venta = {4}," +
                " Foto = '{5}', id_proveedor = {6}, id_categoria = {7}, descripcion = {8} WHERE id = {9}",
                obj.Nombre,
                obj.Modelo,
                obj.Cantidad,
                obj.Precio_compra,
                obj.Precio_venta,
                obj.Foto,
                obj.Id_proveedor,
                obj.Id_categoria,
                obj.Descripcion,
                obj.Id);
            Conexion con = new Conexion();
            return con.ejecutarSentencia(sentencia, false);
        //}
        //catch (Exception ex)
        //{
        //    return 0;
        //}
        //finally
        //{
        //    if (Conexion.conexion != null)
        //    {
        //        Conexion.conexion.Close();
        //    }
        //}
    }

    public Producto Buscar(int id)
    {
        Producto obj = null;
        //try
        //{
            Conexion con = new Conexion();
            DataTable dtCategorias = con.ejecutarConsulta("SELECT * FROM productos WHERE id = " + id);
            if (dtCategorias != null && dtCategorias.Rows.Count > 0)
            {
                DataRow fila = dtCategorias.Rows[0];
               
                obj = new Producto(int.Parse(fila["id"].ToString()),fila["Nombre"].ToString(),
                    fila["Modelo"].ToString(), int.Parse(fila["Cantidad"].ToString()),
                    double.Parse(fila["Precio_compra"].ToString()),double.Parse(fila["Precio_venta"].ToString()),
                    fila["Foto"].ToString(),int.Parse(fila["id_proveedor"].ToString()),
                    int.Parse(fila["id_categoria"].ToString()),fila["descripcion"].ToString());
            }
            return obj;
        //}
        //catch (Exception ex)
        //{
        //    return obj;
        //}
        //finally
        //{
        //    if (Conexion.conexion != null)
        //    {
        //        Conexion.conexion.Close();
        //    }
        //}
    }

    public List<Producto> ConsultarTodos()
    {
        List<Producto> lista = new List<Producto>();
        //try
        //{
            Conexion con = new Conexion();
            DataTable dt = con.ejecutarConsulta("select * from productos");
            Producto obj = null;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Producto(int.Parse(fila["id"].ToString()), fila["Nombre"].ToString(),
                    fila["Modelo"].ToString(), int.Parse(fila["Cantidad"].ToString()),
                    double.Parse(fila["Precio_compra"].ToString()), double.Parse(fila["Precio_venta"].ToString()),
                    fila["Foto"].ToString(), int.Parse(fila["id_proveedor"].ToString()),
                    int.Parse(fila["id_categoria"].ToString()),fila["descripcion"].ToString());
                lista.Add(obj);
            }
            return lista;
        //}
        //catch (Exception ex)
        //{
        //    return lista;
        //}
        //finally
        //{
        //    if (Conexion.conexion != null)
        //    {
        //        Conexion.conexion.Close();
        //    }
        //}
    }

    public int Eliminar(int id)
    {
        //try
        //{
            String sentencia = "DELETE FROM productos WHERE id = " + id;
            Conexion con = new Conexion();
            return con.ejecutarSentencia(sentencia, false);
        //}
        //catch (Exception ex)
        //{
        //    return 0;
        //}
        //finally
        //{
        //    if (Conexion.conexion != null)
        //    {
        //        Conexion.conexion.Close();
        //    }
        //}
    }

    public DataTable LeerTodoss()
    {
        Conexion con = new Conexion();
        return con.ejecutarConsulta("select * from productos");
    }
}