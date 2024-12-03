<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanelMaster.Master" AutoEventWireup="true" CodeBehind="menusRead.aspx.cs" Inherits="NovaCafe.UserPanel.menusRead" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2 class="mt-2 mb-2">
            <a class="link-dark text-decoration-none" href="menus.aspx?mid=<%= Request.QueryString["mid"] %>">
                <i class="fa-solid fa-reply"></i>Geri
    </a>
        </h2>
        <%-- <h2 class="mt-2 mb-2"><a class="link-dark  text-decoration-none" href="Index.aspx"><i class="fa-solid fa-reply"></i>Geri </a></h2>--%>
        <div class="content">
            <h3 class="text-center mt-2 mb-2" />
            <asp:Literal ID="ltrl_breakfastName" runat="server"></asp:Literal>
            <asp:Literal ID="ltrl_breakfastPrice" runat="server"> </asp:Literal>
            ₺
        </div>
        <div class="images">
            <div>
                <asp:Literal ID="ltrl_img" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="content">
            <p class="mt-3">
                <span class="text-danger fw-bold">ÜRÜN İÇERİĞİ</span> : 
             
                <asp:Literal ID="ltrl_content" runat="server"></asp:Literal>
            </p>
        </div>
    </div>
</asp:Content>
