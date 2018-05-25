﻿using System;
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
        if (Request.QueryString["id"]!=null) {
            Label2.Text = Request.QueryString["id"];
            Label1.Visible = true;
            Label2.Visible = true;
            Producto p = daoProducto.Buscar(Convert.ToInt32(Label2.Text));
            btnAceptar.Text = "Actualizar";
        }
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

            Response.Write("<script>alert('Hay Uno o mas Campos Vacios!')</script>");
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
            if (btnAceptar.Text.ToString().Equals("Agregar"))
            {
                if (daoProducto.Insertar(p) == 1)
                {
                    
                    Response.Write("<script>alert('Registro de producto exitoso!!!!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('No se pudo llevar a cabo con el registro')</script>");
                }
            }
            else {
                p.Id = Convert.ToInt32(Label2.Text);
                if (daoProducto.Actualizar(p) == 1)
                {
                    Response.Write("<script>alert('Actualizacion exitosa!!'></script>");
                    Response.Redirect("FrmCatalogoProductos.aspx");
                }
                else {

                }
                
            }
            
        }
    }
       

    

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmCatalogoProductos.aspx");
    }
}