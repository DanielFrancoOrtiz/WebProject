<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmCatalogoProductos.aspx.cs" Inherits="FrmCatalogoProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minium-scale=1.0">
     <script src="Styles/js/jquery-3.2.1.min.js"></script>
    <script src="Styles/js/jspdf.debug.js"></script> 
    <style>

            body {
    
         font-family: sans-serif Latha;
         font-size:18px;  
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
    <asp:Button ID="Button1" CssClass="btn btn-outline-success col-sm-12" runat="server" Text="Agregar" OnClick="Button1_Click" />
     <asp:Button ID="btnGenerarReporte" CssClass="btn btn-outline-info col-sm-12" runat="server" Text="Generar Reporte" OnClick="btnGenerarReporte_Click" />
         <asp:Button ID="Button2" CssClass="btn btn-outline-info col-sm-12" runat="server" Text="Reporte_Ordenes" OnClick="btnGenerarReporteOrdenes_Click" />
     <asp:Button ID="Button3" CssClass="btn btn-outline-info col-sm-12" runat="server" Text="Reporte_PreVentas" OnClick="btnGenerarReportePreventa_Click" />
          <asp:Button ID="Button4" CssClass="btn btn-outline-info col-sm-12" runat="server" Text="Ver Visitas" OnClick="btnVerVisitas_Click" />

      <input type="button"   onclick="DescargarPDF('reporte','Reporte de Productos')" value="Decargar Reporte"/>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
    Catálogo de Productos
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <div class="reporte">
    <asp:Table ID="Table1"
        CssClass="table table-bordered table-hover table-responsive-sm table-responsive-md text-center"
        runat="server">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell Scope="Column" runat="server">Administrar</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">ID</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Nombre</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Modelo</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Cantidad</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Precio Compra</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Precio Venta</asp:TableHeaderCell>
        </asp:TableHeaderRow>

    </asp:Table>
        </div>
    <script >
        function DescargarPDF(ContenidoID, nombre) {
            var pdf = new jsPDF('p', 'pt', 'letter');
             
            html = $('.' + ContenidoID).html();
            specialElementHandlers = {};
            margins = { top: 10, bottom: 20, left: 20, width: 822 };
            pdf.fromHTML(html, margins.left, margins.top, { 'width': margins.width }, function (dispose) { pdf.save(nombre + '.pdf'); }, margins);
        }

    </script>
</asp:Content>

