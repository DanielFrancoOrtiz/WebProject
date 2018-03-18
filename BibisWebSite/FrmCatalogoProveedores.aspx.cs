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
       GridView1.DataSource = dao.LeerTodoss();
        GridView1.DataBind();
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmRegistroProveedor.aspx");
    }
}