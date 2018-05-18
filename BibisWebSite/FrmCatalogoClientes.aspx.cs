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

        List<Cliente> lista = dao.ConsultarTodos();
        if (lista != null)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                TableCell cId = new TableCell();
                cId.Text = Convert.ToString(lista[i].Id);
                TableCell cNom = new TableCell();
                cNom.Text = lista[i].Nombre;
                TableCell cApe = new TableCell();
                cApe.Text = lista[i].Apellidos;
                TableCell cTel= new TableCell();
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
}