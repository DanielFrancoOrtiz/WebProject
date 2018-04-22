<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmRegistroProveedor.aspx.cs" Inherits="FrmRegistoProveedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
    Registro de Proveedor
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
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

    


        <asp:Button ID="Button1" CssClass="btn btn-info col-sm-2" runat="server" Text="Aceptar" OnClick="Button1_Click" style="left: 0px; top: 0px" />
        <asp:Button ID="Button2" CssClass="btn btn-danger col-sm-2" runat="server" Text="Cancelar" OnClick="Button2_Click" />
</asp:Content>

