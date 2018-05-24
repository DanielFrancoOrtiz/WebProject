<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="FrmLoginEn.aspx.cs" Inherits="FrmLoginEn" %>

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
                <input runat="server" type="text" placeholder="Usuario" required>
                <input runat="server" type="password" placeholder="Contraseña" required>
                <input runat="server" type="submit" value="Iniciar Sesión">
            </form>
        </div>

       
        <div class="reset-password">
            <a href="#">Olvide mi Contraseña?</a>
        </div>
    </div>
    <script src="Styles/js/jquery-3.3.1.min.js"></script>
    <script src="Styles/js/main.js"></script>


</asp:Content>

