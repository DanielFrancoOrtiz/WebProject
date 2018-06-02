using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class FrmVistaProductos : System.Web.UI.Page
{
    List<Producto> lista;
    private int cont=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        lista = new DaoProducto().ConsultarTodos();
        llenarDivs();
        
        
    }
    public void llenarDivs() {
        divProducto1.Visible = false;
        divProducto2.Visible = false;
        divProducto3.Visible = false;
        divProducto4.Visible = false;
        divProducto5.Visible = false;
        divProducto6.Visible = false;
        try
        {
            Label1.Text = lista[cont].Nombre;
            Label2.Text = "$"+Convert.ToString(lista[cont].Precio_venta);
            Image1.ImageUrl = "imgs/imgProducts/img"+(cont+1)+".jpg";
            divProducto1.Visible = true;


            Label3.Text = lista[cont+1].Nombre;
            Label4.Text ="$"+ Convert.ToString(lista[cont+1].Precio_venta);
            Image2.ImageUrl = "imgs/imgProducts/img" + (cont + 2) + ".jpg";
            divProducto2.Visible = true;

            Label5.Text = lista[cont+2].Nombre;
            Label6.Text = "$"+Convert.ToString(lista[cont + 2].Precio_venta);
            Image3.ImageUrl = "imgs/imgProducts/img" + (cont + 3) + ".jpg";
            divProducto3.Visible = true;

            Label7.Text = lista[cont+3].Nombre;
            Label8.Text = "$"+Convert.ToString(lista[cont + 3].Precio_venta);
            Image4.ImageUrl = "imgs/imgProducts/img" + (cont + 4) + ".jpg";
            divProducto4.Visible = true;


            Label9.Text = lista[cont+4].Nombre;
            Label10.Text = "$"+Convert.ToString(lista[cont +4].Precio_venta);
            Image5.ImageUrl = "imgs/imgProducts/img" + (cont + 5) + ".jpg";
            divProducto5.Visible = true;


            Label11.Text = lista[cont+5].Nombre;
            Label12.Text = "$"+Convert.ToString(lista[cont + 5].Precio_venta);
            Image6.ImageUrl = "imgs/imgProducts/img" + (cont + 6) + ".jpg";
            divProducto6.Visible = true;

        }
        catch (Exception ex) {

        }
    }


    protected void btn4_Click(object sender, EventArgs e)
    {
        cont += 6;
        llenarDivs();
        liPrevio.Disabled = false;
    }

    protected void btnPrevio_Click(object sender, EventArgs e)
    {
        cont -= 6;
        llenarDivs();
        if (cont==0) {
            liPrevio.Disabled = true;
        }
    }
    private string idP;
    public string Get_idP() {
        return idP;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        idP = Convert.ToString(lista[cont].Id);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        idP = Convert.ToString(lista[cont+1].Id);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        idP = Convert.ToString(lista[cont + 2].Id);
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        idP = Convert.ToString(lista[cont + 3].Id);
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        idP = Convert.ToString(lista[cont + 4].Id);
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        idP = Convert.ToString(lista[cont + 5].Id);
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Pre_venta obj = new Pre_venta();
        obj.Nombre = lista[cont].Nombre;
        obj.Precio = lista[cont].Precio_venta;
        new daoPreventa().Insertar(obj);
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Pre_venta obj = new Pre_venta();
        obj.Nombre = lista[cont+1].Nombre;
        obj.Precio = lista[cont+1].Precio_venta;
        new daoPreventa().Insertar(obj);
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        Pre_venta obj = new Pre_venta();
        obj.Nombre = lista[cont+2].Nombre;
        obj.Precio = lista[cont+2].Precio_venta;
        new daoPreventa().Insertar(obj);

    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        Pre_venta obj = new Pre_venta();
        obj.Nombre = lista[cont+3].Nombre;
        obj.Precio = lista[cont+3].Precio_venta;
        new daoPreventa().Insertar(obj);
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        Pre_venta obj = new Pre_venta();
        obj.Nombre = lista[cont+4].Nombre;
        obj.Precio = lista[cont+4].Precio_venta;
        new daoPreventa().Insertar(obj);
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        Pre_venta obj = new Pre_venta();
        obj.Nombre = lista[cont+5].Nombre;
        obj.Precio = lista[cont+5].Precio_venta;
        new daoPreventa().Insertar(obj);
    }
}