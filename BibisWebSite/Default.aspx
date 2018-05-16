<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

.slideshow-container{
width: 800px;
position: relative;
margin: auto;
margin-right: 6%;
}

.numbers{
position: absolute;
top: 0;
color: #f2f2f2;
padding: 8px 12px;
font-size: 12px;
}

.myslides{
display: none;
}
.prev , .next{
position: absolute;
top: 50%;
font-size: 18px;
font-weight: bold;
padding: 16px;
margin-top: -22px;
border-radius: 0 3px 3px 0;
color: #fff;
cursor: pointer;
}

.next{
right: 0;
border-radius: 3px 0 0 3px;
}

.prev:hover,.next:hover{
background-color: rgba(0,0,0,0.8);
}

.caption{
text-align: left;
position: absolute;
bottom: 8px;
width: 100%;
color: #f2f2f2;
font-size: 15px;
padding: 8px 22px;
}

.dots{
width: 20px;
height: 20px;
background: gray;
display: inline-block;
border-radius: 50%;
cursor: pointer;
margin-top: -200px;
}

.fade{
animation-name:fade;
animation-duration:1.5s;
}

@keyframes fade{
from {opacity: 0.4;}
to {opacity: 1;}
}

.active, .dot:hover {
background-color: #333;
}

</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuEspecifico" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="tituloContenido" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="contenidoPrincipal" Runat="Server">
    <div class="slideshow-container">
        <div class="myslides fade">
            <div class="numbers">1 / 4</div>
            <div>
                <img src="../imgs/1.jpg" width="300px" height="450px"></div>
            <div class="caption">LEGEND for men</div>
        </div>
        <div class="myslides fade">
            <div class="numbers">2 / 4</div>
            <div>
                <img src="../imgs/2.jpg" width="300px" height="450px"></div>
            <div class="caption">212 VIP</div>
        </div>
        <div class="myslides fade">
            <div class="numbers">3 / 4</div>
            <div>
                <img src="../imgs/3.jpg" width="300px" height="450px"></div>
            <div class="caption">212 MEN NYC </div>
        </div>
        <div class="myslides fade">
            <div class="numbers">4 / 4</div>
            <div>
                <img src="../imgs/4.jpg" width="300px" height="450px"></div>
            <div class="caption">PERRY </div>
        </div>
        <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
        <a class="next" onclick="plusSlides(1)">&#10095;</a>
    </div>
    <br>
    <div style="text-align: center">
        <span class="dots" onclick="currentSlide(1)"></span>
        <span class="dots" onclick="currentSlide(2)"></span>
        <span class="dots" onclick="currentSlide(3)"></span>
        <span class="dots" onclick="currentSlide(4)"></span>
    </div>
    <script type="text/javascript">
        var slideIndex = 1;
        showSlide(slideIndex);
        function plusSlides(n){
            showSlide(slideIndex += n);
        }

        function currentSlide(n) {
            showSlide(slideIndex = n);
        }

        function showSlide(n){
            var i;
            var slides = document.getElementsByClassName("myslides");
            var dots = document.getElementsByClassName("dots");
            if (n > slides.length) { slideIndex = 1};
            if (n < 1) { slideIndex = slides.length};

            for (i=0;i<slides.length;i++) {
                slides[i].style.display = "none";
            };

            for (i=0;i<dots.length;i++) {
                dots[i].className = dots[i].className.replace(" active","");
            };

            slides[slideIndex-1].style.display = "block";
            dots[slideIndex-1].className += " active";
        }

    </script>
</asp:Content>

