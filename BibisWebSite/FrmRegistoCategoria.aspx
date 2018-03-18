<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="FrmRegistoCategoria.aspx.cs" Inherits="FrmRegistoCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
    Registrar Categoria
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
       <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="inputGroup-sizing-default">Nombre: </span>
            </div>
                <input type="text" class="form-control" aria-label="Default" aria-describedby="inputGroup-sizing-default">
        </div>
        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text">Descripcion: </span>
            </div>
                <textarea class="form-control" aria-label="With textarea"></textarea>
        </div>
        <asp:Button ID="Button1" CssClass="btn btn-info col-sm-2" runat="server" Text="Aceptar" />
        <asp:Button ID="Button2" CssClass="btn btn-danger col-sm-2" runat="server" Text="Cancelar" />

</asp:Content>

