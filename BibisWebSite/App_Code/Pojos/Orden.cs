using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;

/// <summary>
/// Descripción breve de Orden
/// </summary>
public class Orden
{


    public int Id { get; set; }
    public string Fecha_envio { get; set; }
    public string Fecha_entrega { get; set; }
    public string Ciudad { get; set; }
    public string Direccion { get; set; }
    public double Precio_envio { get; set; }
    public int Id_cliente { get; set; }
    public int Id_mensajeria { get; set; }


    public Orden()
    {
        
    }
    public Orden(int id, string fecha_envio, string fecha_entrega, string ciudad,
        string direccion, double precio_envio, int id_cliente, int id_mensajeria) {
        Id = id;
        Fecha_envio = fecha_envio;
        Fecha_entrega = fecha_entrega;
        Ciudad = ciudad;
        Direccion = direccion;
        Precio_envio = precio_envio;
        Id_cliente = id_cliente;
        Id_mensajeria = id_mensajeria;
    }
}