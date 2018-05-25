<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="FrmVistaProductos.aspx.cs" Inherits="FrmVistaProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">

   <div id="divRow" runat="server" class="row">
		
       <div class="col-md-3 col-sm-4 card">
			<div class="">
				<asp:Image ID="Image1" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
			</div>
           <div class ="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label1" runat="server" CssClass="text-center text-info" Text="Hola"></asp:Label>
                   <br />
                   <asp:Label ID="Label2" runat="server" CssClass="text-center" Text="$50:00"></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Comprar" />
               </div>
           </div>			
		</div>

       <div class="col-md-3 col-sm-4 card">
           <div class="">
               <asp:Image ID="Image2" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
           </div>
           <div class="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label3" runat="server" CssClass="text-center text-info" Text="Hola"></asp:Label>
                   <br />
                   <asp:Label ID="Label4" runat="server" CssClass="text-center" Text="$50:00"></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button2" CssClass="btn btn-success" runat="server" Text="Comprar" />
               </div>
           </div>
       </div>

       <div class="col-md-3 col-sm-4 card">
           <div class="">
               <asp:Image ID="Image3" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
           </div>
           <div class="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label5" runat="server" CssClass="text-center text-info" Text="Hola"></asp:Label>
                   <br />
                   <asp:Label ID="Label6" runat="server" CssClass="text-center" Text="$50:00"></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button3" CssClass="btn btn-success" runat="server" Text="Comprar" />
               </div>
           </div>
       </div>

       <div class="col-md-3 col-sm-4 card">
           <div class="">
               <asp:Image ID="Image4" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
           </div>
           <div class="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label7" runat="server" CssClass="text-center text-info" Text="Hola"></asp:Label>
                   <br />
                   <asp:Label ID="Label8" runat="server" CssClass="text-center" Text="$50:00"></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button4" CssClass="btn btn-success" runat="server" Text="Comprar" />
               </div>
           </div>
       </div>

       <div class="col-md-3 col-sm-4 card">
           <div class="">
               <asp:Image ID="Image5" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
           </div>
           <div class="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label9" runat="server" CssClass="text-center text-info" Text="Hola"></asp:Label>
                   <br />
                   <asp:Label ID="Label10" runat="server" CssClass="text-center" Text="$50:00"></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button5" CssClass="btn btn-success" runat="server" Text="Comprar" />
               </div>
           </div>
       </div>


       <div class="col-md-3 col-sm-4 card">
           <div class="">
               <asp:Image ID="Image6" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
           </div>
           <div class="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label11" runat="server" CssClass="text-center text-info" Text="Hola"></asp:Label>
                   <br />
                   <asp:Label ID="Label12" runat="server" CssClass="text-center" Text="$50:00"></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button6" CssClass="btn btn-success" runat="server" Text="Comprar" />
               </div>
           </div>
       </div>


       <div class="col-md-3 col-sm-4 card">
           <div class="">
               <asp:Image ID="Image7" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
           </div>
           <div class="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label13" runat="server" CssClass="text-center text-info" Text="Hola"></asp:Label>
                   <br />
                   <asp:Label ID="Label14" runat="server" CssClass="text-center" Text="$50:00"></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button7" CssClass="btn btn-success" runat="server" Text="Comprar" />
               </div>
           </div>
       </div>


       <div class="col-md-3 col-sm-4 card">
           <div class="">
               <asp:Image ID="Image8" CssClass="card-img-bottom" runat="server" Height="200px" ImageUrl="~/imgs/Logo.jpg" />
           </div>
           <div class="row">
               <div class="container col-sm-5">
                   <asp:Label ID="Label15" runat="server" CssClass="text-center text-info" Text="Hola"></asp:Label>
                   <br />
                   <asp:Label ID="Label16" runat="server" CssClass="text-center" Text="$50:00"></asp:Label>
               </div>
               <div class="container col-sm-5">
                   <asp:Button ID="Button8" CssClass="btn btn-success" runat="server" Text="Comprar" />
               </div>
           </div>
       </div>






	</div>
    <nav aria-label="...">
        <ul class="pagination">
            <li class="page-item disabled">
           <!--     <a class="page-link" href="#" tabindex="-1">Previous</a>-->
                <asp:button CssClass="page-link" runat="server" tabindex="-1" text="Previus" />
            </li>
            <li class="page-item active">
            <!--    <a class="page-link" href="#">1</a>-->
                <asp:button runat="server" CssClass="page-link" text="1" />
            </li>
            <li class="page-item">
               <!-- <a class="page-link" href="#">2 </a>-->
                <asp:button runat="server" cssclass="page-link" text="2" />

            </li>
            <li class="page-item">
           <!--     <a class="page-link" href="#">3</a>-->
                <asp:button runat="server" cssclass="page-link" text="3" />
            </li>
            <li class="page-item">
               <!-- <a class="page-link" href="#">Next</a>-->
                <asp:button runat="server" cssclass="page-link" text="Next" />
            </li>
        </ul>
    </nav>
</asp:Content>

