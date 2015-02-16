<%@ Page Title="" Language="C#" MasterPageFile="~/View/Bootstrap.Master" AutoEventWireup="true" CodeBehind="MusteriSil.aspx.cs" Inherits="SiparisListeleme.MusteriSil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <h3>Müşteri:</h3>
        <asp:Label ID="lblMusteri" runat="server" Text=""></asp:Label><br />
        <p>Silmek istediğinize emin misiniz?</p>
        <p><asp:LinkButton ID="lnkEvet" runat="server" OnClick="lnkEvet_Click" CssClass="btn btn-danger btn-lg">Evet</asp:LinkButton> 
            <a href="MusteriListele.aspx" class="btn btn-default btn-lg">Hayır</a></p>       
    
    </div>
</asp:Content>
