using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Descripción breve de DaoDetalle_orden
/// </summary>
public class DaoDetalle_orden : IDAO<Detalle_orden>
{
    public DaoDetalle_orden()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public int Insertar(Detalle_orden obj)
    {
        //try
        //{
            String sentencia = String.Format("INSERT INTO detalles_ordenes (precio, cantidad, id_orden) " +
                "VALUES({0},{1},{2});",
                obj.Precio,
                obj.Cantidad,
                obj.Id_orden);
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

    public int Actualizar(Detalle_orden obj)
    {
        //try
        //{
            String sentencia = String.Format("UPDATE detalles_ordenes SET precio = {0}," +
                " cantidad = {1}, id_orden ={2} WHERE id = {3}",
                obj.Precio,
                obj.Cantidad,
                obj.Id_orden,
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

    public Detalle_orden Buscar(int id)
    {
        Detalle_orden obj = null;
        //try
        //{
            Conexion con = new Conexion();
            DataTable dtCategorias = con.ejecutarConsulta("SELECT * FROM detalles_ordenes WHERE id = " + id);
            if (dtCategorias != null && dtCategorias.Rows.Count > 0)
            {
                DataRow fila = dtCategorias.Rows[0];
                obj = new Detalle_orden(int.Parse(fila["id"].ToString()), double.Parse(fila["precio"].ToString()),
                    int.Parse(fila["cantidad"].ToString()), int.Parse(fila["id_orden"].ToString()));
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

    public List<Detalle_orden> ConsultarTodos()
    {
        List<Detalle_orden> lista = new List<Detalle_orden>();
        //try
        //{
            Conexion con = new Conexion();
            DataTable dt = con.ejecutarConsulta("select * from detalles_ordenes");
            Detalle_orden obj = null;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Detalle_orden(int.Parse(fila["id"].ToString()), double.Parse(fila["precio"].ToString()),
                    int.Parse(fila["cantidad"].ToString()), int.Parse(fila["id_orden"].ToString()));
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
            String sentencia = "DELETE FROM detalles_ordenes WHERE id = " + id;
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
        return con.ejecutarConsulta("select * from detalles_ordenes");
    }
}