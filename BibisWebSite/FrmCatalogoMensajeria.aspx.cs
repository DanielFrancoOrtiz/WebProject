using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmCatalogoMensajeria : System.Web.UI.Page
{
    DaoMensajeria dao = new DaoMensajeria();
    protected void Page_Load(object sender, EventArgs e)
    {
        //GridView1.DataSource = dao.LeerTodoss();
        //GridView1.DataBind();
        List<Mensajeria> lista = dao.ConsultarTodos();
        if (lista != null)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Button btn1 = new Button();
                Button btn2 = new Button();
                btn1.Text = "Upd";
                btn2.Text = "Del";
                btn1.CssClass = "btn btn-warning col-sm-6";
                btn2.CssClass = "btn btn-danger col-sm-6";
                

                TableCell c0 = new TableCell();
                c0.Controls.Add(btn1);
                c0.Controls.Add(btn2);

                TableCell c1 = new TableCell();
                c1.Text = Convert.ToString(lista[i].Id);
                TableCell c2 = new TableCell();
                c2.Text = lista[i].Nombre_mensajeria;
                TableCell c3 = new TableCell();
                c3.Text = lista[i].Email_mensajeria;
                TableCell c4 = new TableCell();
                c4.Text = lista[i].Telefono_mensajeria;

                TableRow tr = new TableRow();
                tr.Cells.Add(c0);
                tr.Cells.Add(c1);
                tr.Cells.Add(c2);
                tr.Cells.Add(c3);
                tr.Cells.Add(c4);
                Table1.Rows.Add(tr);
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmRegistroMensajeria.aspx");
    }
}