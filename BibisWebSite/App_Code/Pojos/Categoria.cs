﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Categoria
/// </summary>
public class Categoria
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public Categoria()
    {
    }
    public Categoria(int id, string nombre, string descripcion) {
        Id = id;
        Nombre = nombre;
        Descripcion = descripcion;
    }

}