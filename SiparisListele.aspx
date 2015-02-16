<%@ Page Title="" Language="C#" MasterPageFile="~/View/Bootstrap.Master" AutoEventWireup="true" CodeBehind="SiparisListele.aspx.cs" Inherits="SiparisListeleme.SiparisListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <br /><br /><br /><br />
     <div class="container">
        <table class="table table-striped">
            <tr class="success">
                
                <th>Sipariş No</th>
                <th>Müşteri</th>
                <th>Sipariş</th>
                <th>Adet</th>
                <th>Durum</th>
                <th>İşlemler</th>              
            </tr>
            <asp:Repeater ID="rptSiparis" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Id") %></td>
                        <td><a href="MusteriListele.aspx?Id=<%# Eval("MusteriId") %>"> <%# Eval("FirmaAdi") %></a></td>
                        <td><%# Eval("SiparisText") %></td>
                        <td><%# Eval("AdetText") %></td>
                        <td><%# Eval("SiparisDurumText") %></td>
                        <td><a href="SiparisDuzenle.aspx?Id=<%# Eval("Id") %>"><i class="glyphicon glyphicon-wrench"></i></a>
                        <a href="Delete.aspx?Id=<%# Eval("Id") %>"><i class="glyphicon glyphicon-remove"></i></a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <center><a href="SiparisEkle.aspx" class="btn btn-danger">Sipariş Ekle</a></center>

    </div>
</asp:Content>
