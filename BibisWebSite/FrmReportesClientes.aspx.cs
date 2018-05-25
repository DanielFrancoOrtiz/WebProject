using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;

public partial class FrmReportesClientes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Asegura que el reporte solo se cargue la primera vez que se muestra la página
        if (IsPostBack) return;

        //Crear la fuente de datos para el reporte (se requiere importar además de modelo y datos, el namespace
        //Microsoft.Reporting.WebForms que es donde se encuentra la clase ReportDataSource)
        //NOTA: "ListaDatos" debe coincidir con la fuente de datos que ustedes usaron al crear el reporte mediante el asistente.
        ReportDataSource fuente = new ReportDataSource("ClientesDataSet1", new DaoCliente().ConsultarTodos());


        //Asignar la fuente de datos creada al reporte
        ReportViewer1.LocalReport.DataSources.Add(fuente);
        
    }
}