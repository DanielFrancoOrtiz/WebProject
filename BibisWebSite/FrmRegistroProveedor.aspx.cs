using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmRegistoProveedor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DaoProveedor dao = new DaoProveedor();
        Proveedor p = new Proveedor();
        p.Nombre_proveedor = txtNombre.Text.ToString();
        p.Email_proveedor = txtEmail.Text.ToString();
        p.Telefono_proveedor = txtTelefono.Text.ToString();
        p.Direccion_proveedor = txtDireccion.Text.ToString();
        p.Ciudad_proveedor = txtCiudad.Text.ToString();
        if (dao.Insertar(p)==1)
        {
            Response.Write("insertado");
        }
        else
        {
            Response.Write("Error");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmCatalogoProveedores.aspx");
    }
}