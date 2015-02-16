<%@ Page Title="" Language="C#" MasterPageFile="~/View/Bootstrap.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SiparisListeleme.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
        <link href="bootstrap.css" rel='stylesheet' type='text/css' />
        <link rel="stylesheet" href="css/font-awesome.min.css" />
        <script src="jquery.min.js"></script>
        <script type="text/javascript">
            jQuery(document).ready(function ($) {
                $(".scroll").click(function (event) {
                    event.preventDefault();
                    $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 1200);
                });
            });
        </script>
        <link href="style.css" rel='stylesheet' type='text/css' />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
        <link href='http://fonts.googleapis.com/css?family=Source+Sans+Pro:200,300,400,600,700,900' rel='stylesheet' type='text/css' />
       
 

    <div class="header">
  <div class="container">
    <div class="logo" style="text-align:center"> <a href="index.html"></a> </div><br />
    <div class="clearfix"> </div>
  </div>
</div>
<div class="banner text-center">
  <div class="container">
    <div class="banner-info">
        <br /><br />
      <h1>ERKAN PLASTİK <br />AMBALAJ VE KIRTASİYE ÜRÜNLERİ</h1><br /><br />
      <marquee behavior=alternate><p>SİZ İSTEYİN BİZ GETİRELİM</p></marquee>
        
      </div>
  </div>
</div>
<div class="main">
<div class="content_white">
  <h2>Ambalaj Dünyasına Hoşgeldiniz!</h2>
  <p>Sektöründe 22 yıldır öncülük yapan Erkan Plastik artık Ambalaj Dünyasında...</p>
</div>

<div class="container">

  <div class="testimonial">
    <div class="row testimonial_top">
      <div class="col-md-6">
        <ul class="test_box">
          <li class="test_img"><img src="images/pic1.jpg" class="img-responsive" alt=""/> </li>
          <li class="test_desc">
            <h4><a href="/about.aspx">Hakkımızda</a></h4>
            <p>ERKAN PLASTİK San. Tic. Ltd. Şti. 1993 yıllında Recep ÜZÜMCÜ tarafından kuruldu. 
                Yıllar içinde "Kalitesini daha da artırarak" büyüyen firmamız, ülkemizin EN BÜYÜK VE TEK Etiketleme Plastiği (Kılçık) üreticisi olarak sektörünün öncü kuruluşlarındandır.</p>
          </li>
          <div class="clearfix"> </div>
        </ul>
      </div>
      <div class="col-md-6">
        <ul class="test_box">
          <li class="test_img"><img src="images/pic2.jpg" class="img-responsive" alt=""/> </li>
          <li class="test_desc">
            <h4><a href="/SiparisEkle.aspx">Sipariş Verin</a></h4>
            <p>Artık Erkan Plastik'ten Online Sipariş verin ve istediğiniz ürün 1 günde kapınızda olsun. Ayrıca Kapıda Ödeme İmkanı!</p>
          </li>
          <div class="clearfix"> </div>
        </ul>
      </div>
    </div>
    <div class="row testimonial_bottom">
      <div class="col-md-6">
        <ul class="test_box">
          <li class="test_img"><img src="images/pic3.jpg" class="img-responsive" alt=""/> </li>
          <li class="test_desc">
            <h4><a href="/contacts.aspx">Bize Yazın</a></h4>
            <p>Bir öneriniz veya şikayetiniz mi var? Sizi Dinliyoruz, hemen yazın ve Müşteri Temsilcimiz size geri dönüş yapsın.</p>
          </li>
          <div class="clearfix"> </div>
        </ul>
      </div>
      <div class="col-md-6">
        <ul class="test_box">
          <li class="test_img"><img src="images/pic4.jpg" class="img-responsive" alt=""/> </li>
          <li class="test_desc">
            <h4><a href="/MusteriEkle.aspx">Markamıza Ortak Olun </a></h4>
            <p>Hemen Firma bilgilerinizi ekleyin ve Bayimiz olun. Erkan Plastik cironuzu artırmak için Burada!</p>
          </li>
          <div class="clearfix"> </div>
        </ul>
      </div>
    </div>
  </div>
</div>
<div class="footer">
  <div class="footer_midle">
    <div class='container'>
      <div class="row">
        <div class="col-md-3">
          <ul class="social_left">
            <li class="facebook"><a href="#"><i class="fa fa-facebook-square fa-3x"></i></a></li>
            <li class="fb_text">
              <h4><a href="#">Erkan Plastik Google+</a></h4>
            </li>
            <div class="clearfix"> </div>
          </ul>
        </div>
        <div class="col-md-3">
          <ul class="social_left">
            <li class="facebook"><a href="#"><i class="fa fa-twitter-square fa-3x"></i></a></li>
            <li class="fb_text">
              <h4><a href="#">Erkan Plastik Twitter</a></h4>
            </li>
            <div class="clearfix"> </div>
          </ul>
        </div>
        <div class="col-md-3">
          <ul class="social_left">
            <li class="facebook"><a href="#"><i class="fa fa-google-plus-square fa-3x"></i></a></li>
            <li class="fb_text">
              <h4><a href="http://www.facebook.com/erkanplastik" target="_blank">Erkan Plastik Facebook</a></h4>
            </li>
            <div class="clearfix"> </div>
          </ul>
        </div>
        <div class="col-md-3">
          <ul class="social_left">
            <li class="facebook"><a href="#"><i class="fa fa-linkedin-square fa-3x"></i></a></li>
            <li class="fb_text">
              <h4><a href="#">Erkan Plastik LinkedIn</a></h4>
            </li>
            <div class="clearfix"> </div>
          </ul>
        </div>
      </div>
    </div>
  </div>
  <div class="footer_bottom">
    <div class="copy">
      <p>Copyright &copy; 2015 ErkanPlastik. Design by <a href="http://www.sercanuzumcu.com" rel="nofollow">SercanUzumcu</a></p>
    </div>
  </div>
</div>

   
</asp:Content>
