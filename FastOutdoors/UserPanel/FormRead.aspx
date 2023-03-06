<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanel.Master" AutoEventWireup="true" CodeBehind="FormRead.aspx.cs" Inherits="FastOutdoors.UserPanel.FormRead" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="FormRead">
        <div class="question">
            <i class="fa-solid fa-clipboard-question"></i><span><b>Forum</b></span>
            <div class="title">
                <asp:Literal ID="ltrl_title" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="row">
            <div class="dateTime">
                <asp:Literal ID="ltrl_dateTime" runat="server"></asp:Literal>
            </div>
            <div class="content">
                <asp:Literal ID="ltrl_content" runat="server"></asp:Literal>
            </div>
        </div>
    </div>
    <div class="answerContainer">
        <div class="answertitle">
            <h4>Verilen Cevaplar</h4>
        </div>
    </div>
    <asp:Repeater ID="rp_aswers" runat="server">
        <ItemTemplate>
            <div class="container">
                Üye  =
                    <label class="Yorumuye"><%# Eval("MemberName") %> </label>
                <br />
                <%# Eval("Content") %>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <div class="deneme">
        <asp:Literal ID="ltrl_AmemberName" runat="server"></asp:Literal>
        <asp:Literal ID="ltrl_AContent" runat="server"></asp:Literal>
    </div>

    <div>
    </div>
</asp:Content>
