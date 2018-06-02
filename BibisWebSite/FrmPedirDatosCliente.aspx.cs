using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmPedirDatosCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        divCodigo.Visible = false;
    }

    protected void cmbMetPAgo_SelectedIndexChanged(object sender, EventArgs e)
    {
        divCodigo.Visible = true;
    }

    public void limpiar()
    {
        txtApellidos.Text = "";
        txtCiudad.Text = "";
        txtCP.Text = "";
        txtDireccion.Text = "";
        txtEmail.Text = "";
        txtNombre.Text="";
        txtTelefono.Text = "";

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text)
            || string.IsNullOrWhiteSpace(txtCiudad.Text) || string.IsNullOrWhiteSpace(txtCP.Text)
            || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtEmail.Text)
            || string.IsNullOrWhiteSpace(txtTelefono.Text)
            )
        {

            Response.Write("<script>alert('Hay Uno o mas Campos Vacios!')</script>");
        }
        else { 

        Response.Write("<script>alert('Venta Realizada!!')</script>");
            limpiar();
        List<Pre_venta> lista = new daoPreventa().ConsultarTodos();
        for (int i = 0; i < lista.Count; i++) {
            new daoPreventa().Eliminar(lista[i].Id);
        }
        Response.Redirect("FrmVistaProductos.aspx");
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        divCodigo.Visible = true;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        List<Pre_venta> lista = new daoPreventa().ConsultarTodos();
        if (lista != null)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                new daoPreventa().Eliminar(lista[i].Id);
            }
            Response.Redirect("FrmVistaProductos.aspx");
        }
    }


    public Boolean validar()
    {
        txtTelefono.BorderColor = System.Drawing.Color.Gray;
        txtEmail.BorderColor = System.Drawing.Color.Gray;
        txtNombre.BorderColor = System.Drawing.Color.Gray;
        txtApellidos.BorderColor = System.Drawing.Color.Gray;
        txtDireccion.BorderColor = System.Drawing.Color.Gray;
        txtCiudad.BorderColor = System.Drawing.Color.Gray;
        txtCP.BorderColor = System.Drawing.Color.Gray;
        Boolean valid = true;
        if (!Regex.IsMatch(txtNombre.Text, "[A-Z][a-z]+([ ](([A-Z][a-z]*)|([0-9]+)))*"))
        {
            valid = false;
            txtNombre.BorderColor = System.Drawing.Color.Red;
        }

        if (!Regex.IsMatch(txtDireccion.Text, "[A-Z][a-z]+([ ](([A-Z][a-z]*)|([0-9]+)))*"))
        {
            valid = false;
            txtDireccion.BorderColor = System.Drawing.Color.Red;
        }


        if (!Regex.IsMatch(txtApellidos.Text, "[A-Z][a-z]+([ ](([A-Z][a-z]*)|([0-9]+)))*"))
        {
            valid = false;
            txtApellidos.BorderColor = System.Drawing.Color.Red;
        }


        if (!Regex.IsMatch(txtEmail.Text, "[A-Za-z]+@[a-z]+[.][a-z]+([.][a-z]+)?"))
        {
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
        if (!Regex.IsMatch(txtCiudad.Text, "[A-Z][a-z]+([ ][A-Za-z]+)*"))
        {
            valid = false;
            txtCiudad.BorderColor = System.Drawing.Color.Red;
        }

        if (!Regex.IsMatch(txtCP.Text, "[0-9]+")
           || txtCP.Text.Length ==5
           )
        {
            valid = false;
            txtCP.BorderColor = System.Drawing.Color.Red;
        }
        return valid;
    }
}