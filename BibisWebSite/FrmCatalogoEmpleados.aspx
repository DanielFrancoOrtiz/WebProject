﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmCatalogoEmpleados.aspx.cs" Inherits="FrmCatalogoEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
    <asp:Button ID="Button1" CssClass="btn btn-outline-success col-sm-12" runat="server" Text="Agregar" OnClick="Button1_Click" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
    Catálogo de Empleados
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <asp:Table ID="Table1"
        CssClass="table table-bordered table-hover table-responsive-sm table-responsive-md text-center"
        runat="server">
        <asp:TableHeaderRow>
            <asp:TableHeaderCell Scope="Column" runat="server">ID</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Nombre</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Apellidos</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Puesto</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Email</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Telefono</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Direccion</asp:TableHeaderCell>
        </asp:TableHeaderRow>

    </asp:Table>
</asp:Content>

