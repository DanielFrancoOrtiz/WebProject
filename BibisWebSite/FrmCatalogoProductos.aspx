<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmCatalogoProductos.aspx.cs" Inherits="FrmCatalogoProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
    <asp:Button ID="Button1" CssClass="btn btn-info col-sm-12" runat="server" Text="Agregar" OnClick="Button1_Click" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
    Catálogo de Productos
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
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
</asp:Content>

