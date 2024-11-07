<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListCategory.aspx.cs" Inherits="NovaCafe.AdminPanel.ListCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Kategori Listesi</h3>
    <asp:ListView runat="server">
        <LayoutTemplate>
            <table cellpadding="0" cellspacing="0">
                <thead>
                    <tr>
                        <td>Resim</td>
                        <td>Resim</td>
                        <td>Resim</td>
                    </tr>
                </thead>
            </table>
        </LayoutTemplate>
    </asp:ListView>
</asp:Content>
