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
                <input type="text" class="form-control" aria-label="Default" 
                    aria-describedby="lblNombre">
        </div>
        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="lblEmail">Email: </span>
            </div>
                <input type="email" class="form-control" aria-label="Default" 
                    aria-describedby="lblEmail">
        </div>

        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="lblTelefono">Telefono: </span>
            </div>
                <input type="text" class="form-control" aria-label="Default" 
                    aria-describedby="lblTelefono">
        </div>
        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="lblDireccion">Direccion: </span>
            </div>
                <input type="text" class="form-control" aria-label="Default" 
                    aria-describedby="lblDireccion">
        </div>   
        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="lblCiudad">Diudad: </span>
            </div>
                <input type="text" class="form-control" aria-label="Default" 
                    aria-describedby="lblCiudad">
        </div>   




        <asp:Button ID="Button1" CssClass="btn btn-info col-sm-2" runat="server" Text="Aceptar" />
        <asp:Button ID="Button2" CssClass="btn btn-danger col-sm-2" runat="server" Text="Cancelar" />
</asp:Content>

