<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanel.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FastOutdoors.UserPanel.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Repeater ID="rp_paragraphs" runat="server">
        <ItemTemplate>
            <div class="BlogPagesContainer">
                <div class="row">
                    <div class="images">
                        <a href='../AdminPanel/Assets/Img/ParagraphsImages/<%# Eval("Img") %>' target="_blank">
                            <img src='../AdminPanel/Assets/Img/ParagraphsImages/<%# Eval("Img") %>' /></a>
                        <h2><%# Eval("CategoryName") %><br />
                            <a class="contentLink" href="ParagraphRead.aspx?pid=<%# Eval("ID") %>">İçeriği Oku</a>
                        </h2>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
