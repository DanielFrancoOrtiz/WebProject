using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmCarrito : System.Web.UI.Page
{
    List<Pre_venta> lista;
    protected void Page_Load(object sender, EventArgs e)
    {
        llenarTable();
    }
    public void llenarTable() {
        double precioTotal = 0;
        int cantidadProductos = 0;
        lista = new daoPreventa().ConsultarTodos();
        if (lista != null)
        {
            Table1.Rows.Clear();
            TableHeaderCell h0 = new TableHeaderCell();
            h0.Scope = TableHeaderScope.Column;
            h0.Text = "Administrar";
            TableHeaderCell h1 = new TableHeaderCell();
            h1.Scope = TableHeaderScope.Column;
            h1.Text = "Producto";
            TableHeaderCell h2 = new TableHeaderCell();
            h2.Scope = TableHeaderScope.Column;
            h2.Text = "Nombre";
            TableHeaderCell h4 = new TableHeaderCell();
            h4.Scope = TableHeaderScope.Column;
            h4.Text = "Precio";
            TableHeaderRow hr = new TableHeaderRow();
            hr.Cells.Add(h0);
            hr.Cells.Add(h2);
            hr.Cells.Add(h4);
            Table1.Rows.Add(hr);

            Table2.Rows.Clear();
            TableHeaderCell h0t2 = new TableHeaderCell();
            h0t2.Scope = TableHeaderScope.Column;
            h0t2.Text = "Cantidad de Productos";
            TableHeaderCell h1t2 = new TableHeaderCell();
            h1t2.Scope = TableHeaderScope.Column;
            h1t2.Text = "Precio Total";
            TableHeaderRow hrt2 = new TableHeaderRow();
            hrt2.Cells.Add(h0t2);
            hrt2.Cells.Add(h1t2);
            for (int i = 0; i < lista.Count; i++)
            {
                cantidadProductos++;
                Button btn2 = new Button();

                btn2.Text = "Eliminar";
                btn2.CssClass = "btn btn-outline-danger col-sm-6";
                btn2.Click += new EventHandler(this.ActionDel);

                TableCell c0 = new TableCell();
                c0.Controls.Add(btn2);
                TableCell c1 = new TableCell();
                c1.Text = lista[i].Id+"";
                TableCell c2 = new TableCell();
                c2.Text = lista[i].Nombre;
                TableCell c3 = new TableCell();
                c3.Text ="$"+ lista[i].Precio+"";
                precioTotal += lista[i].Precio;
                TableRow tr = new TableRow();
                tr.Cells.Add(c0);
                tr.Cells.Add(c1);   
                tr.Cells.Add(c2);
                tr.Cells.Add(c3);
                Table1.Rows.Add(tr);
                c1.Visible = false;
            }
            TableCell cCant = new TableCell();
            cCant.Text = cantidadProductos+"";
            TableCell cTot = new TableCell();
            cTot.Text ="$"+precioTotal+"";
            TableRow trT2 = new TableRow();
            trT2.Cells.Add(cCant);
            trT2.Cells.Add(cTot);
            Table2.Rows.Add(trT2);
        }

    }
    protected void ActionDel(object sender, EventArgs e)
    {
        new daoPreventa().Eliminar(Convert.ToInt32(((TableRow)(((Button)sender).Parent.Parent)).Cells[1].Text));
 
        llenarTable();
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < lista.Count; i++) {
            new daoPreventa().Eliminar(lista[i].Id);
        }
        llenarTable();
    }
}