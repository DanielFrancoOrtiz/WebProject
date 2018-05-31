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
        if (Session["Nombre"] != null)
        {
        }
        else
        {
            Response.Redirect("FrmLoginEn.aspx");
        }
        llenarTable();
    }
    public void llenarTable() {
        List<Producto> lista = dao.ConsultarTodos();


        if (lista != null)
        {
            Table1.Rows.Clear();
            TableHeaderCell h0 = new TableHeaderCell();
            h0.Scope = TableHeaderScope.Column;
            h0.Text = "Administrar";
            TableHeaderCell h1 = new TableHeaderCell();
            h1.Scope = TableHeaderScope.Column;
            h1.Text = "ID";
            TableHeaderCell h2 = new TableHeaderCell();
            h2.Scope = TableHeaderScope.Column;
            h2.Text = "Nombre";
            TableHeaderCell h3 = new TableHeaderCell();
            h3.Scope = TableHeaderScope.Column;
            h3.Text = "Modelo";
            TableHeaderCell h4 = new TableHeaderCell();
            h4.Scope = TableHeaderScope.Column;
            h4.Text = "Cantidad";
            TableHeaderCell h5 = new TableHeaderCell();
            h5.Scope = TableHeaderScope.Column;
            h5.Text = "Precio Compra";
            TableHeaderCell h6 = new TableHeaderCell();
            h6.Scope = TableHeaderScope.Column;
            h6.Text = "Precio Venta";

            TableHeaderRow hr = new TableHeaderRow();
            hr.Cells.Add(h0);
            hr.Cells.Add(h1);
            hr.Cells.Add(h2);
            hr.Cells.Add(h3);
            hr.Cells.Add(h4);
            hr.Cells.Add(h5);
            hr.Cells.Add(h6);

            Table1.Rows.Add(hr);


            for (int i = 0; i < lista.Count; i++)
            {
                Button btn1 = new Button();
                Button btn2 = new Button();
                btn1.Text = "Upd";
                btn2.Text = "Del";
                btn1.CssClass = "btn btn-outline-info col-sm-6";
                btn1.PostBackUrl = "FrmRegistroProducto.aspx";
                btn2.CssClass = "btn btn-outline-warning col-sm-6";
                btn1.Click += new EventHandler(this.ActionUpd);
                btn2.Click += new EventHandler(this.ActionDel);

                TableCell c0 = new TableCell();
                c0.Controls.Add(btn1);
                c0.Controls.Add(btn2);


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
                tr.Cells.Add(c0);
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
    private string Id;
    protected void ActionUpd(object sender, EventArgs e)
    {
        Id= ((TableRow)(((Button)sender).Parent.Parent)).Cells[1].Text;

    }
    protected void ActionDel(object sender, EventArgs e)
    {
        dao.Eliminar(Convert.ToInt32(((TableRow)(((Button)sender).Parent.Parent)).Cells[1].Text));
        llenarTable();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmRegistroProducto.aspx");
    }
    public string getID() {
        return Id;
    }
}