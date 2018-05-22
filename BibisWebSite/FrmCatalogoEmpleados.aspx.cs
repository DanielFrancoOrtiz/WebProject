using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

public partial class FrmCatalogoEmpleados : System.Web.UI.Page
{
    DaoEmpleado dao = new DaoEmpleado();
    protected void Page_Load(object sender, EventArgs e)
    {
        WebService1.WebService1SoapClient servicio = new WebService1.WebService1SoapClient();
        List<Empleado> lista = JsonConvert.DeserializeObject<List<Empleado>>(servicio.ConsultarTodos());

        if (lista != null)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                TableCell cId = new TableCell();
                cId.Text = Convert.ToString(lista[i].Id);
                TableCell cNom = new TableCell();
                cNom.Text = lista[i].Nombre;
                TableCell cApe = new TableCell();
                cApe.Text = lista[i].Apellidos;

                TableCell cPuesto = new TableCell();
                cPuesto.Text = lista[i].Puesto;

                TableCell cEm = new TableCell();
                cEm.Text = lista[i].Email;
                TableCell cTel = new TableCell();
                cTel.Text = lista[i].Telefono;
                TableCell cDir = new TableCell();
                cDir.Text = lista[i].Direccion;
                TableCell cCity = new TableCell();

                TableRow tr = new TableRow();
                tr.Cells.Add(cId);
                tr.Cells.Add(cNom);
                tr.Cells.Add(cApe);
                tr.Cells.Add(cPuesto);
                tr.Cells.Add(cEm);
                tr.Cells.Add(cTel);
                tr.Cells.Add(cDir);

                Table1.Rows.Add(tr);
            }
        }

        }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
}