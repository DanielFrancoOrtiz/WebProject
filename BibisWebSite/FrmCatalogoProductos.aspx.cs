using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmCatalogoProductos : System.Web.UI.Page
{
    DaoProducto dao = new DaoProducto();
    protected void Page_Load(object sender, EventArgs e)
    {
        //GridView1.DataSource = dao.LeerTodoss();
        //GridView1.DataBind();
        List<Producto> lista = dao.ConsultarTodos();
        if (lista != null)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                TableCell cId = new TableCell();
                cId.Text = Convert.ToString(lista[i].Id);
                TableCell cNom = new TableCell();
                cNom.Text = lista[i].Nombre;
                TableCell cMod = new TableCell();
                cMod.Text = lista[i].Modelo;
                TableCell cCant = new TableCell();
                cCant.Text = Convert.ToString(lista[i].Cantidad);
                TableCell cPC = new TableCell();
                cPC.Text = Convert.ToString(lista[i].Precio_compra);
                TableCell cPV = new TableCell();
                cPV.Text = Convert.ToString(lista[i].Precio_venta);

                TableRow tr = new TableRow();
                tr.Cells.Add(cId);
                tr.Cells.Add(cNom);
                tr.Cells.Add(cMod);
                tr.Cells.Add(cCant);
                tr.Cells.Add(cPC);
                tr.Cells.Add(cPV);

                Table1.Rows.Add(tr);
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmRegistroProducto.aspx");
    }
}