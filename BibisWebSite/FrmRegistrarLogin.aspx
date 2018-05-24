<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="FrmRegistrarLogin.aspx.cs" Inherits="FrmRegistrarLogin" %>

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
                <input type="text" placeholder="Nombre" required />
                <input type="text" placeholder="Apellido" required />
                <input type="text" placeholder="Usuario" required/>
                <input type="text" placeholder="Puesto" required />
                <input type="email" placeholder="Correo Electronico" required/>
                <input type="text" placeholder="Teléfono" required/>
                <input type="text" placeholder="Direccion" required />
                <input type="password" placeholder="Contraseña" required/>
                <input runat="server" type="submit" value="Registar">
                

</asp:Content>

