<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanelMaster.Master" AutoEventWireup="true" CodeBehind="campaignMenus.aspx.cs" Inherits="NovaCafe.UserPanel.campaignMenus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <h3 class="text-center mt-2 mb-2">Menüler</h3>
            <hr />
            <asp:Repeater ID="campaignMenusrpt" runat="server">
                <ItemTemplate>
                    <div class="col-6 col-sm-5 p-1 m-0">
                        <div class="card text-bg-dark">
                            <a href="campaignMenusRead.aspx?pmid=<%# Eval("ID") %>" style="z-index: 10" />
                            <img src="../Images/<%# Eval("Photo") %>" class="card-img w-100" />
                            </a>
                            <div class="<%--card-img-overlay--%>" style="z-index: 11">
                                <h1 class="card-title text-center"><%# Eval("Name") %></h1>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>


        </div>
    </div>
</asp:Content>
