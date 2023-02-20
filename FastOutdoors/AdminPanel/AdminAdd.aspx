<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminAdd.aspx.cs" Inherits="FastOutdoors.AdminPanel.AdminAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="AdminAddContainer">
        <div class="AdminAddContainerTitle">
            <h3>Admin Ekle</h3>
        </div>
        <asp:Panel ID="pnl_successful" runat="server" CssClass="pnlSuccessful" Visible="false">
            Admin Ekleme Başarılı
        </asp:Panel>

        <asp:Panel ID="pnl_eror" runat="server" CssClass="pnlEror" Visible="false">
            <asp:Label ID="lbl_eror" runat="server"></asp:Label>
        </asp:Panel>
        <a href="AdminList.aspx"><i class="fa-solid fa-angles-left AddBackBtn"></i> </a>
        
        <div class="row">
            <h6 style="margin-top:15px;">İsim Giriniz</h6>
            <asp:TextBox ID="tb_name" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>Soyisim Giriniz</h6>
            <asp:TextBox ID="tb_surname" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>Kullanıcı Adı Giriniz</h6>
            <asp:TextBox ID="tb_username" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>Telefon NO Giriniz</h6>
            <asp:TextBox ID="tb_phone" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>E-Posta Giriniz</h6>
            <asp:TextBox ID="tb_mail" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>Sifre Giriniz</h6>
            <asp:TextBox ID="tb_AdminPassword" runat="server" TextMode="Password" CssClass="textBox"></asp:TextBox>
        </div>
        <div class="row">
            <asp:LinkButton ID="lb_Add" runat="server" CssClass="AddBtn" OnClick="lb_Add_Click">Ekle</asp:LinkButton>
        </div>
    </div>

</asp:Content>
