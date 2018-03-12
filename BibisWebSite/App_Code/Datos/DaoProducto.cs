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
        try
        {
            String sentencia = String.Format("INSERT INTO productos (nombre, modelo, cantidad," +
                " precio_compra, precio_venta, foto, id_proveedor, id_categoria) " +
                "VALUES({0},{1},{2},{3},{4},{5},{6},{7});",
                obj.Nombre,
                obj.Modelo,
                obj.Cantidad,
                obj.Precio_compra,
                obj.Precio_venta,
                obj.Foto,
                obj.Id_proveedor,
                obj.Id_categoria);
            Conexion con = new Conexion();
            return con.ejecutarSentencia(sentencia, true);
        }
        catch (Exception ex)
        {
            return 0;
        }
        finally
        {
            if (Conexion.conexion != null)
            {
                Conexion.conexion.Close();
            }
        }
    }

    public int Actualizar(Producto obj)
    {
        try
        {
            String sentencia = String.Format("UPDATE productos SET nombre = {0}," +
                " modelo = {1}, cantidad ={2}, precio_compra = {3}, precio_venta = {4}," +
                " foto = {5}, id_proveedor = {6}, id_categoria = {7} WHERE id = {8}",
                obj.Nombre,
                obj.Modelo,
                obj.Cantidad,
                obj.Precio_compra,
                obj.Precio_venta,
                obj.Foto,
                obj.Id_proveedor,
                obj.Id_categoria,
                obj.Id);
            Conexion con = new Conexion();
            return bool.Parse(con.ejecutarSentencia(sentencia, false).ToString()) ? 1 : 0;
        }
        catch (Exception ex)
        {
            return 0;
        }
        finally
        {
            if (Conexion.conexion != null)
            {
                Conexion.conexion.Close();
            }
        }
    }

    public Producto Buscar(int id)
    {
        Producto obj = null;
        try
        {
            Conexion con = new Conexion();
            DataTable dtCategorias = con.ejecutarConsulta("SELECT * FROM productos WHERE id = " + id);
            if (dtCategorias != null && dtCategorias.Rows.Count > 0)
            {
                DataRow fila = dtCategorias.Rows[0];
               
                obj = new Producto(int.Parse(fila["id"].ToString()),fila["nombre"].ToString(),
                    fila["modelo"].ToString(), int.Parse(fila["cantidad"].ToString()),
                    double.Parse(fila["precio_compra"].ToString()),double.Parse(fila["precio_venta"].ToString()),
                    fila["foto"].ToString(),int.Parse(fila["id_proveedor"].ToString()),
                    int.Parse(fila["id_categoria"].ToString()));
            }
            return obj;
        }
        catch (Exception ex)
        {
            return obj;
        }
        finally
        {
            if (Conexion.conexion != null)
            {
                Conexion.conexion.Close();
            }
        }
    }

    public List<Producto> ConsultarTodos()
    {
        List<Producto> lista = new List<Producto>();
        try
        {
            Conexion con = new Conexion();
            DataTable dt = con.ejecutarConsulta("select * from productos");
            Producto obj = null;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Producto(int.Parse(fila["id"].ToString()), fila["nombre"].ToString(),
                    fila["modelo"].ToString(), int.Parse(fila["cantidad"].ToString()),
                    double.Parse(fila["precio_compra"].ToString()), double.Parse(fila["precio_venta"].ToString()),
                    fila["foto"].ToString(), int.Parse(fila["id_proveedor"].ToString()),
                    int.Parse(fila["id_categoria"].ToString()));
                lista.Add(obj);
            }
            return lista;
        }
        catch (Exception ex)
        {
            return lista;
        }
        finally
        {
            if (Conexion.conexion != null)
            {
                Conexion.conexion.Close();
            }
        }
    }

    public int Eliminar(int id)
    {
        try
        {
            String sentencia = "DELETE FROM productos WHERE id = " + id;
            Conexion con = new Conexion();
            return bool.Parse(con.ejecutarSentencia(sentencia, false).ToString()) ? 1 : 0;
        }
        catch (Exception ex)
        {
            return 0;
        }
        finally
        {
            if (Conexion.conexion != null)
            {
                Conexion.conexion.Close();
            }
        }
    }

    
}