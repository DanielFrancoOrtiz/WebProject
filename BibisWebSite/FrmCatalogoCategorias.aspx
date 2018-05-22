<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmCatalogoCategorias.aspx.cs" Inherits="FrmCatalogoCategorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
            <asp:Button ID="Button1" CssClass="btn btn-info col-sm-12" runat="server" Text="Agregar" OnClick="Button1_Click" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
    Catálogo de Categorias
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text" id="inputGroup-sizing-default">Nombre: </span>
            </div>
           <asp:TextBox ID="txtNombre" CssClass="form-control"  runat="server"></asp:TextBox>
           </div>
        <div class="input-group mb-3">
            <div class="input-group-prepend">
                <span class="input-group-text">Descripcion: </span>
            </div>
                <asp:TextBox ID="txtDescripcion" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>

        <asp:Button ID="Button2" CssClass="btn btn-info col-sm-2" runat="server" Text="Aceptar" OnClick="Button2_Click" />
        <asp:Button ID="Button3" CssClass="btn btn-danger col-sm-2" runat="server" Text="Cancelar" />
             
            
       <asp:Table ID="Table1"
        CssClass="table table-bordered table-hover table-responsive-sm table-responsive-md text-center"
        runat="server" >
        <asp:TableHeaderRow>
            <asp:TableHeaderCell Scope="Column" runat="server">ID</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Nombre</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Descripcion</asp:TableHeaderCell>
        </asp:TableHeaderRow>
    </asp:Table>


        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    
</asp:Content>

