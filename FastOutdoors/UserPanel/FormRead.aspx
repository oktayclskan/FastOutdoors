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
        <asp:ListView ID="lv_answer" runat="server">
            <LayoutTemplate>
                <table class="AnswerTable" cellpaddind="0" cellspacing="0">
                    <tr>
                        <thead>
                        </thead>
                    </tr>

                    <tbody>
                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    
                    <td><%# Eval("MemberName") %></td>
                    <td><%# Eval("Content") %></td>
                    <td><%# Eval("AnswersTime") %></td>

                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>



</asp:Content>
