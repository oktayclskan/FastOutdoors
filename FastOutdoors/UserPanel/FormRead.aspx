<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanel.Master" AutoEventWireup="true" CodeBehind="FormRead.aspx.cs" Inherits="FastOutdoors.UserPanel.FormRead" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="title">
        <asp:Literal ID="ltrl_content" runat="server"></asp:Literal>
        <asp:Literal ID="ltrl_title" runat="server"></asp:Literal>
    </div>
</asp:Content>
