using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Descripción breve de DaoCategoria
/// </summary>
public class DaoCategoria : IDAO<Categoria>
{
    public DaoCategoria()
    {
    }


    public int Insertar(Categoria obj)
    {
        //try
        //{
            String sentencia = String.Format("INSERT INTO categorias (nombre, descripcion) " +
                "VALUES ('{0}','{1}')",
                obj.Nombre,
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

    public int Actualizar(Categoria obj)
    {
        //try
        //{
            String sentencia = String.Format("UPDATE categorias SET nombre = '{0}'," +
                " descripcion = '{1}' WHERE id = {2}",
                obj.Nombre,
                obj.Descripcion,
                obj.Id);
            Conexion con = new Conexion();
            return bool.Parse(con.ejecutarSentencia(sentencia, false).ToString()) ? 1 : 0 ;
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


    public Categoria Buscar(int id)
    {
        Categoria obj = null;
        //try
        //{
            Conexion con = new Conexion();
            DataTable dtCategorias = con.ejecutarConsulta("SELECT * FROM categorias WHERE id = " + id);
            if (dtCategorias != null && dtCategorias.Rows.Count > 0)
            {
                DataRow fila = dtCategorias.Rows[0];
                obj = new Categoria(int.Parse(fila["id"].ToString()), fila["nombre"].ToString(),
                    fila["descripcion"].ToString());
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

    public List<Categoria> ConsultarTodos()
    {
        List<Categoria> lista = new List<Categoria>();
        //try
        //{
            Conexion con = new Conexion();
            DataTable dt = con.ejecutarConsulta("select * from categorias");
            Categoria obj = null;
            foreach (DataRow fila in dt.Rows) {
                obj = new Categoria(int.Parse(fila["id"].ToString()), fila["nombre"].ToString(),
                    fila["descripcion"].ToString());
                lista.Add(obj);
            }
            return lista;
        //}catch(Exception ex)
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
            String sentencia = "DELETE FROM categorias WHERE id = " + id;
            Conexion con = new Conexion();
            return bool.Parse(con.ejecutarSentencia(sentencia, false).ToString()) ? 1 : 0 ;
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
        return con.ejecutarConsulta("select * from categorias");
    }
}