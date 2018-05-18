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
        //GridView1.DataSource = dao.LeerTodoss();
        //GridView1.DataBind();
        List<Proveedor> lista = dao.ConsultarTodos();
        if (lista != null)
        {
            for (int i = 0; i < lista.Count; i++)
            {
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmRegistroProveedor.aspx");
    }
}