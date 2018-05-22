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

        llenarTable();


    }
    public void llenarTable() {
        List<Categoria> lista = dao.ConsultarTodos();
        Table1.Rows.Clear();
        TableHeaderCell h1 = new TableHeaderCell();
        h1.Scope = TableHeaderScope.Column;
        h1.Text = "ID";
        TableHeaderCell h2 = new TableHeaderCell();
        h2.Scope = TableHeaderScope.Column;
        h2.Text = "Nombre";
        TableHeaderCell h3 = new TableHeaderCell();
        h3.Scope = TableHeaderScope.Column;
        h3.Text = "Descripcion";
        TableHeaderRow hr = new TableHeaderRow();
        hr.Cells.Add(h1);
        hr.Cells.Add(h2);
        hr.Cells.Add(h3);
        Table1.Rows.Add(hr);

        if (lista != null)
        {
            for (int i = 0; i < lista.Count; i++)
            {
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

    protected void Button2_Click(object sender, EventArgs e)
    {
        DaoCategoria dao = new DaoCategoria();
        Categoria c = new Categoria();
        c.Nombre = txtNombre.Text.ToString();
        c.Descripcion = txtDescripcion.Text.ToString();
        if (dao.Insertar(c) == 1)
        {
           
            llenarTable();
        }
        else
        {
            Response.Write("Error");
        }
    }
}