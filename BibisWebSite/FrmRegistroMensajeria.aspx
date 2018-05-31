<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmRegistroMensajeria.aspx.cs" Inherits="FrmRegistroMensajeria" %>
<%@ PreviousPageType VirtualPath="~/FrmCatalogoMensajeria.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minium-scale=1.0">
        <style>

            body {
    
         font-family: sans-serif Latha;
         font-size:18px;  
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
    Registro de Mensajeria
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">

    <asp:Label ID="Label1" runat="server" Text="ID: " Visible="False"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="" Visible="False"></asp:Label>
    <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="lblNombre">Nombre: </span>
            </div>
            <asp:TextBox ID="txtNombre" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>
        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="lblEmail">Email: </span>
            </div>
            <asp:TextBox AutoCompleteType="Email" ID="txtEmail" CssClass="form-control"  runat="server"></asp:TextBox>
                    
        </div>

        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="lblTelefono">Telefono: </span>
            </div>
            <asp:TextBox ID="txtTelefono"  CssClass="form-control"  runat="server"></asp:TextBox>
        </div>   
    
        <asp:Button ID="Button1" CssClass="btn btn-outline-info col-sm-2" runat="server" Text="Agregar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" CssClass="btn btn-outline-danger col-sm-2" runat="server" Text="Cancelar" OnClick="Button2_Click" />

</asp:Content>

