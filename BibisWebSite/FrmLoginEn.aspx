<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="FrmLoginEn.aspx.cs" Inherits="FrmLoginEn" EnableEventValidation="true" %>
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
            <h2>Iniciar Sesión</h2>
            <form action="#">
                <input runat="server" id ="txtUsuario" type="text" placeholder="Usuario" required>
                <input runat="server" id="txtPass" type="password" placeholder="Contraseña" required>
               <!-- <input id="btnInicio" runat="server" type="submit" value="Iniciar Sesión">
               --> 
                <asp:button id="btnIni" runat="server" text="Inicio Sesion" onclick="btnIni_Click" />
            </form>
        </div>

       
        <div class="reset-password">
            <a href="#">¿Olvidaste tu contraseña?</a>
        </div>
    </div>
    <script src="Styles/js/jquery-3.3.1.min.js"></script>
    <script src="Styles/js/main.js"></script>


</asp:Content>

