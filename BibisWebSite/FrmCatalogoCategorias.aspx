<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmCatalogoCategorias.aspx.cs" Inherits="FrmCatalogoCategorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta charset="utf-8" />
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
    Catálogo de Categorias
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label2" runat="server" Text="ID: " Visible="False"></asp:Label>
            <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
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
                <asp:TextBox ID="txtDescripcion" TextMode ="MultiLine" CssClass="form-control"  runat="server"></asp:TextBox>
        </div>

        <asp:Button ID="Button2" CssClass="btn btn-outline-success col-sm-2" runat="server" Text="Agregar" OnClick="Button2_Click" />
        <asp:Button ID="Button3" CssClass="btn btn-outline-danger col-sm-2" runat="server" Text="Cancelar" OnClick="Button3_Click"  />
             
            
       <asp:Table ID="Table1"
        CssClass="table table-bordered table-hover table-responsive-sm table-responsive-md text-center display"
        runat="server" EnableTheming="True" >
        <asp:TableHeaderRow>
            <asp:TableHeaderCell Scope="Column" runat="server">Administrar</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">ID</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Nombre</asp:TableHeaderCell>
            <asp:TableHeaderCell Scope="Column" runat="server">Descripcion</asp:TableHeaderCell>
        </asp:TableHeaderRow>
    </asp:Table>

        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>

