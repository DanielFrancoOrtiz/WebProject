using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Detalle_orden
/// </summary>
public class Detalle_orden
{

    public int Id { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }
    public int Id_orden { get; set; }

    public Detalle_orden()
    {
       
    }
    public Detalle_orden(int id, double precio, int cantidad, int id_orden) {
        Id = id;
        Precio = precio;
        Cantidad = cantidad;
        Id_orden = id_orden;
    }
}