<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FastOutdoors.UserPanel.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../AdminPanel/Assets/Css/fontawesome-free-6.3.0-web/css/all.min.css" rel="stylesheet" />
    <link href="Assets/Css/LoginAndRegister.css" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300&display=swap" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <img class="img" src="Assets/Img/LoginBackgraoung.png" />
        <div style="padding: 60px;"></div>
        <div class="RegisterContainer">
            <a href="Index.aspx"><i class="fa-solid fa-chevron-left"></i></a>
            <div class="title">
                <h1>Kayıt Oluştur</h1>
            </div>
            <div class="row">
                <asp:Panel ID="pnl_succesful" runat="server" CssClass="pnlSucces" Visible="false">
                    Kayıt İşlemi Başarılı
                </asp:Panel>
                <asp:Panel ID="pnl_eror" runat="server" CssClass="pnlEror" Visible="false">
                    <asp:Label ID="lbl_eror" runat="server"></asp:Label>
                </asp:Panel>
            </div>
            <div class="RegisterContent">
                <div class="row">
                    <h4>İsim</h4>
                    <asp:TextBox ID="tb_name" runat="server" CssClass="texBox"></asp:TextBox>
                </div>
                <div class="row">
                    <h4>Soyisim</h4>
                    <asp:TextBox ID="tb_surName" runat="server" CssClass="texBox"></asp:TextBox>
                </div>
                <div class="row">
                    <h4>Kullanıc Adı</h4>
                    <asp:TextBox ID="tb_userName" runat="server" CssClass="texBox"></asp:TextBox>
                </div>
                <div class="row">
                    <h4>Telefon No</h4>
                    <asp:TextBox ID="tb_phone" runat="server" CssClass="texBox"></asp:TextBox>
                </div>
                <div class="row">
                    <h4>e-Posta</h4>
                    <asp:TextBox ID="tb_mail" runat="server" CssClass="texBox"></asp:TextBox>
                </div>
                <div class="row">
                    <h4>Sifre</h4>
                    <asp:TextBox ID="tb_Password" TextMode="Password" runat="server" CssClass="texBox"></asp:TextBox>
                </div>
                <div class="row">
                    <h4>Yaşadığın Şehir</h4>
                    <asp:TextBox ID="tb_location" runat="server" CssClass="texBox"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:LinkButton ID="lbtn" CssClass="loginBtn" runat="server" OnClick="lbtn_Click">Kayıt ol</asp:LinkButton>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
