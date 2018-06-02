<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="FrmPedirDatosCliente.aspx.cs" Inherits="FrmPedirDatosCliente" %>
<%@ PreviousPageType VirtualPath="~/FrmCarrito.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    
    <!-- lientes(Nombre, Apellidos, Email, Telefono, Direccion, Ciudad, Codigo_Postal) -->
    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblNombre">Nombre: </span>
        </div>
        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>

    </div>
    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblApellidos">Apellidos: </span>
        </div>
        <asp:TextBox ID="txtApellidos" CssClass="form-control" runat="server"></asp:TextBox>

    </div>
    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblEmail">Email: </span>
        </div>
        <asp:TextBox ID="txtEmail" AutoCompleteType="Email" CssClass="form-control" runat="server"></asp:TextBox>

    </div>

    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblTelefono">Telefono: </span>
        </div>
        <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>


    </div>
    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblDireccion">Direccion: </span>
        </div>
        <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server"></asp:TextBox>

    </div>
    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblCiudad">Ciudad: </span>
        </div>
        <asp:TextBox ID="txtCiudad" CssClass="form-control" runat="server"></asp:TextBox>

    </div>
    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblCP">Código Postal: </span>
        </div>
        <asp:TextBox ID="txtCP" CssClass="form-control" runat="server"></asp:TextBox>

    </div>
    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblMetPago">Metodo de Pago: </span>
        </div>
        <asp:DropDownList ID="cmbMetPAgo" CssClass="form-control" runat="server" OnSelectedIndexChanged="cmbMetPAgo_SelectedIndexChanged">
            <asp:ListItem CssClass="dropdown-item">PayPal</asp:ListItem>
            <asp:ListItem CssClass="dropdown-item">Tarjeta de Credito</asp:ListItem>
            <asp:ListItem CssClass="dropdown-item">Tarjeta de Devito</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button3" CssClass="btn btn-outline-primary col-sm-2" runat="server" Text="Aceptar" OnClick="Button3_Click" />
    </div>
    <div runat="server" id="divCodigo"  class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblCodigo">Código: </span>
        </div>
        <asp:TextBox ID="TextBox1" CssClass="form-control col-sm-6" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        

    </div>


    <asp:Button ID="Button1" CssClass="btn btn-outline-success col-sm-2" runat="server" Text="Realizar compra" OnClick="Button1_Click"/>
    <asp:Button ID="Button2" CssClass="btn btn-outline-danger col-sm-2" runat="server" Text="Cancelar" OnClick="Button2_Click"/>

</asp:Content>

