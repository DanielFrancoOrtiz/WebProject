<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <style type="text/css">
        .mySlides {
    display:none;
    }
        body {
         background-color:mistyrose;
        }

</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <div class="w3-content w3-section" style="max-width:300px">
  <img class="mySlides" src="../imgs/1.jpg" style="width:100%">
  <img class="mySlides" src="../imgs/2.jpg" style="width:100%">
  <img class="mySlides" src="../imgs/3.jpg" style="width:100%">
<img class="mySlides" src="../imgs/4.jpg" style="width:100%">
  <img class="mySlides" src="../imgs/5.jpg" style="width:100%">
</div>
    <script type="text/javascript">
      var myIndex = 0;
carousel();

function carousel() {
    var i;
    var x = document.getElementsByClassName("mySlides");
    for (i = 0; i < x.length; i++) {
       x[i].style.display = "none";  
    }
    myIndex++;
    if (myIndex > x.length) {myIndex = 1}    
    x[myIndex-1].style.display = "block";  
    setTimeout(carousel, 2000); // Change image every 2 seconds
}
    </script>
</asp:Content>

