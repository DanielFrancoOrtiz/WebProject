using System;
using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Descripción breve de Conexion
/// </summary>
public class Conexion
{
    public static MySqlConnection conexion;
    public bool Conectar()
    {
        string servidor = "localhost";
        string usuario = "root";
        string contrasenia = "root";
        string puerto = "3306";
        string database = "bd_bibis";

        String parametrosConexion = "Server=" + servidor + ";Uid=" + 
            usuario + ";Pwd=" + contrasenia + ";Database="+database+";Port=" + puerto + ";";
        conexion = new MySqlConnection(parametrosConexion);
        try
        {
            conexion.Open();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    }

    public DataTable ejecutarConsulta(String sentencia)
    {
        try
        {
            if (Conectar())
            {
                Conectar();
                MySqlDataAdapter objAdapter =
                    new MySqlDataAdapter(sentencia, conexion);
                DataTable resultado = new DataTable();
                objAdapter.Fill(resultado);
                return resultado;
            }
            else
            {
                return null;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
        finally
        {
            if (conexion != null)
                conexion.Close();
        }

    }


    public int ejecutarSentencia(String sentencia, bool esInsert)
    {
        try
        {
            if (Conectar())
            {
                Conectar();
                MySqlCommand objComando = new MySqlCommand(sentencia, conexion);
                objComando.ExecuteNonQuery();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        catch (Exception ex)
        {
            return 0;
        }
        finally
        {
            if (conexion != null)
                conexion.Close();
        }
    }

    public DataTable ejecutarConsulta(MySqlCommand com)
    {
        try
        {
            if (Conectar())
            {
                com.Connection = conexion;
                MySqlDataAdapter objAdapter = new MySqlDataAdapter(com);
                DataTable resultado = new DataTable();
                objAdapter.Fill(resultado);
                return resultado;
            }
            else
            {
                return null;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
        finally
        {
            if (conexion != null)
                conexion.Close();
        }

    }
}
