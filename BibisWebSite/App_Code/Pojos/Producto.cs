
/// <summary>
/// Descripción breve de Producto
/// </summary>
public class Producto
{

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Modelo { get; set; }
    public int Cantidad { get; set; }
    public double Precio_compra { get; set; }
    public double Precio_venta { get; set; }
    public string Foto { get; set; }
    public int Id_proveedor { get; set; }
    public int Id_categoria { get; set; }
    public string Descripcion { get; set; }
    public Producto()
    {
        
    }
    public Producto(int id, string nombre, string modelo, int cantidad, double precio_compra,
       double precio_venta, string foto, int id_proveedor, int id_categoria, string descripcion )
    {
        Id = id;
        Nombre = nombre;
        Modelo = modelo;
        Cantidad = cantidad;
        Precio_compra = precio_compra;
        Precio_venta = precio_venta;
        Foto = foto;
        Id_proveedor = id_proveedor;
        Id_categoria = id_categoria;
        Descripcion = descripcion;

    }
}