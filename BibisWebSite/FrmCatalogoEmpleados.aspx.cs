using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmCatalogoEmpleados : System.Web.UI.Page
{
    DaoEmpleado dao = new DaoEmpleado();
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = dao.LeerTodoss();
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
}