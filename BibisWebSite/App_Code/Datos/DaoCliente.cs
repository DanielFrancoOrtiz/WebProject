using System;
using System.Collections.Generic;
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
        //try
        //{
            String sentencia = String.Format("INSERT INTO clientes (Nombre, Apellidos, email, Telefono," +
                " Direccion, Ciudad, Codigo_postal) " +
                "VALUES('{0}', '{1}',{2}, '{3}', '{4}', '{5}', '{6}');",
                obj.Nombre, obj.Apellidos, obj.Email, obj.Telefono, obj.Direccion, obj.Ciudad, obj.Codigo_postal);
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

    public int Actualizar(Cliente obj)
    {
        //try
        //{
            String sentencia = String.Format("UPDATE clientes SET Nombre = '{0}'," +
                " Apellidos = '{1}', Email = {2}, Telefono = '{3}', Direccion= '{4}', Ciudad = '{5}'," +
                " Codigo_postal = '{6}' WHERE id = {7}",
                obj.Nombre,obj.Apellidos,obj.Email,obj.Telefono,obj.Direccion,obj.Ciudad,obj.Codigo_postal,obj.Id);
            Conexion con = new Conexion();
            return bool.Parse(con.ejecutarSentencia(sentencia, false).ToString()) ? 1 : 0;
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

    public Cliente Buscar(int id)
    {
        Cliente obj = null;
        //try
        //{
            Conexion con = new Conexion();
            DataTable dtCategorias = con.ejecutarConsulta("SELECT * FROM clientes WHERE id = " + id);
            if (dtCategorias != null && dtCategorias.Rows.Count > 0)
            {
                DataRow fila = dtCategorias.Rows[0];
                obj = new Cliente(int.Parse(fila["id"].ToString()), fila["Nombre"].ToString(),
                    fila["Apellidos"].ToString(),fila["Email"].ToString(), fila["Telefono"].ToString(), fila["Direccion"].ToString(),
                    fila["Ciudad"].ToString(), fila["Codigo_postal"].ToString());
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

    public List<Cliente> ConsultarTodos()
    {
        List<Cliente> lista = new List<Cliente>();
        //try
        //{
            Conexion con = new Conexion();
            DataTable dt = con.ejecutarConsulta("select * from clientes");
            Cliente obj = null;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Cliente(int.Parse(fila["id"].ToString()), fila["Nombre"].ToString(),
                    fila["Apellidos"].ToString(),fila["Email"].ToString(), fila["Telefono"].ToString(), fila["Direccion"].ToString(),
                    fila["Ciudad"].ToString(), fila["Codigo_postal"].ToString());
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
            String sentencia = "DELETE FROM clientes WHERE id = " + id;
            Conexion con = new Conexion();
            return bool.Parse(con.ejecutarSentencia(sentencia, false).ToString()) ? 1 : 0;
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
        return con.ejecutarConsulta("select * from clientes");
    }
}