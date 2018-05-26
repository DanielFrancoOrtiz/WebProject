<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmRegistroProveedor.aspx.cs" Inherits="FrmRegistoProveedor" %>
<%@ PreviousPageType VirtualPath="~/FrmCatalogoProveedores.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
    Registro de Proveedor
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="ID: " Visible="False"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="" Visible="False"></asp:Label>
    <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="lblNombre">Nombre: </span>
            </div>
            <asp:TextBox  ID="txtNombre" CssClass="form-control"  runat="server"></asp:TextBox>

    </div>
        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="lblEmail">Email: </span>
            </div>
            <asp:TextBox  ID="txtEmail" AutoCompleteType="Email" CssClass="form-control"  runat="server"></asp:TextBox>

        </div>

        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="lblTelefono">Telefono: </span>
            </div>
            <asp:TextBox  ID="txtTelefono" CssClass="form-control"  runat="server"></asp:TextBox>


        </div>
        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="lblDireccion">Direccion: </span>
            </div>
            <asp:TextBox  ID="txtDireccion" CssClass="form-control"  runat="server"></asp:TextBox>

        </div>   
        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="lblCiudad">Ciudad: </span>
            </div>
            <asp:TextBox  ID="txtCiudad" CssClass="form-control"  runat="server"></asp:TextBox>

        </div>   

    


        <asp:Button ID="Button1" CssClass="btn btn-outline-success col-sm-2" runat="server" Text="Agregar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" CssClass="btn btn-outline-danger col-sm-2" runat="server" Text="Cancelar" OnClick="Button2_Click" />
</asp:Content>

