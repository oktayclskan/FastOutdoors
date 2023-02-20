<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CategoryAdd.aspx.cs" Inherits="FastOutdoors.AdminPanel.CategoryAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="categoryAddContainer">
        <div class="categoryAddContainerTitle">
            <h3>Kategori Ekle</h3>
        </div>
        <asp:Panel ID="pnl_successful" runat="server" CssClass="pnlSuccessful" Visible="false">
            Kategori Ekleme Başarılı
        </asp:Panel>
        <asp:Panel ID="pnl_eror" runat="server" CssClass="pnlEror" Visible="false">
            <asp:Label ID="lbl_eror" runat="server"></asp:Label>
        </asp:Panel>
        <a href="CategoryList.aspx"><i class="fa-solid fa-angles-left AddBackBtn"></i> </a>
        <div class="row">
            <h6 style="margin-top: 15px;">İsim Giriniz</h6>
            <asp:TextBox ID="tb_name" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>Resim Ekle</h6>
            <asp:FileUpload ID="fu_Image" runat="server" CssClass="fuImgAdd"></asp:FileUpload>
        </div>
        <div class="row">
            <asp:LinkButton ID="lbtn_categoryAdd" runat="server" Text="Ekle" CssClass="addCategoryBtn" OnClick="lbtn_categoryAdd_Click"></asp:LinkButton>
        </div>

    </div>
</asp:Content>
