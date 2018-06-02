using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FrmLoginEn : System.Web.UI.Page
{
    WebService1.WebService1SoapClient servicio = new WebService1.WebService1SoapClient();
    //WebServiceAndres.WebService1SoapClient servicio = new WebServiceAndres.WebService1SoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Nombre"] != null)
        {
            Session.Remove("Nombre");
            Session.Remove("Puesto");
        }

    }
    protected void btnIni_Click(object sender, EventArgs e) {
        string user = txtUsuario.Value;
        string pass = txtPass.Value;
        Empleado em = JsonConvert.DeserializeObject<Empleado>( servicio.Logear(user, pass));
        if (em != null)
        {
            Session["Nombre"] = em.Nombre;
            Session["Puesto"] = em.Puesto;
            Response.Redirect("DefaultEmpleados.aspx");
            
        }
        else {
            Response.Write("<script>alert('Usuario o contraseña no validos')</script>");

        }

    }

}