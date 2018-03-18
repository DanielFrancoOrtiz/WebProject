using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Descripción breve de DaoOrden
/// </summary>
public class DaoOrden : IDAO<Orden>
{
    public DaoOrden()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int Insertar(Orden obj)
    {
        try
        {
            String sentencia = String.Format("INSERT INTO ordenes (fecha_envio, fecha_entrega, ciudad," +
                " direccion, precio_envio, id_cliente, id_mensajeria) " +
                "VALUES({0},{1},{2},{3},{4},{5},{6});",
                obj.Fecha_envio,
                obj.Fecha_entrega,
                obj.Ciudad,
                obj.Direccion,
                obj.Precio_envio,
                obj.Id_cliente,
                obj.Id_mensajeria);
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

    public int Actualizar(Orden obj)
    {
        try
        {
            String sentencia = String.Format("UPDATE ordenes SET fecha_envio = {0}," +
                " fecha_entrega = {1}, ciudad ={2}, direccion = {3}, precio_envio = {4}," +
                " id_cliente = {5}, id_mensajeria = {6} WHERE id = {7}",
                obj.Fecha_envio,
                obj.Fecha_entrega,
                obj.Ciudad,
                obj.Direccion,
                obj.Precio_envio,
                obj.Id_cliente,
                obj.Id_mensajeria,
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

    public Orden Buscar(int id)
    {
        Orden obj = null;
        try
        {
            Conexion con = new Conexion();
            DataTable dtCategorias = con.ejecutarConsulta("SELECT * FROM ordenes WHERE id = " + id);
            if (dtCategorias != null && dtCategorias.Rows.Count > 0)
            {
                DataRow fila = dtCategorias.Rows[0];
                obj = new Orden(int.Parse(fila["id"].ToString()), fila["fecha_envio"].ToString(),
                    fila["fecha_entrega"].ToString(), fila["ciudad"].ToString(), fila["direccion"].ToString(),
                    double.Parse(fila["precio_envio"].ToString()), int.Parse(fila["id_cliente"].ToString()),
                    int.Parse(fila["id_mensajeria"].ToString()));

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

    public List<Orden> ConsultarTodos()
    {
        List<Orden> lista = new List<Orden>();
        try
        {
            Conexion con = new Conexion();
            DataTable dt = con.ejecutarConsulta("select * from ordenes");
            Orden obj = null;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Orden(int.Parse(fila["id"].ToString()), fila["fecha_envio"].ToString(),
                    fila["fecha_entrega"].ToString(), fila["ciudad"].ToString(), fila["direccion"].ToString(),
                    double.Parse(fila["precio_envio"].ToString()), int.Parse(fila["id_cliente"].ToString()),
                    int.Parse(fila["id_mensajeria"].ToString()));
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
            String sentencia = "DELETE FROM ordenes WHERE id = " + id;
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

    public DataTable LeerTodoss()
    {
        Conexion con = new Conexion();
        return con.ejecutarConsulta("select * from ordenes");
    }
}