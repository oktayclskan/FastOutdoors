<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ParagraphUpdate.aspx.cs" Inherits="FastOutdoors.AdminPanel.ParagraphUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="ParagraphUpdateContainer">
        <div class="ParagraphUpdateContainerTitle">
            <h3>Metin Güncelle</h3>
        </div>
        <asp:Panel ID="pnl_successful" runat="server" CssClass="pnlSuccessful" Visible="false">
            Metin Güncelleme Başarılı
        </asp:Panel>

        <asp:Panel ID="pnl_eror" runat="server" CssClass="pnlEror" Visible="false">
            <asp:Label ID="lbl_eror" runat="server"></asp:Label>
        </asp:Panel>
        <a href="ParagraphList.aspx"><i class="fa-solid fa-angles-left AddBackBtn"></i></a>

        <div class="row">
            <h6 style="margin-top: 15px;">Kategori Seçiniz</h6>
            <asp:DropDownList ID="dll_category" runat="server" CssClass="dllCategory" AppendDataBoundItems="true" >
                <asp:ListItem Text="Seçiniz" Value="0"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="row">
            <h6>Başlık Giriniz</h6>
            <asp:TextBox ID="tb_title" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
        <div style="width:415px;" class="row">
            <asp:Image ID="img_paragraphimg" runat="server" Width="150"/>
            <br />
            <h6>Metin Yazınız</h6>
            <asp:TextBox  ID="tb_content" runat="server" TextMode="MultiLine" ></asp:TextBox>
        </div>
         <div class="row">
            <h6>Özet Yazınız</h6>
            <asp:TextBox ID="tb_brief" runat="server" CssClass="textBox"></asp:TextBox>
        </div>
         <div class="row">
            <h6>Resim Ekle</h6>
            <asp:FileUpload ID="fu_Image" runat="server" CssClass="fuImgAdd"></asp:FileUpload>
        </div>

        <div class="row">
            <asp:LinkButton ID="lb_update" runat="server" CssClass="UpdateBtn" OnClick="lb_update_Click" >Güncelle</asp:LinkButton>
        </div>
    </div>
</asp:Content>
