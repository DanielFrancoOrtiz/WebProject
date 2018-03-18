<%@ Page Language="C#" %>

<!DOCTYPE html>
<script runat="server">

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {

    }
</script>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
</head>
<body>
    <form id="form1" runat="server"> 
        <div>
            <h2>Registro</h2>
            Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtNombre" runat="server" Width="172px"></asp:TextBox>
            <br />
            Apellido:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtApellido" runat="server" Width="172px"></asp:TextBox>
            <br />
            Telefono:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="txtTelefono" runat="server" Width="172px"></asp:TextBox>
            <br />        
            Direccion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtDireccion" runat="server" Width="172px"></asp:TextBox>
            <br />
            Cuidad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCuidad" runat="server" Width="172px"></asp:TextBox>
            <br />        
            Codigo Postal:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCodiP" runat="server" Width="172px"></asp:TextBox>
            <br />
            Contrasena:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtContrasena" runat="server" Width="172px"></asp:TextBox>
            <br />
            Confirmar contrasena:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCfContra" runat="server" Width="172px"></asp:TextBox>       
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" Width="113px" OnClick="btnRegistrar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="113px" />
                    
            <br />
                            
            
       

        </div>
    </form>
</body>
</html>
