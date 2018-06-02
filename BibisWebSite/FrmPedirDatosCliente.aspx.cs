using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmPedirDatosCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        divCodigo.Visible = false;
    }

    protected void cmbMetPAgo_SelectedIndexChanged(object sender, EventArgs e)
    {
        divCodigo.Visible = true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert('Venta Realizada!!')</script>");
        List<Pre_venta> lista = new daoPreventa().ConsultarTodos();
        for (int i = 0; i < lista.Count; i++) {
            new daoPreventa().Eliminar(lista[i].Id);
        }
        Response.Redirect("FrmVistaProductos.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        divCodigo.Visible = true;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        List<Pre_venta> lista = new daoPreventa().ConsultarTodos();
        if (lista != null)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                new daoPreventa().Eliminar(lista[i].Id);
            }
            Response.Redirect("FrmVistaProductos.aspx");
        }
    }
}