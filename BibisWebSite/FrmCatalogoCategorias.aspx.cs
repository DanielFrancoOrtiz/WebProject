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
        GridView1.DataSource = dao.LeerTodoss();
        GridView1.DataBind();
    }
}