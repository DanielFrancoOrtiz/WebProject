using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmCatalogoCategorias : System.Web.UI.Page
{
    DaoCategoria dao = new DaoCategoria();
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
        List<Categoria> lista = dao.ConsultarTodos();

        Table1.Rows.Clear();
        TableHeaderRow hr = new TableHeaderRow();
        TableHeaderCell h0 = new TableHeaderCell();
        h0.Scope = TableHeaderScope.Column;
        h0.Text = "Administrar";
        hr.Cells.Add(h0);
        TableHeaderCell h1 = new TableHeaderCell();
        h1.Scope = TableHeaderScope.Column;
        h1.Text = "ID";
        TableHeaderCell h2 = new TableHeaderCell();
        h2.Scope = TableHeaderScope.Column;
        h2.Text = "Nombre";
        TableHeaderCell h3 = new TableHeaderCell();
        h3.Scope = TableHeaderScope.Column;
        h3.Text = "Descripcion";
        
        
        hr.Cells.Add(h1);
        hr.Cells.Add(h2);
        hr.Cells.Add(h3);
        Table1.Rows.Add(hr);

        if (lista != null)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                TableRow tr = new TableRow();
                if (Session["Puesto"].ToString().Equals("Administrador"))
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
                    tr.Cells.Add(c0);
                }
                else {
                   // Table1.Rows[0].Cells.RemoveAt(0);
                }

                TableCell c1 = new TableCell();
                c1.Text = Convert.ToString(lista[i].Id);
                TableCell c2 = new TableCell();
                c2.Text = lista[i].Nombre;
                TableCell c3 = new TableCell();
                c3.Text = lista[i].Descripcion;
               


                
                tr.Cells.Add(c1);
                tr.Cells.Add(c2);
                tr.Cells.Add(c3);
                Table1.Rows.Add(tr);
            }
        }
    }
    protected void ActionUpd(object sender, EventArgs e)
    {
        Label2.Visible = true;
        Label1.Visible = true;
        Label1.Text = (((TableRow)(((Button)sender).Parent.Parent)).Cells[1].Text);
        DaoCategoria dao = new DaoCategoria();
        Categoria c = dao.Buscar(Convert.ToInt32(Label1.Text));
        txtNombre.Text = c.Nombre ;
        txtDescripcion.Text = c.Descripcion;
    
        Button2.Text = "Actualizar";
        txtNombre.BorderColor = System.Drawing.Color.LightGray;
    }
    protected void ActionDel(object sender, EventArgs e)
    {
        dao.Eliminar(Convert.ToInt32(((TableRow)(((Button)sender).Parent.Parent)).Cells[1].Text));
        llenarTable();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        DaoCategoria dao = new DaoCategoria();
        Categoria c = new Categoria();
        if (Regex.IsMatch(txtNombre.Text, "[A-Z][a-z0-9]*"))
        {
            c.Nombre = txtNombre.Text.ToString();
            c.Descripcion = txtDescripcion.Text.ToString();
            if (Button2.Text.ToString().Equals("Agregar"))
            {
                if (dao.Insertar(c) != 1)
                {
                    Button3.Text = "Error";

                }
            }
            else
            {
                c.Id = Convert.ToInt32(Label1.Text);
                if (dao.Actualizar(c) != 1)
                {
                    Button3.Text = "Error";

                }
                Label1.Visible = false;
                Label2.Visible = false;
                Button2.Text = "Agregar";
            }
            llenarTable();
            txtDescripcion.Text = null;
            txtNombre.Text = null;
            txtNombre.BorderColor = System.Drawing.Color.LightGray;
        }
        else {
            txtNombre.BorderColor = System.Drawing.Color.Red;
        }

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        txtNombre.Text = null;
        txtDescripcion.Text = null;
        Label1.Visible = false;
        Label2.Visible = false;
        Button2.Text = "Agregar";

    }
}