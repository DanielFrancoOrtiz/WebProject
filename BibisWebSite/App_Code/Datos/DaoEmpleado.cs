using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Descripción breve de DaoEmpleado
/// </summary>
public class DaoEmpleado : IDAO<Empleado>
{
    public DaoEmpleado()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int Insertar(Empleado obj)
    {
        try
        {
            String sentencia = String.Format("INSERT INTO empleados (nombre, apellidos, usuario," +
                " puesto, email, telefono, direccion, pass) " +
                "VALUES({0},{1},{2},{3},{4},{5},{6},{7});",
                obj.Nombre,
                obj.Apellidos,
                obj.Usuario,
                obj.Puesto,
                obj.Email,
                obj.Direccion,
                obj.Pass);
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

    public int Actualizar(Empleado obj)
    {
        try
        {
            String sentencia = String.Format("UPDATE empleados SET nombre = {0}," +
                " apellidos = {1}, usuario ={2}, puesto = {3}, email = {4}, telefono = {5}," +
                " direccion = {6}, pass = {7} WHERE id = {8}",
                obj.Nombre,
                obj.Apellidos,
                obj.Usuario,
                obj.Puesto,
                obj.Email,
                obj.Telefono,
                obj.Direccion,
                obj.Pass, obj.Id);
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

    public Empleado Buscar(int id)
    {
        Empleado obj = null;
        try
        {
            Conexion con = new Conexion();
            DataTable dtCategorias = con.ejecutarConsulta("SELECT * FROM empleados WHERE id = " + id);
            if (dtCategorias != null && dtCategorias.Rows.Count > 0)
            {
                DataRow fila = dtCategorias.Rows[0];
                obj = new Empleado(int.Parse(fila["id"].ToString()), fila["nombre"].ToString(),
                    fila["apellidos"].ToString(), fila["usuario"].ToString(), fila["puesto"].ToString(),
                    fila["email"].ToString(), fila["telefono"].ToString(), fila["direccion"].ToString(),
                    fila["pass"].ToString());
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

    public List<Empleado> ConsultarTodos()
    {
        List<Empleado> lista = new List<Empleado>();
        try
        {
            Conexion con = new Conexion();
            DataTable dt = con.ejecutarConsulta("select * from empleados");
            Empleado obj = null;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Empleado(int.Parse(fila["id"].ToString()), fila["nombre"].ToString(),
                   fila["apellidos"].ToString(), fila["usuario"].ToString(), fila["puesto"].ToString(),
                   fila["email"].ToString(), fila["telefono"].ToString(), fila["direccion"].ToString(),
                   fila["pass"].ToString());
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
            String sentencia = "DELETE FROM empleados WHERE id = " + id;
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