using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descripción breve de DaoCliente
/// </summary>
public class DaoCliente : IDAO<Cliente>
{
    public DaoCliente()
    {
    }
    public int Insertar(Cliente obj)
    {
        try
        {
            String sentencia = String.Format("INSERT INTO categorias (nombre, apellidos, telefono," +
                " direccion, ciudad, codigo_postal) " +
                "VALUES({0},{1},{2},{3},{4},{5});",
                obj.Nombre, obj.Apellidos, obj.Telefono, obj.Direccion, obj.Ciudad, obj.Codigo_postal);
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

    public int Actualizar(Cliente obj)
    {
        try
        {
            String sentencia = String.Format("UPDATE clientes SET nombre = {0}," +
                " apellidos = {1}, telefono={2}, direccion{3}, ciudad={4}, codigo_postal = {5} WHERE id = {6}",
                obj.Nombre,obj.Apellidos,obj.Telefono,obj.Direccion,obj.Ciudad,obj.Codigo_postal,obj.Id);
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

    public Cliente Buscar(int id)
    {
        Cliente obj = null;
        try
        {
            Conexion con = new Conexion();
            DataTable dtCategorias = con.ejecutarConsulta("SELECT * FROM clientes WHERE id = " + id);
            if (dtCategorias != null && dtCategorias.Rows.Count > 0)
            {
                DataRow fila = dtCategorias.Rows[0];
                obj = new Cliente(int.Parse(fila["id"].ToString()), fila["nombre"].ToString(),
                    fila["apellidos"].ToString(), fila["telefono"].ToString(), fila["direccion"].ToString(),
                    fila["ciudad"].ToString(), fila["codigo_postal"].ToString());
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

    public List<Cliente> ConsultarTodos()
    {
        List<Cliente> lista = new List<Cliente>();
        try
        {
            Conexion con = new Conexion();
            DataTable dt = con.ejecutarConsulta("select * from clientes");
            Cliente obj = null;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Cliente(int.Parse(fila["id"].ToString()), fila["nombre"].ToString(),
                    fila["apellidos"].ToString(), fila["telefono"].ToString(), fila["direccion"].ToString(),
                    fila["ciudad"].ToString(), fila["codigo_postal"].ToString());
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
            String sentencia = "DELETE FROM clientes WHERE id = " + id;
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