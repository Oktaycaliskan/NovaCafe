<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListPromotionalMenus.aspx.cs" Inherits="NovaCafe.AdminPanel.ListPromotionalMenus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Kampanyalı Menüler</h3>
   <asp:ListView ID="lv_promotionalMenu" runat="server" OnItemCommand="lv_promotionalMenu_ItemCommand">
       <LayoutTemplate>
           <table class="table" cellpadding="0" cellspacing="0">
               <thead>
                   <tr>
                       <td>Resim</td>
                        <td>Numara</td>
                        <td>İsim</td>
                        <td>Fiyat</td>
                        <td>Durum</td>
                        <td>Seçenekler</td>
                   </tr>
               </thead>
               <tbody>
                   <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
               </tbody>
           </table>
       </LayoutTemplate>
       <ItemTemplate>
           <tr>
                <td> <img width="100px" src="../Images/<%# Eval("Photo") %>" /></td>
                <td><%# Eval("ID") %></td>
                <td><%# Eval("Name") %></td>
                <td><%# Eval("Price") %></td>
                <td><%# Eval("IsActiveStr") %></td>
                <td>
                    <a href='EditPromotionalMenus.aspx?pmid=<%# Eval("ID") %>' class="btn btn-primary">Düzenle</a>
                    <asp:LinkButton CssClass="btn btn-danger" ID="lbtn_changeStatus" runat="server" CommandArgument='<%# Eval("ID") %>' CommandName="changeStatus">Durum Değiştir</asp:LinkButton>
                </td>
            </tr>
       </ItemTemplate>

   </asp:ListView>

</asp:Content>
