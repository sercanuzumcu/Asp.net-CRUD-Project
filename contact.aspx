<%@ Page Title="" Language="C#" MasterPageFile="~/View/Bootstrap.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="SiparisListeleme.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <p style="text-align:center" ><img src="callcenter.png" width="600"  /> </p> 
    
        <mark></mark><b><p style="padding-left:15px; text-align:center;"> Çağrı Merkezi/Call Center : +90 212 613 82 82</p> </b><br />

    <form>
        <div class="form-group" style="padding-left:15px;">
            <label for="exampleInputEmail1">İsim:</label>
            <input type="text" class="form-control" id="exampleInputName" placeholder="İsim:" />
        </div>
         <div class="form-group" style="padding-left:15px;">
            <label for="exampleInputEmail1">Email:</label>
            <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email:" />
        </div>
        <div class="form-group" style="padding-left:15px;">
            <label for="exampleInputPassword1">Konu:</label>
            <input type="text" class="form-control" id="exampleInputSubject" placeholder="Konu:" />
        </div>
        <div class="form-group" style="padding-left:15px;">
            <label for="name">Mesaj</label>
            <textarea class="form-control" rows="10"></textarea>
        </div>
        
        <button type="submit"class="btn btn-primary btn-lg btn-block">Gönder</button>
    </form><br />
            <mark></mark><b><p style="padding-left:15px; text-align:center;"> ERKAN PLASTİK MAK. KALIP SAN.TİC.LTD.ŞTİ.</p> </b>
                <mark></mark><b><p style="padding-left:15px; text-align:center;"> Terazidere Mah. Karasu Sok. No:3/B</p> </b>
                    <mark></mark><b><p style="padding-left:15px; text-align:center;"> BAYRAMPAŞA/İSTANBUL</p> </b><br />


</asp:Content>
