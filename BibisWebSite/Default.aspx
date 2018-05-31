<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style>
       
        .mySlides {
    display:none;
    
    }
        .w3-content w3-section {
            margin-right:190px;
        }

        body {
     background: url(../imgs/fondologin2.0.jpg);
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
    <div class="w3-content w3-section" style="max-width:300px">
  <img class="mySlides" src="../imgs/grand1.png" style="width:300%">

  <img class="mySlides" src="../imgs/grandV21.jpg" style="width:300%">
<img class="mySlides" src="../imgs/grand4.jpeg" style="width:260%">
  <img class="mySlides" src="../imgs/grand5.jpg" style="width:260%">
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

