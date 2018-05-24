<%@ Page Title="" Language="VB" MasterPageFile="~/Principal.master" AutoEventWireup="false" CodeFile="RegistroLogin.aspx.vb" Inherits="RegistroLogin" %>

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
            <form action="#">
                <input type="text" placeholder="Usuario" required>

                <input type="password" placeholder="Contraseña" required>

                <input type="email" placeholder="Correo Electronico" required>

                <input type="text" placeholder="Teléfono" required>

                <input type="submit" value="Registrarse">
            </form>
        </div>
        </div>
       
</asp:Content>

