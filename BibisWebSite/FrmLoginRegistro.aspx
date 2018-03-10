<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
</head>
<body>
    <form id="form1" runat="server"> 
        <div>
            <h2>Registro</h2>
            Nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtNombre" runat="server" Width="178px"></asp:TextBox>
            <br />
            Contrasena:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtpassword" runat="server" Width="181px"></asp:TextBox>
            <br />
            Confirmar contrasena:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCpassword" runat="server" Width="177px"></asp:TextBox>
                    
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" Width="113px" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="113px" />
                    
            <br />
                            
            
       

        </div>
    </form>
</body>
</html>
