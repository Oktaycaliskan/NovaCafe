<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="NovaCafe.AdminPanel.LoginAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap-5.1.3-dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<style>
    .gradient-custom {
        background: #6a11cb;
        background: -webkit-linear-gradient(to right, rgba(106, 17, 203, 1), rgba(37, 117, 252, 1));
        background: linear-gradient(to right, rgba(106, 17, 203, 1), rgba(37, 117, 252, 1))
    }
</style>
<body>
    <section class="vh-100 gradient-custom">
        <div class="container py-5 h-100">
            <div class="row d-flex justify-content-center align-items-center h-100">
                <div class="col-12 col-md-8 col-lg-6 col-xl-5">
                    <div class="card bg-dark text-white" style="border-radius: 1rem;">
                        <div class="card-body p-5 text-center">

                            <div class="">
                                <img src="assets/img/kadoimg.jpg" class="w-50 mb-2 " style="border-radius:100%" />
                                <h2 class="fw-bold mb-2 text-uppercase">Giriş</h2>
                                <p class="text-white-50 mb-5">Lütfen kullanıcı adınızı ve şifrenizi girin!</p>

                                <div class="form-outline form-white mb-4">
                                    <label class="form-label" for="typeEmailX">Kullanıcı Adı</label>
                                    <input type="Name" id="typeEmailX" class="form-control form-control-lg" />
                                </div>

                                <div  class="form-outline form-white mb-4">
                                    <label class="form-label" for="typePasswordX">Şifre</label>
                                    <input type="password" id="typePasswordX" class="form-control form-control-lg" />
                                </div>


                                <button class="btn btn-outline-light btn-lg px-5" type="submit">Giriş Yap</button>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</body>
</html>
<script src="bootstrap-5.1.3-dist/js/bootstrap.min.js"></script>
