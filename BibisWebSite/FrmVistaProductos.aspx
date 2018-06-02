<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="FrmVistaProductos.aspx.cs" Inherits="FrmVistaProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minium-scale=1.0">
        <style>

            body {
    
         font-family: sans-serif Latha;
         font-size:18px;  
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">

   <div id="divRow" runat="server" class="row">
<!-- ------------------------------------------------------------------------------- --> 		
       <div runat="server" id="divProducto1" class="col-md-4 col-sm-4 card">
			<div class="">
				<asp:Image ID="Image1" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
			</div>
           <div class ="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label1" runat="server" CssClass="text-center text-info" Text=""></asp:Label>
                   <br />
                   <asp:Label ID="Label2" runat="server" CssClass="text-center" Text=""></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Comprar" OnClick="Button1_Click" PostBackUrl="~/FrmPedirDatosCliente.aspx" />
                   <asp:Button ID="Button7" CssClass="btn btn-warning" runat="server" Text="Carrito" OnClick="Button7_Click" />
               </div>
           </div>			
		</div>
<!-- ------------------------------------------------------------------------------- -->

       <div runat="server" id="divProducto2" class="col-md-4 col-sm-4 card">
           <div class="">
               <asp:Image ID="Image2" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
           </div>
           <div class="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label3" runat="server" CssClass="text-center text-info" Text=""></asp:Label>
                   <br />
                   <asp:Label ID="Label4" runat="server" CssClass="text-center" Text=""></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button2" CssClass="btn btn-success" runat="server" Text="Comprar" OnClick="Button2_Click" PostBackUrl="~/FrmPedirDatosCliente.aspx" />
                   <asp:Button ID="Button8" CssClass="btn btn-warning" runat="server" Text="Carrito" OnClick="Button8_Click" />
               </div>
           </div>
       </div>
<!-- ------------------------------------------------------------------------------- -->

       <div runat="server" id="divProducto3" class="col-md-4 col-sm-4 card">
           <div class="">
               <asp:Image ID="Image3" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
           </div>
           <div class="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label5" runat="server" CssClass="text-center text-info" Text=""></asp:Label>
                   <br />
                   <asp:Label ID="Label6" runat="server" CssClass="text-center" Text=""></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button3" CssClass="btn btn-success" runat="server" Text="Comprar" OnClick="Button3_Click" PostBackUrl="~/FrmPedirDatosCliente.aspx" />
                   <asp:Button ID="Button9" CssClass="btn btn-warning" runat="server" Text="Carrito" OnClick="Button9_Click" />
               </div>
           </div>
       </div>
<!-- ------------------------------------------------------------------------------- -->

       <div runat="server" id="divProducto4" class="col-md-4 col-sm-4 card">
           <div class="">
               <asp:Image ID="Image4" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
           </div>
           <div class="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label7" runat="server" CssClass="text-center text-info" Text=""></asp:Label>
                   <br />
                   <asp:Label ID="Label8" runat="server" CssClass="text-center" Text=""></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button4" CssClass="btn btn-success" runat="server" Text="Comprar" OnClick="Button4_Click" PostBackUrl="~/FrmPedirDatosCliente.aspx" />
                   <asp:Button ID="Button10" CssClass="btn btn-warning" runat="server" Text="Carrito" OnClick="Button10_Click" />
               </div>
           </div>
       </div>
<!-- ------------------------------------------------------------------------------- -->

       <div runat="server" id="divProducto5" class="col-md-4 col-sm-4 card">
           <div class="">
               <asp:Image ID="Image5" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
           </div>
           <div class="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label9" runat="server" CssClass="text-center text-info" Text=""></asp:Label>
                   <br />
                   <asp:Label ID="Label10" runat="server" CssClass="text-center" Text=""></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button5" CssClass="btn btn-success" runat="server" Text="Comprar" OnClick="Button5_Click" PostBackUrl="~/FrmPedirDatosCliente.aspx" />
                   <asp:Button ID="Button11" CssClass="btn btn-warning" runat="server" Text="Carrito" OnClick="Button11_Click" />
               </div>
           </div>
       </div>

<!-- ------------------------------------------------------------------------------- -->

       <div runat="server" id="divProducto6" class="col-md-4 col-sm-4 card">
           <div class="">
               <asp:Image ID="Image6" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
           </div>
           <div class="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label11" runat="server" CssClass="text-center text-info" Text=""></asp:Label>
                   <br />
                   <asp:Label ID="Label12" runat="server" CssClass="text-center" Text=""></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button6" CssClass="btn btn-success" runat="server" Text="Comprar" OnClick="Button6_Click" PostBackUrl="~/FrmPedirDatosCliente.aspx" />
                   <asp:Button ID="Button12" CssClass="btn btn-warning" runat="server" Text="Carrito" OnClick="Button12_Click" />
               </div>
           </div>
       </div>






	</div>
    <nav aria-label="...">
        <ul class="pagination">
            <li runat="server" id="liPrevio" class="page-item">
           <!--     <a class="page-link" href="#" tabindex="-1">Previous</a>-->
                <asp:button ID="btnPrevio" CssClass="page-link" runat="server" tabindex="-1" text="Previus" OnClick="btnPrevio_Click" />
            </li>
            <li class="page-item">
               <!-- <a class="page-link" href="#">Next</a>-->
                <asp:button ID="btn4" runat="server" cssclass="page-link" text="Next" OnClick="btn4_Click" />
            </li>
        </ul>
    </nav>
</asp:Content>

