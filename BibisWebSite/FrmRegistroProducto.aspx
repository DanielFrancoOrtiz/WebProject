<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmRegistroProducto.aspx.cs" Inherits="FrmProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
    Registrar Producto
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="ID: " Visible="False"></asp:Label>
    <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
    <div class="row">
        
    <div class ="container row col-sm-9">
    
    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblNombre">Nombre: </span>
        </div>
        <asp:textbox id="txtNombre" cssclass="form-control" runat="server"></asp:textbox>

    </div>
    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblModelo">Modelo: </span>
        </div>
        <asp:textbox id="txtModelo" autocompletetype="Email" cssclass="form-control" runat="server"></asp:textbox>

    </div>

    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblDantidad">Cantidad: </span>
        </div>
        <asp:textbox id="txtCantidad" cssclass="form-control" runat="server"></asp:textbox>


    </div>
    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblPrecioC">Precio Compra: </span>
        </div>
        <asp:textbox id="txtPrecioC" cssclass="form-control" runat="server"></asp:textbox>

    </div>

    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblPRecioV">Precio Venta: </span>
        </div>
        <asp:textbox id="txtPrecioV" cssclass="form-control" runat="server"></asp:textbox>
    </div>

    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblProveedor">Proveedor: </span>
        </div>
        <asp:dropdownlist ID="cmbProveedor" cssclass="form-control" runat="server">
            <asp:ListItem CssClass="dropdown-item">Opcion 1</asp:ListItem>
            <asp:ListItem CssClass="dropdown-item">Opcion 2</asp:ListItem>
            <asp:ListItem CssClass="dropdown-item">Opcion 3</asp:ListItem>
        </asp:dropdownlist>
    </div>
    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblCategoria">Categoria: </span>
        </div>
        <asp:dropdownlist ID="cmbCategoria" CssClass="form-control" runat="server">
            <asp:ListItem CssClass="dropdown-item">Opcion 1</asp:ListItem>
            <asp:ListItem CssClass="dropdown-item">Opcion 2</asp:ListItem>
            <asp:ListItem CssClass="dropdown-item">Opcion 3</asp:ListItem>
        </asp:dropdownlist>
    </div>
    <div class="input-group mb-3">
        <div class="input-group-prepend">
            <span class="input-group-text" id="lblDescripbion">Descipcion: </span>
        </div>
        <textarea id="txtDescripcion" runat="server" class="form-control" aria-label="With textarea"></textarea>
    </div>

    <asp:button ID="btnAceptar" cssclass="btn btn-outline-info col-sm-3" runat="server" text="Agregar" OnClick="btnAceptar_Click" />
    <asp:button ID="btnCancelar" cssclass="btn btn-outline-danger col-sm-3" runat="server" text="Cancelar" OnClick="btnCancelar_Click" />
    </div>
   </div>
</asp:Content>

