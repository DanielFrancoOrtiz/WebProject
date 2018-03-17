<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="FrmRegistroLogin.aspx.cs" Inherits="FrmRegistroLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
     <div class="text-center">
            <h2><strong>Registro</strong></h2>
            <strong><span class="auto-style1" >
         <samp>
            Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             </samp>               
            
       

            </span>
         <samp>
            <asp:TextBox ID="txtNombre" runat="server" Width="172px" CssClass="auto-style1"></asp:TextBox>
            <br class="auto-style1" />
            <span class="auto-style1">Apellido:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><asp:TextBox ID="txtApellido" runat="server" Width="172px" CssClass="auto-style1"></asp:TextBox>
            <br class="auto-style1" />
            <span class="auto-style1">Telefono:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</span><asp:TextBox ID="txtTelefono" runat="server" Width="172px" CssClass="auto-style1"></asp:TextBox>
            <br class="auto-style1" />        
            <span class="auto-style1">Direccion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><asp:TextBox ID="txtDireccion" runat="server" Width="172px" CssClass="auto-style1"></asp:TextBox>
            <br class="auto-style1" />
            <span class="auto-style1">Cuidad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><asp:TextBox ID="txtCuidad" runat="server" Width="172px" CssClass="auto-style1"></asp:TextBox>
            <br class="auto-style1" />        
            <span class="auto-style1">Codigo Postal:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="txtCodiP" runat="server" Width="172px" CssClass="auto-style1"></asp:TextBox>
            <br class="auto-style1" />
            <span class="auto-style1">Contrasena:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="txtContrasena" runat="server" Width="172px" CssClass="auto-style1" TextMode="Password"></asp:TextBox>
            <br class="auto-style1" />
            <span class="auto-style1">Confirmar contrasena:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span> <asp:TextBox ID="txtCfContra" runat="server" Width="172px" CssClass="auto-style1" TextMode="Password"></asp:TextBox>       
            <br class="auto-style1" />
             </samp>               
            
       

            </strong>
         <samp>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
           <br />  
           <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" Width="113px" />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="113px" />
                    
            <br />
             </samp>               
            
       

        </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
</asp:Content>

