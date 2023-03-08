<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ParagraphDetail.aspx.cs" Inherits="FastOutdoors.AdminPanel.ParagraphDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ParagraphDetail">
        <div style="float:right;">
            <a href="ParagraphList.aspx"><i class="fa-solid fa-arrow-left-long"></i></a>
            
        </div>
        <div class="row">
            <div>
                <asp:Image CssClass="imgDetails" ID="img_images" runat="server" />
            </div>
            <div class="title">
                <h2>
                    <asp:Literal ID="ltrl_title" runat="server"></asp:Literal>
                </h2>
            </div>
            <div class="brief">
                <h2>Özet</h2>
                <asp:Literal ID="ltrl_brief" runat="server"></asp:Literal>
            </div>
            <div class="content">
                <h2>İçerik</h2>
                <asp:Literal ID="ltrl_content" runat="server"></asp:Literal>
            </div>
            <div class="views">
                <i class="fa-solid fa-eye"></i>Görüntüleme :
            <asp:Literal ID="ltrl_views" runat="server"></asp:Literal>
            </div>
            <div style="margin-bottom:50px;" class="dateTime">
                <i class="fa-solid fa-video"></i>Yayın Tarihi: 
            <asp:Literal ID="ltrl_dateTime" runat="server"></asp:Literal>
            </div>
        </div>
    </div>
</asp:Content>
