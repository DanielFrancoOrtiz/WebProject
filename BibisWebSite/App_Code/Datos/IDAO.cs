using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de IDAO
/// </summary>
interface IDAO<T>
{
    int Insertar(T obj);
    int Actualizar(T obj);
    int Eliminar(int id);
    T Buscar(int id);
    List<T> ConsultarTodos();
}