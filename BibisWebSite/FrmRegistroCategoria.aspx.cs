using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmRegistoCategoria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DaoCategoria dao = new DaoCategoria();
        Categoria c = new Categoria();
        c.Nombre = txtNombre.Text.ToString();
        c.Descripcion = txtDescripcion.Text.ToString();
        if (dao.Insertar(c) == 1)
        {
            Response.Write("Agrego");
        }
        else {
            Response.Write("Error");
        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmCatalogoCategorias.aspx");
    }
}