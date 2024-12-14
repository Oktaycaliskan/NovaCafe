<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanelMaster.Master" AutoEventWireup="true" CodeBehind="campaignMenusRead.aspx.cs" Inherits="NovaCafe.UserPanel.campaignMenusRead" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 class="card-title text-center">
    <asp:Literal ID="ltrl_ProductName" runat="server" />
</h1>
<h6 class="text-center mb-1">&nbsp;
          <asp:Literal ID="ltrl_price" runat="server" />
    ₺
</h6>
        <h2 class="mt-2 mb-2"><a class="link text-decoration-none text-dark" href="campaignMenus.aspx"><i class="fa-solid fa-reply"></i>Geri </a></h2>
        <asp:Literal ID="ltrl_imgpm" Text="text" runat="server" />
        
        <div class="content">
            <p class="mt-3">
                <span class="text-danger fw-bold">ÜRÜN İÇERİĞİ</span> : 
                                <asp:Literal ID="ltrl_content" runat="server"></asp:Literal>
            </p>
        </div>
    </div>
</asp:Content>
