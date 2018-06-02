<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="FrmCarrito.aspx.cs" Inherits="FrmCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minium-scale=1.0">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <asp:scriptmanager runat="server"></asp:scriptmanager>


    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <asp:Table ID="Table1"
        CssClass="table table-bordered table-hover table-responsive-sm table-responsive-md text-center display"
        runat="server" EnableTheming="True">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell Scope="Column" runat="server">Nombre</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Nombre</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Precio</asp:TableHeaderCell>
        </asp:TableHeaderRow>
    </asp:Table>

    <asp:Table ID="Table2"
        CssClass="table table-bordered table-hover table-responsive-sm table-responsive-md text-center display"
        runat="server" EnableTheming="True">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell Scope="Column" runat="server">Cantidad de Productos</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Precio Total</asp:TableHeaderCell>
        </asp:TableHeaderRow>
      
        
    </asp:Table>
    <asp:Button ID="Button1" CssClass="btn btn-outline-success col-sm-2" runat="server" Text="Realizar Compra" PostBackUrl="~/FrmPedirDatosCliente.aspx" />
    <asp:Button ID="Button2" CssClass="btn btn-outline-danger col-sm-2" runat="server" Text="Cancelar Compra" OnClick="Button2_Click" />


        </ContentTemplate>
    </asp:UpdatePanel>


    
</asp:Content>

