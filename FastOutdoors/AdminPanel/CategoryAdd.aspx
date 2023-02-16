<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CategoryAdd.aspx.cs" Inherits="FastOutdoors.AdminPanel.CategoryAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="categoryAddContainer">


        <asp:Panel ID="pnl_successful" runat="server" CssClass="pnlSuccessful" Visible="false">
            Admin Ekleme Başarılı
        </asp:Panel>

        <asp:Panel ID="pnl_eror" runat="server" CssClass="pnlEror" Visible="false">
            <asp:Label ID="lbl_eror" runat="server"></asp:Label>
        </asp:Panel>

        <div class="row">
            <h6 style="margin-top: 15px;">İsim Giriniz</h6>
            <asp:TextBox ID="tb_name" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>Resim Ekle</h6>
        </div>

    </div>
</asp:Content>
