using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmRegistroMensajeria : System.Web.UI.Page
{
    DaoMensajeria dao = new DaoMensajeria();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["Nombre"] != null)
        //{
        //}
        //else
        //{
        //    Response.Redirect("FrmLoginEn.aspx");
        //}
        if (Page.PreviousPage != null)
        {        
            if (!Label2.Visible)
            {
                string id = PreviousPage.getID();
                Mensajeria m = dao.Buscar(Convert.ToInt32(id));
                txtNombre.Text = m.Nombre_mensajeria;
                txtTelefono.Text = m.Telefono_mensajeria;
                txtEmail.Text = m.Email_mensajeria;
                Label1.Visible = true;
                Label2.Text = id;
                Label2.Visible = true;
                Button1.Text = "Actualizar";
            }
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
            if (validar())
            {
                Mensajeria m = new Mensajeria();
                m.Nombre_mensajeria = txtNombre.Text.ToString();
                m.Email_mensajeria = txtEmail.Text.ToString();
                m.Telefono_mensajeria = txtTelefono.Text.ToString();
                if (Button1.Text.ToString().Equals("Agregar"))
                {
                    if (dao.Insertar(m) == 1)
                    {
                        Response.Write("<script>alert('Registro de mensajeria exitosa!!')</script>");
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('No se pudo llevar a cabo con el registro')</script>");
                    }
                }
                else
                {

                    m.Id = Convert.ToInt32(Label2.Text);
                    if (dao.Actualizar(m) == 1)
                    {
                        Response.Write("<script>alert('Registro de mensajeria exitosa!!')</script>");
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('No se pudo llevar a cabo con el registro')</script>");
                    }
                    Response.Redirect("FrmCatalogoMensajeria.aspx");
                }
            }
            
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmCatalogoMensajeria.aspx");
    }

    public void limpiar()
    {
        txtNombre.Text = "";
        txtEmail.Text = "";
        txtTelefono.Text = "";
    }
    public Boolean validar() {
        txtTelefono.BorderColor = System.Drawing.Color.Gray;
        txtEmail.BorderColor = System.Drawing.Color.Gray;
        txtNombre.BorderColor = System.Drawing.Color.Gray;
        Boolean valid = true;
        if (!Regex.IsMatch(txtNombre.Text, "[A-Z][a-z]+([ ](([A-Z][a-z]*)|([0-9]+)))*"))
        {
            valid = false;
            txtNombre.BorderColor = System.Drawing.Color.Red;
        }
        if (!Regex.IsMatch(txtEmail.Text, "[A-Za-z]+@[a-z]+[.][a-z]+([.][a-z]+)?")) {
            valid = false;
            txtEmail.BorderColor = System.Drawing.Color.Red;
        }
        if (!Regex.IsMatch(txtTelefono.Text, "[0-9]+")
            || txtTelefono.Text.Length > 13 || txtTelefono.Text.Length < 10
            )
        {
            valid = false;
            txtTelefono.BorderColor = System.Drawing.Color.Red;
        }
        return valid;
    }
}