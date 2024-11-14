<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanelMaster.Master" AutoEventWireup="true" CodeBehind="menus.aspx.cs" Inherits="NovaCafe.UserPanel.menus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="row">
            <h2 class="mt-2 mb-2"><a class="link-primary  text-decoration-none" href="Index.aspx"><i class="fa-solid fa-reply"></i>Geri </a></h2>
            <div class="col-6 col-sm-5 p-1 m-0">
                <div class="card text-bg-dark">
                    <asp:Literal ID="ltrl_img" runat="server"></asp:Literal>
                    <div class="card-img-overlay">
                        <h1 class="card-title text-center">
                            <asp:Literal ID="ltrl_KahvaltiName" runat="server"></asp:Literal>
                        </h1>
                        <h6 class=" text-center mb-1">&nbsp 
                            <asp:Literal ID="ltrl_price" runat="server"></asp:Literal>
                            ₺</h6>


                        <%-- <asp:Literal ID="ltrl_ID" runat="server"></asp:Literal>--%>
                        <a href="menusRead.aspx?pid=<asp:Literal ID="ltrl_ID" runat="server"></asp:Literal>" class="btn btn-primary btn-sm">İncele</a>

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
