using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;
using System.Xml.XPath;
using System.Text.RegularExpressions;

public partial class FrmRegistoProveedor : System.Web.UI.Page
{
    string SampleID;
    XmlDocument xmlDoc;
    XmlDocument xdco = new XmlDocument();
    DaoProveedor dao = new DaoProveedor();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Nombre"] != null)
        {
        }
        else
        {
            Response.Redirect("FrmLoginEn.aspx");
        }
        if (Page.PreviousPage != null)
        {
            if (!Label2.Visible)
            {
                string id = PreviousPage.getID();
                Label2.Text = id;
                Label1.Visible = true;
                Label2.Visible = true;
                Proveedor p = dao.Buscar(Convert.ToInt32(id));
                txtNombre.Text = p.Nombre_proveedor;
                txtTelefono.Text = p.Telefono_proveedor;
                txtEmail.Text = p.Email_proveedor;
                txtDireccion.Text = p.Direccion_proveedor;
                txtCiudad.Text = p.Ciudad_proveedor;
                Button1.Text = "Actualizar";
            }
        }

    }

    private void mostrar()
    {
        DataSet ds = new DataSet();
        ds.ReadXml(Server.MapPath("DatosProveedor.xml"));
    }

    public void limpiar()
    {
        txtCiudad.Text = "";
        txtDireccion.Text = "";
        txtEmail.Text = "";
        txtNombre.Text = "";
        txtTelefono.Text = "";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                          string.IsNullOrWhiteSpace(txtTelefono.Text)||
                          string.IsNullOrWhiteSpace(txtDireccion.Text))
        {
            Response.Write("<script>alert('Hay Uno o mas Campos Vacios!')</script>");
        }
        else
        {
            if (validar())
            {
                Proveedor p = new Proveedor();
                p.Nombre_proveedor = txtNombre.Text;
                p.Email_proveedor = txtEmail.Text;
                p.Telefono_proveedor = txtTelefono.Text;
                p.Direccion_proveedor = txtDireccion.Text;
                p.Ciudad_proveedor = txtCiudad.Text;
                if (Button1.Text.ToString().Equals("Agregar"))
                {
                    if (dao.Insertar(p) == 1)
                    {
                        Response.Write("<script>alert('Registro de proveedor exitoso!!!!')</script>");
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('No se pudo llevar a cabo con el registro')</script>");
                    }

                    string fileXML = Server.MapPath("DatosProveedor.xml");
                    if (File.Exists(fileXML) == true)
                    {
                        xdco.Load(Server.MapPath("DatosProveedor.xml"));
                        XmlElement Proveedoor = xdco.CreateElement("DatosProveedor");
                        //atributos o elementos internos
                        XmlElement nombre = xdco.CreateElement("Nombre");
                        XmlText xmlNOmbre = xdco.CreateTextNode(p.Nombre_proveedor);
                        XmlElement email = xdco.CreateElement("Email");
                        XmlText xmlemail = xdco.CreateTextNode(p.Email_proveedor);
                        XmlElement telefono = xdco.CreateElement("Telefono");
                        XmlText xmlTelefono = xdco.CreateTextNode(p.Telefono_proveedor);
                        XmlElement direccion = xdco.CreateElement("Direccion");
                        XmlText xmlDireccion = xdco.CreateTextNode(p.Direccion_proveedor);
                        XmlElement Ciudad = xdco.CreateElement("Ciudad");
                        XmlText xmlCuidad = xdco.CreateTextNode(p.Ciudad_proveedor);
                        //crea los nodos hijo
                        nombre.AppendChild(xmlNOmbre);
                        email.AppendChild(xmlemail);
                        telefono.AppendChild(xmlTelefono);
                        direccion.AppendChild(xmlDireccion);
                        Ciudad.AppendChild(xmlCuidad);
                        //crea los nodos hijo
                        Proveedoor.AppendChild(nombre);
                        Proveedoor.AppendChild(email);
                        Proveedoor.AppendChild(telefono);
                        Proveedoor.AppendChild(direccion);
                        Proveedoor.AppendChild(Ciudad);
                        //ahora insertaos el nodo hijo al nodo raiz
                        xdco.DocumentElement.AppendChild(Proveedoor);
                        //guarda el archivo
                        xdco.Save(Server.MapPath("DatosProveedor.xml"));
                        mostrar();
                    }
                    else
                    {
                      

                        XmlTextWriter xtw = new XmlTextWriter(fileXML, null);
                        xtw.WriteStartDocument();
                        xtw.WriteStartElement("Proveedores");
                        xtw.WriteStartElement("Proveedor");
                        xtw.WriteElementString("Nombre", p.Nombre_proveedor);
                        xtw.WriteElementString("Email", p.Email_proveedor);
                        xtw.WriteElementString("Telefono", p.Telefono_proveedor);
                        xtw.WriteElementString("Direccion", p.Direccion_proveedor);
                        xtw.WriteElementString("Ciudad", p.Ciudad_proveedor);
                        xtw.WriteEndElement();
                        xtw.WriteEndElement();
                        xtw.Close();
                    }
                }
                else {
                    p.Id = Convert.ToInt32(Label2.Text);
                    if (dao.Actualizar(p) == 1)
                    {
                        Response.Write("<script>alert('Actualizacion exitosa!!')</script>");
                        limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('No se pudo llevar la actualización')</script>");
                    }

                }
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmCatalogoProveedores.aspx");
    }

    public Boolean validar() {
        Boolean isValid = true;
        txtNombre.BorderColor = System.Drawing.Color.Gray;
        txtTelefono.BorderColor = System.Drawing.Color.Gray;
        txtEmail.BorderColor = System.Drawing.Color.Gray;
        txtDireccion.BorderColor = System.Drawing.Color.Gray;
        txtCiudad.BorderColor = System.Drawing.Color.Gray;
        if (!Regex.IsMatch(txtNombre.Text, "[A-Z][a-z]+([ ][A-Za-z]+)*"))
        {
            isValid = false;
            txtNombre.BorderColor = System.Drawing.Color.Red;
        }
        if (!Regex.IsMatch(txtEmail.Text, "[A-Za-z]+@[a-z]+[.][a-z]+([.][a-z]+)?"))
        {
            isValid = false;
            txtEmail.BorderColor = System.Drawing.Color.Red;
        }
        if (!Regex.IsMatch(txtTelefono.Text, "[0-9]+")
            || txtTelefono.Text.Length > 13 || txtTelefono.Text.Length < 10
            )
        {
            isValid = false;
            txtTelefono.BorderColor = System.Drawing.Color.Red;
        }
        if (!Regex.IsMatch(txtCiudad.Text, "[A-Z][a-z]+([ ][A-Za-z]+)*"))
        {
            isValid = false;
            txtCiudad.BorderColor = System.Drawing.Color.Red;
        }     
        return isValid;
    }

}