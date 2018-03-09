using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descripción breve de DaoProveedor
/// </summary>
public class DaoProveedor : IDAO<Proveedor>
{
    public DaoProveedor()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int Insertar(Proveedor obj)
    {
        try
        {
            String sentencia = String.Format("INSERT INTO proveedores (nombre_proveedor, " +
                " email_proveedor, telefono_proveedor, direccion_proveedor, ciudad_proveedor) " +
                "VALUES({0},{1},{2},{3},{4});",
                obj.Nombre_proveedor,
                obj.Email_proveedor,
                obj.Telefono_proveedor,
                obj.Direccion_proveedor,
                obj.Ciudad_proveedor);
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

    public int Actualizar(Proveedor obj)
    {
        try
        {
            String sentencia = String.Format("UPDATE proveedores SET nombre_proveedor = {0}," +
                " email_proveedor = {1}, telefono_proveedor ={2}, direccion_proveedor = {3}," +
                " ciudad_proveedor = {4} WHERE id = {5}",
                obj.Nombre_proveedor,
                obj.Email_proveedor,
                obj.Telefono_proveedor,
                obj.Direccion_proveedor,
                obj.Ciudad_proveedor,
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

    public Proveedor Buscar(int id)
    {
        Proveedor obj = null;
        try
        {
            Conexion con = new Conexion();
            DataTable dtCategorias = con.ejecutarConsulta("SELECT * FROM proveedores WHERE id = " + id);
            if (dtCategorias != null && dtCategorias.Rows.Count > 0)
            {
                DataRow fila = dtCategorias.Rows[0];
                obj = new Proveedor(int.Parse(fila["id"].ToString()),
                    fila["nombre_proveedor"].ToString(), fila["email_proveedor"].ToString(),
                    fila["telefono_proveedor"].ToString(), fila["direccion_proveedor"].ToString(),
                    fila["ciudad_proveedor"].ToString());
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

    public List<Proveedor> ConsultarTodos()
    {
        List<Proveedor> lista = new List<Proveedor>();
        try
        {
            Conexion con = new Conexion();
            DataTable dt = con.ejecutarConsulta("select * from proveedores");
            Proveedor obj = null;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Proveedor(int.Parse(fila["id"].ToString()),
                     fila["nombre_proveedor"].ToString(), fila["email_proveedor"].ToString(),
                     fila["telefono_proveedor"].ToString(), fila["direccion_proveedor"].ToString(),
                     fila["ciudad_proveedor"].ToString());
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
            String sentencia = "DELETE FROM proveedores WHERE id = " + id;
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