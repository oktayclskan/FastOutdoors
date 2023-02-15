<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminAdd.aspx.cs" Inherits="FastOutdoors.AdminPanel.AdminAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="AdminAddContainer">

        <div class="row">
            <h6>İsim Giriniz</h6>
            <asp:TextBox ID="ID_name" runat="server" CssClass="inputBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>Soyisim Giriniz</h6>
            <asp:TextBox ID="ID_surname" runat="server" CssClass="inputBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>Kullanıcı Adı Giriniz</h6>
            <asp:TextBox ID="ID_username" runat="server" CssClass="inputBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>Telefon NO Giriniz</h6>
            <asp:TextBox ID="ID_phone" runat="server" CssClass="inputBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>E-Posta Giriniz</h6>
            <asp:TextBox ID="ID_mail" runat="server" CssClass="inputBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>Sifre Giriniz</h6>
            <asp:TextBox ID="ID_sifre" runat="server" CssClass="inputBox"></asp:TextBox>
        </div>

    </div>
</asp:Content>
