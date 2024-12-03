<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanelMaster.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="NovaCafe.UserPanel.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main id="main">

        <div class="breadcrumbs d-flex align-items-center" style="background-image: url('Assets/img/PROYE%20TAKİP.png');">
            <div class="container position-relative d-flex flex-column align-items-center" data-aos="fade">
                <h1 class="mt-3 mb-3" style="font-family:Bebas Neue, sans-serif;border-bottom:2px solid black">Nova Cafe</h1>
            </div>
        </div>

        <section id="contact" class="contact">
            <div class="container" data-aos="fade-up" data-aos-delay="100">

                <div class="row gy-4" style="font-style:oblique" >
                    <div class="col-lg-5 p-5" style="background-color: whitesmoke;">
                        <div class="info-item  d-flex flex-column justify-content-center align-items-center">
                            <i class="fa-solid fa-house"></i>
                            <h3>Adresimiz</h3>
                            <p>Eskişehir/Yeşiltepe kado mah. kado sokak. 55/44 </p>
                        </div>
                    </div>
                    <div class="col-lg-3 p-5" style="background-color: whitesmoke; margin-left: 3px">
                        <div class="info-item  d-flex flex-column justify-content-center align-items-center">
                            <i class="fa-solid fa-envelopes-bulk"></i>
                            <h3>E-Posta</h3>
                            <a href="mailto:KadoOil@gmail.com" class="text-dark text-decoration-none">KadoOil@gmail.com</a>
                        </div>
                    </div>
                    <div class="col-lg-3 p-5" style="background-color: whitesmoke; margin-left: 3px">
                        <div class="info-item  d-flex flex-column justify-content-center align-items-center">
                            <i class="fa-solid fa-phone"></i>
                            <h3>İletişim</h3>
                            <p><a href="https://wa.me/+905412581486" class="text-dark text-decoration-none">0541 258 1486</a>  /  <a href="https://wa.me/+905415650927" class="text-dark text-decoration-none">0541 565 0927</a></p>
                        </div>
                    </div>


                </div>






                <div class="row gy-4 mt-1">

                   
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1288.8786978565133!2d30.49506728387985!3d39.79605680417455!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cc15156a9f6f93%3A0x4f1dd179fcee3092!2sNova%20Cafe%26Bistro!5e0!3m2!1str!2str!4v1732018109824!5m2!1str!2str" class="w-100" height="450" style="border: 0;" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>


                </div>

            </div>
        </section>

    </main>
</asp:Content>
