<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="NovaCafe.AdminPanel.AddProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formContainer">
        <div class="formTitle">
            <h3>Ürün Ekle</h3>
        </div>
        <div class="formContent" style="padding: 20px">
            <asp:Panel ID="pnl_success" runat="server" Visible="false" CssClass="success">
                Ürün Ekleme Başarılı
            </asp:Panel>
            <asp:Panel ID="pnl_unsuccess" runat="server" Visible="false" CssClass="unsuccess">
                <asp:Label ID="lbl_unsuccess" runat="server"></asp:Label>
            </asp:Panel>
            <div style="float: left; width: 50%">
                <div class="textbox">
                    <label>Kategori</label><br />
                    <asp:DropDownList ID="ddl_categories" runat="server" CssClass="textbar" AppendDataBoundItems="true"></asp:DropDownList>
                </div>
                <div class="textbox">
                    <label>İsim</label><br />
                    <asp:TextBox CssClass="textbar" ID="tb_name" runat="server"></asp:TextBox>
                </div>
                <div class="textbox">
                    <label>Resim Ekle</label><br />
                    <asp:FileUpload ID="fu_img" runat="server" />
                </div>
                <div class="textbox">
                    <label>Aktif Mi?</label><br />
                    <asp:CheckBox  ID="cb_isactive" runat="server" Text="Aktif" />
                </div>
                <div class="textbox">
                    <label>Fiyat</label><br />
                    <asp:TextBox CssClass="textbar" ID="tb_price" runat="server"></asp:TextBox>
                </div>
            </div>
            <div style="float: right; width: 50%">
                <div class="textbox">
                    <label>Açıklama</label><br />
                    <asp:TextBox ID="tb_content" runat="server" TextMode="MultiLine" CssClass="multiline"></asp:TextBox>
                </div>
            </div>
            <div style="clear: both"></div>
            <asp:LinkButton ID="lbtn_addPromotionalMenu" runat="server" Text="Ekle" CssClass="btn btn-success mt-4" OnClick="lbtn_addPromotionalMenu_Click"></asp:LinkButton>
        </div>
      
    </div>
</asp:Content>
