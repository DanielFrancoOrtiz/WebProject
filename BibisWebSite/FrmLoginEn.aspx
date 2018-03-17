<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="FrmLoginEn.aspx.cs" Inherits="FrmLoginEn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
     <div class="text-center">

                <span class="auto-style1"><strong>Usuario</strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;        <asp:TextBox ID="txtUsuario" runat="server" Width="179
                    px"></asp:TextBox>
            <br />

                <strong><span class="auto-style1">Contraseña </span></strong>:     <asp:TextBox ID="tstContrasena" runat="server" Width="179px" TextMode="Password"></asp:TextBox>

       
                <br />
                <br />
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnAcceder" runat="server" Text="Entrar" Width="128px" />
                <br />

       
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
</asp:Content>

