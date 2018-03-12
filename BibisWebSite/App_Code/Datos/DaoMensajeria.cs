using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Descripción breve de DaoMensajeria
/// </summary>
public class DaoMensajeria : IDAO<Mensajeria>
{
    public DaoMensajeria()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public int Insertar(Mensajeria obj)
    {
        try
        {
            String sentencia = String.Format("INSERT INTO mensajeria (nombre_mensajeria, email_mensajeria, telefono_mensajeria) " +
                "VALUES({0},{1},{2});",
                obj.Nombre_mensajeria,
                obj.Email_mensajeria,
                obj.Telefono_mensajeria);
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
    public int Actualizar(Mensajeria obj)
    {
        try
        {
            String sentencia = String.Format("UPDATE mensajeria SET nombre_mensajeria = {0}," +
                " email_mensajeria = {1}, telefono_mensajeria ={2} WHERE id = {3}",
                obj.Nombre_mensajeria,
                obj.Email_mensajeria,
                obj.Telefono_mensajeria,
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

    public Mensajeria Buscar(int id)
    {
        Mensajeria obj = null;
        try
        {
            Conexion con = new Conexion();
            DataTable dtCategorias = con.ejecutarConsulta("SELECT * FROM mensajeria WHERE id = " + id);
            if (dtCategorias != null && dtCategorias.Rows.Count > 0)
            {
                DataRow fila = dtCategorias.Rows[0];
                obj = new Mensajeria(int.Parse(fila["id"].ToString()), fila["nombre_mensajeria"].ToString(),
                    fila["email_mensajeria"].ToString(), fila["telefono_mensajeria"].ToString());
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

    public List<Mensajeria> ConsultarTodos()
    {
        List<Mensajeria> lista = new List<Mensajeria>();
        try
        {
            Conexion con = new Conexion();
            DataTable dt = con.ejecutarConsulta("select * from mensajeria");
            Mensajeria obj = null;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Mensajeria(int.Parse(fila["id"].ToString()), fila["nombre_mensajeria"].ToString(),
                    fila["email_mensajeria"].ToString(), fila["telefono_mensajeria"].ToString());
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
            String sentencia = "DELETE FROM mensajeria WHERE id = " + id;
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