﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrmReporteOrdenes.aspx.cs" Inherits="FrmReporteOrdenes" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <div>
    <rsweb:ReportViewer ID="ReportViewer2" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="879px">
        <LocalReport ReportPath="ListadoOrdenes.rdlc">
                <DataSources>
                    <%--<rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="ClientesDataSet1" />--%>
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="ConsultarTodos" TypeName="global.DaoOrden"></asp:ObjectDataSource>
        
    
    </div>
    </form>
</body>
</html>
