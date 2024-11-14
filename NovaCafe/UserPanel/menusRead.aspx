<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanelMaster.Master" AutoEventWireup="true" CodeBehind="menusRead.aspx.cs" Inherits="NovaCafe.UserPanel.menusRead" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2 class="mt-2 mb-2"><a class="link-primary  text-decoration-none" href="menus.aspx"><i class="fa-solid fa-reply"></i>Geri </a></h2>
        <div class="div">
            <h3 class="text-center mt-2 mb-2">
                
                  <asp:Literal ID="ltrl_breakfastName" runat="server"></asp:Literal> <asp:Literal ID="ltrl_breakfastPrice" runat="server"> ₺</asp:Literal>
                
                
               <%-- Kahvaltı Tabağı 310.00 ₺</h3>--%>
            <img src="Assets/Img/fastfood.jpg" class="img-thumbnail h-100 w-100" alt="Alternate Text" />
        </div>
        <div class="content">
            <p class="mt-3"><span class="text-danger fw-bold">ÜRÜN İÇERİĞİ</span> : Domates Salatalık Söğüş, Salam, Tavuk Jambon, Dana Jambon, Yeşil ve Siyah Zeytin, Kaşar Peuniri, Beyaz Peynir, Kekikli Peynir, Biberli Peynir, Çörekotlu Peynir, Haşlanmıi Yumurta, Kızarmış Patates, Kızarmış Sosis, Soğan Halkası, Sigara Böreği, Fındık Kreması, Bal, Kaymak, Reçel, Piknik Tahin Pekmez, Piknik Tereyağ, Yeşillik.</p>
        </div>
    </div>
</asp:Content>
