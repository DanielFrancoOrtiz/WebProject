using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Empleado
/// </summary>
public class Empleado
{
 
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
        string usuario, string puesto, string email,string telefono, string direccion, string pass ) {
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