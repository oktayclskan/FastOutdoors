<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanel.Master" AutoEventWireup="true" CodeBehind="ParagraphRead.aspx.cs" Inherits="FastOutdoors.UserPanel.ParagraphRead" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ParagraphDetail">
        <div>
            <asp:Image CssClass="imgDetails" ID="img_images" runat="server" />
        </div>
        <div class="title">
            <h2>
                <asp:Literal ID="ltrl_title" runat="server"></asp:Literal>
            </h2>
        </div>
        <div class="content">
            <asp:Literal ID="ltrl_content" runat="server"></asp:Literal>
        </div>
        <div class="views">
            <i class="fa-solid fa-eye"></i> Görüntüleme :
            <asp:Literal ID="ltrl_views" runat="server"></asp:Literal>
        </div>
        <div class="dateTime">
            <i class="fa-solid fa-video"></i> Göderi Tarihi: 
            <asp:Literal ID="ltrl_dateTime" runat="server"></asp:Literal>
        </div>
    </div>
</asp:Content>
