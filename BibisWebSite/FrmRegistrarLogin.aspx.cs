using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
public partial class FrmRegistrarLogin : System.Web.UI.Page
{
    WebService1.WebService1SoapClient servicio = new WebService1.WebService1SoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Nombre"] != null)
        {
            Response.Write("<script>alert('Welcome!!" + Session["Nombre"].ToString() + "')</script>");
        }
        else
        {
            Response.Redirect("FrmLoginEn.aspx");
        }

        if (Page.PreviousPage != null)
        {
            

            if (!lblID.Visible)
            {
                string id = PreviousPage.getID();
                Empleado em = JsonConvert.DeserializeObject<Empleado>(servicio.Buscar(Convert.ToInt32(id)));
                Label1.Visible = true;
                lblID.Text= Convert.ToString( em.Id);
                txtNombre.Value = em.Nombre;
                txtApellido.Value = em.Apellidos;
                txtUsuario.Value = em.Usuario;
                txtPuesto.Value = em.Puesto;
                txtCorreo.Value = em.Email;
                txtDireccion.Value = em.Direccion;
                txtTelefono.Value = em.Telefono;
                bntRegistrar.Text = "Actualizar";
                lblID.Visible = true;  
            }
        }
    }
    protected void bntRegistrar_Click(object sender, EventArgs e) {
        Empleado em = new Empleado();
        em.Nombre = txtNombre.Value;
        em.Apellidos = txtApellido.Value;
        em.Puesto = txtPuesto.Value;
        em.Usuario = txtUsuario.Value;
        em.Telefono = txtTelefono.Value;
        em.Direccion = txtDireccion.Value;
        em.Email = txtCorreo.Value;
        if ((bntRegistrar.Text).Equals("Actualizar"))
        {
            em.Id = Convert.ToInt32(lblID.Text);
            if (servicio.Actualizar(JsonConvert.SerializeObject(em)) == 1)
            {
                Response.Redirect("FrmCatalogoEmpleados.aspx");
            }
            else {
                Response.Write("<script>alert('Error al Actualizar')</script>");
            }

        }
        else {
            if (servicio.Insertar(JsonConvert.SerializeObject(em)) == 1)
            {
                txtNombre.Value = null;
                txtApellido.Value = null;
                txtUsuario.Value = null;
                txtCorreo.Value = null;
                txtDireccion.Value = null;
                txtPuesto.Value = null;
                txtPass.Value = null;
                Response.Write("<script>alert('Empleado agregado Exitosamente!!')</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al Agregar')</script>");
            }
        }

    }
    

}