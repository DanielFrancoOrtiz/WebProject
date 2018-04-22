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

public partial class FrmRegistoProveedor : System.Web.UI.Page
{
    string SampleID;
    XmlDocument xmlDoc;
    XmlDocument xdco = new XmlDocument();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void mostrar()
    {
        DataSet ds = new DataSet();
        ds.ReadXml(Server.MapPath("DatosProveedor.xml"));
        //GridView1.DataSource = ds;
       // GridView1.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string fileXML = Server.MapPath("DatosProveedor.xml");
        if (File.Exists(fileXML) == true)
        {

            xdco.Load(Server.MapPath("DatosProveedor.xml"));
            XmlElement Proveedoor = xdco.CreateElement("DatosProveedor");

            //atributos o elementos internos
         

            XmlElement nombre = xdco.CreateElement("Nombre");
            XmlText xmlNOmbre = xdco.CreateTextNode(txtNombre.Text);

            XmlElement email = xdco.CreateElement("Email");
            XmlText xmlemail = xdco.CreateTextNode(txtEmail.Text);

            XmlElement telefono = xdco.CreateElement("Telefono");
            XmlText xmlTelefono = xdco.CreateTextNode(txtTelefono.Text);

            XmlElement direccion = xdco.CreateElement("Direccion");
            XmlText xmlDireccion = xdco.CreateTextNode(txtDireccion.Text);

            XmlElement Ciudad = xdco.CreateElement("Cuidad");
            XmlText xmlCuidad = xdco.CreateTextNode(txtCiudad.Text);


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
       
            xtw.WriteElementString("Nombre", txtNombre.Text);
            xtw.WriteElementString("Email", txtEmail.Text);
            xtw.WriteElementString("Telefono", txtTelefono.Text);
            xtw.WriteElementString("Direccion", txtDireccion.Text);
            xtw.WriteElementString("Cuidad", txtCiudad.Text);
            xtw.WriteEndElement();//cierre de nodo
            xtw.WriteEndElement();
            xtw.Close();

        }


    
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrmCatalogoProveedores.aspx");
    }
}