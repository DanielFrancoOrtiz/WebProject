using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;
using System.Data;
using Newtonsoft.Json;
namespace ServicioEmpleados
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private DaoEmpleado d = new DaoEmpleado();
        [WebMethod]
        public string HelloWorld(){
            return "Hola a todos";
        }
        [WebMethod]
        public int Insertar(string param) {
            return d.Insertar(JsonConvert.DeserializeObject<Empleado>(param));
        }
        [WebMethod]
        public int Actualizar(string param) {
            return d.Actualizar(JsonConvert.DeserializeObject<Empleado>(param));
        }

        [WebMethod]
        public string Buscar(int id){
            return JsonConvert.SerializeObject(d.Buscar(id));
        }

        [WebMethod]
        public string ConsultarTodos() {
           return JsonConvert.SerializeObject(d.ConsultarTodos());
        }

        [WebMethod]
        public int Eliminar(int id) {
            return d.Eliminar(id);
        }
        


    }

    public class DaoEmpleado {
        public DaoEmpleado()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        public int Insertar(Empleado obj)
        {
            //try
            //{
            String sentencia = String.Format("INSERT INTO empleados (Nombre, Apellidos, Usuario," +
                " Puesto, Email, Telefono, Direccion, Pass) " +
                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');",
                obj.Nombre,
                obj.Apellidos,
                obj.Usuario,
                obj.Puesto,
                obj.Email,
                obj.Telefono,
                obj.Direccion,
                obj.Pass);
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

        public int Actualizar(Empleado obj)
        {
            //try
            //{
            String sentencia = String.Format("UPDATE empleados SET Nombre = '{0}'," +
                " Apellidos = '{1}', Usuario = '{2}', Puesto = '{3}', Email = '{4}', Telefono = '{5}'," +
                " Direccion = '{6}', Pass = '{7}' WHERE id = {8}",
                obj.Nombre,
                obj.Apellidos,
                obj.Usuario,
                obj.Puesto,
                obj.Email,
                obj.Telefono,
                obj.Direccion,
                obj.Pass, obj.Id);
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

        public Empleado Buscar(int id)
        {
            Empleado obj = null;
            //try
            //{
            Conexion con = new Conexion();
            DataTable dtCategorias = con.ejecutarConsulta("SELECT * FROM empleados WHERE id = " + id);
            if (dtCategorias != null && dtCategorias.Rows.Count > 0)
            {
                DataRow fila = dtCategorias.Rows[0];
                obj = new Empleado(int.Parse(fila["id"].ToString()), fila["Nombre"].ToString(),
                    fila["Apellidos"].ToString(), fila["Usuario"].ToString(), fila["Puesto"].ToString(),
                    fila["Email"].ToString(), fila["Telefono"].ToString(), fila["Direccion"].ToString(),
                    fila["Pass"].ToString());
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

        public List<Empleado> ConsultarTodos()
        {
            List<Empleado> lista = new List<Empleado>();
            //try
            //{
            Conexion con = new Conexion();
            DataTable dt = con.ejecutarConsulta("select * from empleados");
            Empleado obj = null;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Empleado(int.Parse(fila["id"].ToString()), fila["Nombre"].ToString(),
                   fila["Apellidos"].ToString(), fila["Usuario"].ToString(), fila["Puesto"].ToString(),
                   fila["Email"].ToString(), fila["Telefono"].ToString(), fila["Direccion"].ToString(),
                   fila["Pass"].ToString());
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
            String sentencia = "DELETE FROM empleados WHERE id = " + id;
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
    }
    public class Conexion
    {
        public static MySqlConnection conexion;
        public bool Conectar()
        {
            string servidor = "localhost";
            string usuario = "Franco";
            string contrasenia = "root";
            string puerto = "3306";
            string database = "bd_empleados_bibis";

            String parametrosConexion = "Server=" + servidor + ";Uid=" +
                usuario + ";Pwd=" + contrasenia + ";Database=" + database + ";Port=" + puerto + ";";
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
            //try
            //{
            //    if (Conectar())
            //    {
            Conectar();
            MySqlDataAdapter objAdapter =
                new MySqlDataAdapter(sentencia, conexion);
            DataTable resultado = new DataTable();
            objAdapter.Fill(resultado);
            return resultado;
            //    }
            //    else
            //    {
            //        return null;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return null;
            //}
            //finally
            //{
            //    if (conexion != null)
            //        conexion.Close();
            //}

        }


        public int ejecutarSentencia(String sentencia, bool esInsert)
        {
            //try
            //{
            //    if (Conectar())
            //    {
            Conectar();
            MySqlCommand objComando = new MySqlCommand(sentencia, conexion);
            objComando.ExecuteNonQuery();
            return 1;
            //    }
            //    else
            //    {
            //        return 0;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return 0;
            //}
            //finally
            //{
            //    if (conexion != null)
            //        conexion.Close();
            //}
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
    public class Empleado {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Usuario { get; set; }
        public string Puesto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Pass { get; set; }

        public Empleado()
        {

        }
        public Empleado(int id, string nombre, string apellidos,
            string usuario, string puesto, string email, string telefono, string direccion, string pass)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Usuario = usuario;
            Puesto = puesto;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
            Pass = pass;
        }
    }
    

}
