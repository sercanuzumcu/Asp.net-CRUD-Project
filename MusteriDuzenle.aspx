<%@ Page Title="" Language="C#" MasterPageFile="~/View/Bootstrap.Master" AutoEventWireup="true" CodeBehind="MusteriDuzenle.aspx.cs" Inherits="SiparisListeleme.MusteriDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container">
    <h3>Müşteri: </h3>
        <asp:TextBox ID="txtMusteri" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:LinkButton ID="lnkSakla" runat="server" onclick="lnkSakla_Click" CssClass="btn btn-success">Güncelle</asp:LinkButton>
    </div>
</asp:Content>
