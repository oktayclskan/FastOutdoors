<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CategoryUpdate.aspx.cs" Inherits="FastOutdoors.AdminPanel.CategoryUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="CategoryUpdateContainer">
        <div class="CategoryUpdateTitle">
            <h3>Kategori Güncelle </h3>
        </div>
        <asp:Panel ID="pnl_successful" runat="server" CssClass="pnlSuccessful" Visible="false">
            Kategori Güncelleme Başarılı
        </asp:Panel>

        <asp:Panel ID="pnl_eror" runat="server" CssClass="pnlEror" Visible="false">
            <asp:Label ID="lbl_eror" runat="server"></asp:Label>
        </asp:Panel>
        <a href="CategoryList.aspx"><i class="fa-solid fa-angles-left AddBackBtn"></i></a>
        <div style="margin-top:15px;" class="row">
            <h6>Kategori Adı Giriniz</h6>
            <asp:TextBox ID="tb_name" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Image ID="img_categoryImg" runat="server" Width="150"/>
        </div>
            
         <div class="row">
            <h6>Resim Ekle</h6>
            <asp:FileUpload ID="fu_Image" runat="server" CssClass="fuImgAdd"></asp:FileUpload>
        </div>

        <div class="row">
            <asp:LinkButton ID="lbtn_update" runat="server" CssClass="UpdateBtn" OnClick="lbtn_update_Click"  >Güncelle</asp:LinkButton>
        </div>
    </div>
</asp:Content>
