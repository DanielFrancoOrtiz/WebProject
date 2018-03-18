<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmRegistroCategoria.aspx.cs" Inherits="FrmRegistoCategoria" %>

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
               <!-- <input id="txtNombre" type="text" class="form-control" aria-label="Default" aria-describedby="inputGroup-sizing-default">
               --> 
           <asp:TextBox ID="txtNombre" CssClass="form-control"  runat="server"></asp:TextBox>
           </div>
        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text">Descripcion: </span>
            </div>
                <asp:TextBox ID="txtDescripcion" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" CssClass="btn btn-info col-sm-2" runat="server" Text="Aceptar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" CssClass="btn btn-danger col-sm-2" runat="server" Text="Cancelar" OnClick="Button2_Click" />

</asp:Content>

