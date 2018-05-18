using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmCatalogoCategorias : System.Web.UI.Page
{
    DaoCategoria dao = new DaoCategoria();
    protected void Page_Load(object sender, EventArgs e)
    {
       // GridView1.DataSource = dao.LeerTodoss();
        //GridView1.DataBind();

        List<Categoria> lista = dao.ConsultarTodos();
        if (lista != null) {
            for (int i = 0; i < lista.Count; i++) {
                TableCell c1 = new TableCell();
                c1.Text = Convert.ToString(lista[i].Id);
                TableCell c2 = new TableCell();
                c2.Text = lista[i].Nombre;
                TableCell c3 = new TableCell();
                c3.Text = lista[i].Descripcion;
                TableRow tr = new TableRow();
                tr.Cells.Add(c1);
                tr.Cells.Add(c2);
                tr.Cells.Add(c3);
                Table1.Rows.Add(tr);
            }
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmRegistroCategoria.aspx");
    }
}