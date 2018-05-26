using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmCatalogoClientes : System.Web.UI.Page
{
    DaoCliente dao = new DaoCliente();
    protected void Page_Load(object sender, EventArgs e)
    {
        //GridView1.DataSource = dao.LeerTodoss();
        //GridView1.DataBind();
        llenarTable();
        
    }
    public void llenarTable() {
        List<Cliente> lista = dao.ConsultarTodos();
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
        h3.Text = "Apellidos";
        TableHeaderCell h4 = new TableHeaderCell();
        h4.Scope = TableHeaderScope.Column;
        h4.Text = "Telefono";
        TableHeaderCell h5 = new TableHeaderCell();
        h5.Scope = TableHeaderScope.Column;
        h5.Text = "Email";
        TableHeaderCell h6 = new TableHeaderCell();
        h6.Scope = TableHeaderScope.Column;
        h6.Text = "Direccion";
        TableHeaderCell h7 = new TableHeaderCell();
        h7.Scope = TableHeaderScope.Column;
        h7.Text = "Ciudad";
        TableHeaderCell h8 = new TableHeaderCell();
        h8.Scope = TableHeaderScope.Column;
        h8.Text = "Codigo Postal";

        TableHeaderRow hr = new TableHeaderRow();
        hr.Cells.Add(h0);
        hr.Cells.Add(h1);
        hr.Cells.Add(h2);
        hr.Cells.Add(h3);
        hr.Cells.Add(h4);
        hr.Cells.Add(h5);
        hr.Cells.Add(h6);
        hr.Cells.Add(h7);
        hr.Cells.Add(h8);

        Table1.Rows.Add(hr);
        if (lista != null)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Button btn1 = new Button();
                Button btn2 = new Button();
                btn1.Text = "Upd";
                btn2.Text = "Del";
                btn1.CssClass = "btn btn-outline-info col-sm-6";
                btn2.CssClass = "btn btn-outline-danger col-sm-6";
                btn1.Click += new EventHandler(this.ActionUpd);
                btn2.Click += new EventHandler(this.ActionDel);

                TableCell c0 = new TableCell();
                c0.Controls.Add(btn1);
                c0.Controls.Add(btn2);


                TableCell cId = new TableCell();
                cId.Text = Convert.ToString(lista[i].Id);
                TableCell cNom = new TableCell();
                cNom.Text = lista[i].Nombre;
                TableCell cApe = new TableCell();
                cApe.Text = lista[i].Apellidos;
                TableCell cTel = new TableCell();
                cTel.Text = lista[i].Telefono;
                TableCell cEm = new TableCell();
                cEm.Text = lista[i].Email;
                TableCell cDir = new TableCell();
                cDir.Text = lista[i].Direccion;
                TableCell cCity = new TableCell();
                cCity.Text = lista[i].Ciudad;
                TableCell cCod = new TableCell();
                cCod.Text = lista[i].Codigo_postal;

                TableRow tr = new TableRow();
                tr.Cells.Add(c0);
                tr.Cells.Add(cId);
                tr.Cells.Add(cNom);
                tr.Cells.Add(cApe);
                tr.Cells.Add(cTel);
                tr.Cells.Add(cEm);
                tr.Cells.Add(cDir);
                tr.Cells.Add(cCity);
                tr.Cells.Add(cCod);

                Table1.Rows.Add(tr);
            }
        }


    }

    protected void ActionUpd(object sender, EventArgs e)
    {
        Response.Write(((TableRow)(((Button)sender).Parent.Parent)).Cells[1].Text);
    }


    protected void ActionDel(object sender, EventArgs e)
    {
        dao.Eliminar(Convert.ToInt32(((TableRow)(((Button)sender).Parent.Parent)).Cells[1].Text));
        llenarTable();
    }

}