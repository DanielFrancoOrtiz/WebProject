using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmCatalogoProveedores : System.Web.UI.Page
{
    DaoProveedor dao = new DaoProveedor();
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
        List<Proveedor> lista = dao.ConsultarTodos();


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
            h3.Text = "Email";
            TableHeaderCell h4 = new TableHeaderCell();
            h4.Scope = TableHeaderScope.Column;
            h4.Text = "Telefono";
            TableHeaderCell h5 = new TableHeaderCell();
            h5.Scope = TableHeaderScope.Column;
            h5.Text = "Direccion";
            TableHeaderCell h6 = new TableHeaderCell();
            h6.Scope = TableHeaderScope.Column;
            h6.Text = "Ciudad";
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
                btn1.PostBackUrl = "FrmRegistroProveedor.aspx";
                btn2.CssClass = "btn btn-outline-danger col-sm-6";
                btn1.Click += new EventHandler(this.ActionUpd);
                btn2.Click += new EventHandler(this.ActionDel);
                TableCell c0 = new TableCell();
                c0.Controls.Add(btn1);
                c0.Controls.Add(btn2);

                TableCell cId = new TableCell();
                cId.Text = Convert.ToString(lista[i].Id);
                TableCell cNom = new TableCell();
                cNom.Text = lista[i].Nombre_proveedor;
                TableCell cEm = new TableCell();
                cEm.Text = lista[i].Email_proveedor;
                TableCell cTel = new TableCell();
                cTel.Text = lista[i].Telefono_proveedor;
                TableCell cDir = new TableCell();
                cDir.Text = lista[i].Direccion_proveedor;
                TableCell cCity = new TableCell();
                cCity.Text = lista[i].Ciudad_proveedor;



                TableRow tr = new TableRow();
                tr.Cells.Add(c0);
                tr.Cells.Add(cId);
                tr.Cells.Add(cNom);
                tr.Cells.Add(cEm);
                tr.Cells.Add(cTel);
                tr.Cells.Add(cDir);
                tr.Cells.Add(cCity);
                Table1.Rows.Add(tr);
            }
        }
    }

    private string Id;
    protected void ActionUpd(object sender, EventArgs e)
    {
        Id = ((TableRow)(((Button)sender).Parent.Parent)).Cells[1].Text;

    }
    protected void ActionDel(object sender, EventArgs e)
    {
        dao.Eliminar(Convert.ToInt32(((TableRow)(((Button)sender).Parent.Parent)).Cells[1].Text));
        llenarTable();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmRegistroProveedor.aspx");
    }
    public string getID() {
        return Id;
    }
}