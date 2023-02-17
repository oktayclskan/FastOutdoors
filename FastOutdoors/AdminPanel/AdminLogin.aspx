<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="FastOutdoors.AdminPanel.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fast Outdoors</title>
    <link href="Assets/Css/AdminLogin.css" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Gruppo&display=swap" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Fjalla+One&family=Gruppo&family=PT+Sans+Narrow&display=swap" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <h1>Fast Outdoors</h1>
        </div>
        <div class="headerTitle">
            Admin Panel
            <br />
            Login
        </div>
        <div class="container">
            <div class="SingIn">
                <div class="row">

                    <asp:Panel ID="pnl_eror" runat="server" CssClass="pnlEror" Visible="false">
                        <asp:Label ID="lbl_eror" runat="server"></asp:Label>
                    </asp:Panel>
                </div>
                <div class="row" style="margin-top: 25px;">
                    <h4>Mail</h4>
                    <asp:TextBox ID="tb_mail" runat="server" CssClass="inputBox"></asp:TextBox>
                </div>
                <div class="row">
                    <h4>Sifre</h4>
                    <asp:TextBox ID="tb_password" runat="server" TextMode="Password" CssClass="inputBox"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:LinkButton ID="lbtn_singIn" runat="server" CssClass="singInBtn" OnClick="lbtn_singIn_Click">Oturum Aç</asp:LinkButton>
                </div>
                <div class="row">
                </div>
            </div>
        </div>
    </form>
</body>
</html>
