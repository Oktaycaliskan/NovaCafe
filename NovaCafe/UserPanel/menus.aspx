<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanelMaster.Master" AutoEventWireup="true" CodeBehind="menus.aspx.cs" Inherits="NovaCafe.UserPanel.menus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container">
    <div class="row">
        <h2 class="mt-2 mb-2"><a class="link-dark text-decoration-none" href="Index.aspx"><i class="fa-solid fa-reply"></i> Geri </a></h2>
        <asp:Repeater ID="rptProducts" runat="server">
            <ItemTemplate>
                <div class="col-6 col-sm-5 p-1 m-0">
                    <div class="card text-bg-dark">
                        <img src='../Images/<%# Eval("Photo") %>' class="card-img" alt='<%# Eval("Name") %>' />
                        <div class="card-img-overlay">
                            <h3 class="card-title text-center text-dark fw-bold">
                                <asp:Literal ID="ltrl_KahvaltiName" runat="server" Text='<%# Eval("Name") %>' />
                            </h3>
                            <h5 class="text-center mb-1 text-dark fw-bold">&nbsp;
                                <asp:Literal ID="ltrl_price" runat="server" Text='<%# Eval("Price") %>' />
                                ₺
                            </h5>
                            <a href="menusRead.aspx?pid=<%# Eval("ID") %>&mid=<%= Request.QueryString["mid"] %>" class="btn btn-primary btn-sm">İncele</a>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
</asp:Content>
