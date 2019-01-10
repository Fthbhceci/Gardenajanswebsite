<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Anasayfa.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <head>
    <meta http-equiv="content-type" content="text/html;charset=utf-8"/>
    <title>Anasayfa</title>
    <div id="fb-root"></div>
<script>    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = 'https://connect.facebook.net/tr_TR/sdk.js#xfbml=1&version=v2.11';
        fjs.parentNode.insertBefore(js, fjs);
    } (document, 'script', 'facebook-jssdk'));</script>
    <!-- Insert to your webpage before the </head> -->
    <script src="sliderengine/jquery.js"></script>
    <script src="sliderengine/amazingslider.js"></script>
    <link rel="stylesheet" type="text/css" href="sliderengine/amazingslider-1.css">
    <script src="sliderengine/initslider-1.js"></script>
    <!-- End of head section HTML codes -->
    </head>
    <body>
    <div class="divanasayfabanner"></div>
    <br />
<div class="sliderdiv">
<div class="sliderdiv2">
    <!-- Insert to your webpage where you want to display the slider -->
    <div id="amazingslider-wrapper-1" style="display:block;position:relative;max-width:750px;margin:0px auto 0px;">
        <div id="amazingslider-1" style="display:block;position:relative;margin:0 auto;">
            <ul class="amazingslider-slides" style="display:none;">
                <li><img src="images/EA13.jpg" alt="Oyuncumuz DERİN KARA, Turkcell babalar günü reklamında rol aldı."  title="Oyuncumuz DERİN KARA, Turkcell babalar günü reklamında rol aldı." />
                </li>
                <li><img src="images/portre-cast-headshot-ki%C5%9Fisel-foto%C4%9Fraf-%C3%A7ekimi.jpg" alt="Oyuncumuz MELİS AKMAN, Card Finans reklam filminde rol aldı."  title="Oyuncumuz MELİS AKMAN, Card Finans reklam filminde rol aldı." />
                </li>
                <li><img src="images/depositphotos_10914835-stock-photo-cool-fashion-male-model-sitting.jpg" alt="Oyuncumuz BATUHAN ÇAKIROĞLU, Akbank reklam filminde rol aldı."  title="Oyuncumuz BATUHAN ÇAKIROĞLU, Akbank reklam filminde rol aldı." />
                </li>
                <li><img src="images/man_red_hair_beard_red_beard_redhead_greens_summer_portrait-1177664.jpg" alt="Oyuncumuz TALHA AKDUR, Nutella reklam filminde rol aldı."  title="Oyuncumuz TALHA AKDUR, Nutella reklam filminde rol aldı." />
                </li>
                <li><img src="images/portre-manken-model-oyuncu-cast-headshot-ki%C5%9Fiye-%C3%B6zel-foto%C4%9Fraf-%C3%A7ekimi-59.jpg" alt="Oyuncumuz SELDA SEVİM, Alpella reklamında rol aldı."  title="Oyuncumuz SELDA SEVİM, Alpella reklamında rol aldı." />
                </li>
                <li><img src="images/18.jpg" alt="Oyuncumuz MİNE KAYMAK, Sütaş reklamında rol aldı."  title="Oyuncumuz MİNE KAYMAK, Sütaş reklamında rol aldı." />
                </li>
            </ul>
        </div>
    </div>
    <!-- End of body section HTML codes -->
    

</body>
</div>
        <br />
        <br />
  
<a href="Basvuru.aspx"><div class="linkbasvur"></div></a>
<a href="Garden.aspx"><div class="linkatolye"></div></a>
<a href="Sık.aspx"><div class="linksık">
            <br />
        </div></a>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
   <div class="gardenatolye">
       <p style="font-family: Constantia; font-size: xx-large; color: #FFA500">GARDEN AJANS</p>
       <p style="font-family: 'Baskerville Old Face'; font-size: large; color: #999999;">20 yıllık geçmisinde 
           Garden Ajans bir çok tanınmıs manken ve fotomodel yetistirmistir.Bir çogu Garden Ajans ailesinde bulunmanın prestiji sayesinde bugünkü kariyerlerine ulasmıslardır. Ayrıca Dünya'nın en prestijli Yabancı Ajanslarıyla isbirligi yaparak Türk moda ve tanıtım sektörüne bir çok yabancı model sunulmustur.</p>

        </div>
           </div>
         
        
</asp:Content>