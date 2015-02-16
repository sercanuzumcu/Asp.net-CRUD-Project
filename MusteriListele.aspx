<%@ Page Title="" Language="C#" MasterPageFile="~/View/Bootstrap.Master" AutoEventWireup="true" CodeBehind="MusteriListele.aspx.cs" Inherits="SiparisListeleme.MusteriListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /> <br /> <br /> <br />
      <div class="container">
            <table class="table table-striped">
                <tr class="success">
                    <th>Id</th>
                    <th>Adı</th>
                      <th>Soyadı</th>
                     <th>Firma Adı</th>
                     <th>Telefon</th>
                      <th>İşlemler</th>
                     <th>Email</th>
                </tr>

                <asp:Repeater ID="rptBrand" runat="server">
                <ItemTemplate>
                    <tr> 
                        <td><%# Eval("Id") %></td>
                        <td><%# Eval("Name") %></td>
                        <td><%# Eval("SurName") %></td>
                        <td><%# Eval("Firm") %></td>
                        <td><%# Eval("TelNo") %></td>
                       <td><%# Eval("Email") %></td>

                        <td><a href="Edit.aspx?Id=<%# Eval("Id") %>"><i class="glyphicon glyphicon-wrench"></i></a>
                        <a href="Delete.aspx?Id=<%# Eval("Id") %>"><i class="glyphicon glyphicon-remove"></i></a></td>
                    </tr>
                </ItemTemplate>
                </asp:Repeater>                
            </table>
    
        </div>
</asp:Content>
