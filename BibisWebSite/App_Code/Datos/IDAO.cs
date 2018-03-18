using System.Collections.Generic;
using System.Data;


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
    DataTable LeerTodoss();
}