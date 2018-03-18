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
        GridView1.DataSource = dao.LeerTodoss();
        GridView1.DataBind();
    }
}