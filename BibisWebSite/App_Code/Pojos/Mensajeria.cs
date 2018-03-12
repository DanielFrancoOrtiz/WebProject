
/// <summary>
/// Descripción breve de Mensajeria
/// </summary>
public class Mensajeria
{
    public int Id { get; set; }
    public string Nombre_mensajeria { get; set; }
    public string Email_mensajeria { get; set; }
    public string Telefono_mensajeria { get; set; }

    public Mensajeria()
    {
        
    }
    public Mensajeria(int id, string nombre_mensajeria, string email_mensajeria, string telefono_mensajeria) {
        Id = id;
        Nombre_mensajeria = nombre_mensajeria;
        Email_mensajeria = email_mensajeria;
        Telefono_mensajeria = telefono_mensajeria;
    }
}