<%@ Page Title="" Language="C#" MasterPageFile="~/View/Bootstrap.Master" AutoEventWireup="true" CodeBehind="SiparisDuzenle.aspx.cs" Inherits="SiparisListeleme.SiparisDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 396px;
        }
        .auto-style3 {
            width: 326px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container">
         <table class="table">
    
       <tr>
                <td>Müşteri:</td>
                <td><asp:DropDownList ID="drpMusteriId" runat="server" CssClass="form-control"  AutoPostBack="true"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>Ürün:</td>
                <td><asp:TextBox ID="txtUrun" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Açıklama:</td>
                <td><asp:TextBox ID="txtAciklama" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Adedi:</td>
                <td><asp:TextBox ID="txtAdet" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
             <tr>
                 <td>Durumu:</td>
                 <td>
                     <asp:DropDownList ID="drpSiparisDurumId" runat="server" CssClass="form-control">
                     </asp:DropDownList>
                 </td>
             </tr>
                 
             </table>
        <asp:LinkButton ID="lnkSend" runat="server" onclick="lnkSend_Click" CssClass="btn btn-success" >Gönder</asp:LinkButton>
    </div>
</asp:Content>
