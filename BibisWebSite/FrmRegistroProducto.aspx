<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmRegistroProducto.aspx.cs" Inherits="FrmProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #Select1 {
            width: 130px;
        }
        #Select2 {
            width: 130px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
    Registrar Producto
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
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

    <asp:button id="Button1" cssclass="btn btn-info col-sm-3" runat="server" text="Aceptar" />
    <asp:button id="Button2" cssclass="btn btn-danger col-sm-3" runat="server" text="Cancelar"  />
    </div>
    <div class="container row col-sm-3">
        <div class="card" style="width: 18rem;">
            <asp:image id="Image1" cssclass="card-img-bottom"
                runat="server" height="200px" imageurl="~/imgs/Logo.jpg" />
            <div class="card-body">
                <h5 class="card-title">Imagen</h5>               
                <a href="#" class="btn btn-primary">Cargar Imagen</a>
            </div>
        </div>
    </div>
    </div>
</asp:Content>

