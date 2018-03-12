
/// <summary>
/// Descripción breve de Proveedor
/// </summary>
public class Proveedor
{

    public int Id { get; set; }
    public string Nombre_proveedor { get; set; }
    public string Email_proveedor { get; set; }
    public string Telefono_proveedor { get; set; }
    public string Direccion_proveedor { get; set; }
    public string Ciudad_proveedor { get; set; }

    public Proveedor()
    {
       
    }
    public Proveedor(int id, string nombre_proveedor, string email_proveedor,
        string telefono_proveedor, string direccion_proveedor, string ciudad_proveedor) {
        Id = id;
        Nombre_proveedor = nombre_proveedor;
        Email_proveedor = email_proveedor;
        Telefono_proveedor = telefono_proveedor;
        Direccion_proveedor = direccion_proveedor;
        Ciudad_proveedor = ciudad_proveedor;
    }
}