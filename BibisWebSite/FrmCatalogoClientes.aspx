<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmCatalogoClientes.aspx.cs" Inherits="FrmCatalogoClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
    Catálogo de Clientes
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <asp:Table ID="Table1"
        CssClass="table table-bordered table-hover table-responsive-sm table-responsive-md text-center"
        runat="server">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell Scope="Column" runat="server">ID</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Nombre</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Apellidos</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Telefono</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Email</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Direccion</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Ciudad</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Codigo Postal</asp:TableHeaderCell>
        </asp:TableHeaderRow>

    </asp:Table>
</asp:Content>

