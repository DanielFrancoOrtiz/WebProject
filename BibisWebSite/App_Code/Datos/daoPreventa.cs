using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de daoPreventa
/// </summary>
public class daoPreventa : IDAO <Pre_venta>
{
    public daoPreventa()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int Actualizar(Pre_venta obj)
    {
        throw new NotImplementedException();
    }

    public Pre_venta Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public List<Pre_venta> ConsultarTodos()
    {
        List<Pre_venta> lista = new List<Pre_venta>();
        try
        {
            Conexion con = new Conexion();
            DataTable dt = con.ejecutarConsulta("select * from pre_venta");
            Pre_venta obj = null;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Pre_venta(int.Parse(fila["id_Pventa"].ToString()), fila["nombreP"].ToString(),
                   Convert.ToDouble( fila["precioV"].ToString()));
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
            String sentencia = "DELETE FROM pre_venta WHERE id_Pventa = " + id;
            Conexion con = new Conexion();
            return con.ejecutarSentencia(sentencia, false);
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

    public int Insertar(Pre_venta obj)
    {
        try
        {
            String sentencia = String.Format("INSERT INTO pre_venta (nombreP, precioV) " +
                "VALUES ('{0}','{1}')",
                obj.Nombre,
                obj.Precio);
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

    public DataTable LeerTodoss()
    {
        throw new NotImplementedException();
    }
}
public class Pre_venta
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Pre_venta()
    {
    }
    public Pre_venta(int id, string nombre, double precio)
    {
        this.Id = id;
        this.Nombre = nombre;
        this.Precio = precio;
    }

}