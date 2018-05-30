<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEmpleado.master" AutoEventWireup="true" CodeFile="FrmRegistrarLogin.aspx.cs" Inherits="FrmRegistrarLogin" %>
<%@ PreviousPageType VirtualPath="~/FrmCatalogoEmpleados.aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link rel="stylesheet" href="Styles/estilosLogin.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
     <div class="contenedor-form">
         <div class="toggle">
         </div>
         <div class="formulario">
             <h2>Crea tu Cuenta</h2>
             <asp:Label ID="Label1" runat="server" Text="ID: " Visible="False"></asp:Label>
             <asp:Label ID="lblID" runat="server" Text="Label" Visible="False"></asp:Label>
             <form action="#">
                 <input id="txtNombre" runat="server" type="text" placeholder="Nombre" required />
                 <input id="txtApellido" runat="server" type="text" placeholder="Apellidos" required />
                 <input id="txtUsuario" runat="server" type="text" placeholder="Usuario" required />
                 <input id="txtPuesto" runat="server" type="text" placeholder="Puesto" required />
                 <input id="txtCorreo" runat="server" type="email" placeholder="Correo Electronico" required />
                 <input id="txtTelefono" runat="server" type="text" placeholder="Teléfono" required />
                 <input id="txtDireccion" runat="server" type="text" placeholder="Direccion" required />
                 <input id="txtPass" runat="server" type="password" placeholder="Contraseña" required />
                 <asp:Button ID="bntRegistrar" runat="server" OnClick="bntRegistrar_Click" Text="Registrar" />
             </form>
         </div>
     </div>
</asp:Content>

