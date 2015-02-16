<%@ Page Title="" Language="C#" MasterPageFile="~/View/Bootstrap.Master" AutoEventWireup="true" CodeBehind="MusteriEkle.aspx.cs" Inherits="SiparisListeleme.MusteriEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br />
<div class="container">

    <h3>Müşteri</h3>
       AD:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;     <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox><br />
        SOYAD:&nbsp; <asp:TextBox ID="txtSurName" runat="server" CssClass="form-control"></asp:TextBox><br />
        FİRMA:&nbsp;&nbsp; <asp:TextBox ID="txtFirm" runat="server" CssClass="form-control"></asp:TextBox><br />
        TEL:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtTelNo" runat="server" CssClass="form-control"></asp:TextBox><br />
        E-MAIL: <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:LinkButton ID="lnkEkle" runat="server"  OnClick="lnkEkle_Click" CssClass="btn btn-success" >Ekle</asp:LinkButton>
    </div>
 

</asp:Content>
