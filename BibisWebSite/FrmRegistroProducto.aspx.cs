using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmProducto : System.Web.UI.Page
{
    DaoProveedor daoProveedor = new DaoProveedor();
    DaoCategoria daoCategoria = new DaoCategoria();
    DaoProducto daoProducto = new DaoProducto();

    List<Categoria> listaCategoria;
    List<Proveedor> listaProveedor;

    protected void Page_Load(object sender, EventArgs e)
    {
        llenarCombos();
    }
    public void llenarCombos() {
        cmbCategoria.Items.Clear();
        cmbProveedor.Items.Clear();

        listaCategoria = daoCategoria.ConsultarTodos();
        listaProveedor = daoProveedor.ConsultarTodos();
        if(listaCategoria != null){
            for (int i = 0; i < listaCategoria.Count; i++) {
                ListItem itmc = new ListItem();
                itmc.Text = listaCategoria[i].Nombre;
                cmbCategoria.Items.Add(itmc);
            }
        }
        if (listaProveedor != null)
        {
            for (int i = 0; i < listaProveedor.Count; i++)
            {
                ListItem itmc = new ListItem();
                itmc.Text = listaProveedor[i].Nombre_proveedor;
                cmbProveedor.Items.Add(itmc);
            }
        }

    }


    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtModelo.Text)
            || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtPrecioC.Text)
            || string.IsNullOrWhiteSpace(txtPrecioV.Text)
            )
        {
            Response.Write("Hay Uno o mas Campos Vacios!");
        }
        else
        {

            Producto p = new Producto();
            p.Nombre = txtNombre.Text;
            p.Modelo = txtModelo.Text;
            p.Cantidad = Convert.ToInt32(txtCantidad.Text);
            p.Precio_compra = Convert.ToDouble(txtPrecioC.Text);
            p.Precio_venta = Convert.ToDouble(txtPrecioV.Text);
            p.Id_proveedor = listaProveedor[cmbProveedor.SelectedIndex].Id;
            p.Id_categoria = listaCategoria[cmbCategoria.SelectedIndex].Id;
            p.Descripcion = txtDescripcion.InnerText;
            daoProducto.Insertar(p);
            Response.Redirect("FrmCatalogoProductos.aspx");
        }
    }
       

    

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmCatalogoProductos.aspx");
    }
}