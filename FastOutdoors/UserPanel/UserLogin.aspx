<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="FastOutdoors.UserPanel.UserLogin" %>

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
        <div style="padding: 66px;"></div>
        
        <div class="loginContainer">
            <a href="BlogPages.aspx"><i class="fa-solid fa-chevron-left"></i></a>
            <div class="title">
                <h1>Giriş Yapın</h1>
            </div>
            <div class="LoginContent">
                <div class="row">
                <asp:Panel ID="pnl_eror" runat="server" CssClass="pnl_eror" Visible="false">
                    <asp:Label ID="lbl_eror" runat="server"></asp:Label>
                </asp:Panel>
            </div>
                <div class="row">
                    <h3>Mail</h3>
                    <asp:TextBox ID="tb_mail" runat="server"  CssClass="texBox"></asp:TextBox>
                </div>
                <div class="row">
                    <h3>Sifre</h3>
                    <asp:TextBox ID="tb_Password" TextMode="Password"  runat="server" CssClass="texBox"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:LinkButton ID="lbtn_logIn" CssClass="loginBtn" runat="server" OnClick="lbtn_logIn_Click">Giriş Yap</asp:LinkButton>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
