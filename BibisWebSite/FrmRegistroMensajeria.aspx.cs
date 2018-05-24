using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmRegistroMensajeria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                          string.IsNullOrWhiteSpace(txtTelefono.Text))
        {
            Response.Write("Hay Uno o mas Campos Vacios!");
        }
        else { 
        DaoMensajeria dao = new DaoMensajeria();
        Mensajeria m = new Mensajeria();
        m.Nombre_mensajeria = txtNombre.Text.ToString();
        m.Email_mensajeria = txtEmail.Text.ToString();
        m.Telefono_mensajeria = txtTelefono.Text.ToString();
        if (dao.Insertar(m)==1)
        {
                Response.Write("Registro de mensajeria exitosa !!");
            }
        else
        {
            Response.Write("No se pudo llevar a cabo con el registro");
        }
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmCatalogoMensajeria.aspx");
    }
}