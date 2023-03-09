<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanel.Master" AutoEventWireup="true" CodeBehind="CommentAdd.aspx.cs" Inherits="FastOutdoors.UserPanel.CommentAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="CommentAddContainer">
        <div class="CommentAddContainerTitle">
            <h3>YORUM PAYLAŞ</h3>
        </div>
        <div class="leftMain">
            <div class="row">
                <h1 style="margin-top: 100px;">Kategori Seçiniz</h1>
                <asp:DropDownList ID="dll_category" runat="server" CssClass="dllCategory" AppendDataBoundItems="true" OnSelectedIndexChanged="dll_category_SelectedIndexChanged">
                    <asp:ListItem Text="Seçiniz" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="row">   
                <h4>Yorumunuzun başlığını giriniz</h4>
                
                <asp:TextBox ID="tb_title" CssClass="inputBox" runat="server"></asp:TextBox>
            </div>
            <div class="row">
                <h1>Resim Ekle</h1>
                <asp:FileUpload ID="fu_Image" runat="server" CssClass="fuImgAdd"></asp:FileUpload>
            </div>
        </div>
        <div class="rightMain">
            <h3>Yorum giriniz</h3>
            <asp:Panel ID="pnl_successful" runat="server" CssClass="pnlSuccessful" Visible="false">
                Yorum Ekleme Başarılı
            </asp:Panel>
            <asp:Panel ID="pnl_eror" runat="server" CssClass="pnlEror" Visible="false">
                <asp:Label ID="lbl_eror" runat="server"></asp:Label>
            </asp:Panel>
            <div class="row">
                <asp:TextBox ID="tb_content" TextMode="MultiLine" CssClass="contentInputBox" runat="server"></asp:TextBox>
            </div>
            <div class="row">
                <asp:LinkButton ID="lbtn_comment" runat="server" CssClass="commentBtn" OnClick="lbtn_comment_Click">Yorum Yap</asp:LinkButton>
            </div>
        </div>

    </div>
</asp:Content>
