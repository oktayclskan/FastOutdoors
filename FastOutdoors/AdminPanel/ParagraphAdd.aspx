<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ParagraphAdd.aspx.cs" Inherits="FastOutdoors.AdminPanel.ParagraphAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ParagraphAddContainer">
        <div class="ParagraphAddContainerTitle">
            <h3>Metin Ekle</h3>
        </div>
        <asp:Panel ID="pnl_successful" runat="server" CssClass="pnlSuccessful" Visible="false">
            Metin Ekleme Başarılı
        </asp:Panel>

        <asp:Panel ID="pnl_eror" runat="server" CssClass="pnlEror" Visible="false">
            <asp:Label ID="lbl_eror" runat="server"></asp:Label>
        </asp:Panel>
        <a href="ParagraphList.aspx"><i class="fa-solid fa-angles-left AddBackBtn"></i></a>

        <div class="row">
            <h6 style="margin-top: 15px;">Kategori Seçiniz</h6>
            <asp:DropDownList ID="dll_category" runat="server" CssClass="dllCategory" AppendDataBoundItems="true" OnSelectedIndexChanged="dll_category_SelectedIndexChanged">
                <asp:ListItem Text="Seçiniz" Value="0"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="row">
            <h6>Başlık Giriniz</h6>
            <asp:TextBox ID="tb_title" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
        <div class="row">
            <h6>Özet Giriniz</h6>
            <asp:TextBox ID="tb_brief" runat="server" TextMode="MultiLine" CssClass="textBox"></asp:TextBox>
        </div>
        <div style="width:415px;" class="row">
            <h6>Metin Giriniz</h6>
            <asp:TextBox  ID="tb_content" runat="server" TextMode="MultiLine" ></asp:TextBox>
        </div>
         <div class="row">
            <h6>Resim Ekle</h6>
            <asp:FileUpload ID="fu_Image" runat="server" CssClass="fuImgAdd"></asp:FileUpload>
        </div>

        <div class="row">
            <asp:LinkButton ID="lb_Add" runat="server" CssClass="AddBtn" OnClick="lb_Add_Click1">Ekle</asp:LinkButton>
        </div>
    </div>
</asp:Content>
