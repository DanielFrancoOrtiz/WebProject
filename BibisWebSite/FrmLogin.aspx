<%@ Page Language="C#" %>

<!DOCTYPE html>
<script runat="server">

    protected void btnAcceder_Click(object sender, EventArgs e)
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

                Usuario:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;         <asp:TextBox ID="txtUsuario" runat="server" Width="180px"></asp:TextBox>
            <br />

                Contrasena:     <asp:TextBox ID="tstContrasena" runat="server" Width="179px"></asp:TextBox>

       
                <br />
                <br />
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnAcceder" runat="server" Text="Entrar" Width="128px" OnClick="btnAcceder_Click" />
                <br />

       
        </div>

       
    </form>
</body>
</html>
