<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanelMaster.Master" AutoEventWireup="true" CodeBehind="menus.aspx.cs" Inherits="NovaCafe.UserPanel.menus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="row">
            <h2 class="mt-2 mb-2"><a class="link-primary  text-decoration-none" href="Index.aspx"><i class="fa-solid fa-reply"></i> Geri </a></h2>
            <div class="col-6 col-sm-5 p-1 m-0">
                <div class="card text-bg-dark">
                    <img src="Assets/Img/fastfood.jpg" class="card-img" alt="...">
                    <div class="card-img-overlay">
                        <h1 class="card-title text-center">Kahvaltılar</h1>
                        <h6 class=" text-center mb-1">&nbsp 310.00 ₺</h6>
                        <button class="btn btn-primary btn-sm">İncele</button>

                    </div>
                </div>
            </div>
            <div class="col-6 col-sm-5 p-1 m-0">
                <div class="card text-bg-dark">
                    <img src="Assets/Img/fastfood.jpg" class="card-img" alt="...">
                    <div class="card-img-overlay">
                        <h1 class="card-title text-center">Kahvaltılar</h1>
                         <h6 class=" text-center mb-1">&nbsp 310.00 ₺</h6>
                        <button class="btn btn-sm btn-primary">İncele</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
