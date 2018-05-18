
/// <summary>
/// Descripción breve de Cliente
/// </summary>
public class Cliente
{

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string Direccion { get; set; }
    public string Ciudad { get; set; }
    public string Codigo_postal { get; set; }

    public Cliente()
    {
       
    }
    public Cliente(int id, string nombre, string apellidos, string email, string telefono,  string direccion, string ciudad, string codigo_postal) {
        Id = id;
        Nombre = nombre;
        Apellidos = apellidos;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        Ciudad = ciudad;
        Codigo_postal = codigo_postal;
    }
}