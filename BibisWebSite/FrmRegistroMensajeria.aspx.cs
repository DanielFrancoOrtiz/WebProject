using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmRegistroMensajeria : System.Web.UI.Page
{
    DaoMensajeria dao = new DaoMensajeria();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null) {
           
            Mensajeria m = dao.Buscar(Convert.ToInt32(Request.QueryString["id"].ToString()));
            //txtNombre.Text = m.Nombre_mensajeria;
            //txtTelefono.Text = m.Telefono_mensajeria;
            //txtEmail.Text = m.Email_mensajeria;
            Label1.Visible = true;
            Label2.Text = Request.QueryString["id"];
            Label2.Visible = true;
            Button1.Text = "Actualizar";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                          string.IsNullOrWhiteSpace(txtTelefono.Text))
        {
            Response.Write("<script>alert('Hay Uno o mas Campos Vacios!')</script>");
        }
        else
        {
            Mensajeria m = new Mensajeria();
            m.Nombre_mensajeria = txtNombre.Text.ToString();
            m.Email_mensajeria = txtEmail.Text.ToString();
            m.Telefono_mensajeria = txtTelefono.Text.ToString();
            if (Button2.Text.ToString().Equals("Agregar"))
            {
                if (dao.Insertar(m) == 1)
                {
                    Response.Write("<script>alert('Registro de mensajeria exitosa!!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('No se pudo llevar a cabo con el registro')</script>");
                }
            }
            else {

                m.Id = Convert.ToInt32(Label2.Text);
                if (dao.Actualizar(m) == 1)
                {
                    Response.Write("<script>alert('Registro de mensajeria exitosa!!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('No se pudo llevar a cabo con el registro')</script>");
                }
                Response.Redirect("FrmCatalogoMensajeria.aspx");
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmCatalogoMensajeria.aspx");
    }
}