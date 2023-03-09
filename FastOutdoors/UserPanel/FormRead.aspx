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
            <div style="float: left;" class="img">
                <asp:Image  CssClass="imgDetails" ID="img_images" runat="server" />
            </div>
            <div style="float: left;" class="content">
                <asp:Literal ID="ltrl_content" runat="server"></asp:Literal>
            </div>
        </div>
    </div>
    <div class="AnswerAdd">
        <div class="row">
            <asp:Panel ID="pnlEror" runat="server" Visible="false">
                <asp:Label ID="lbl_erorMsg" runat="server" ></asp:Label>
            </asp:Panel>
        </div>
        <div class="row">
            <asp:TextBox ID="tb_answerAdd" runat="server" Text="Yorum ekleyin.." CssClass="textbox"></asp:TextBox>
        </div>
        <div style="float:right;">
            <asp:LinkButton ID="lbtn_AddAnswer" CssClass="addAnswerBtn" runat="server" OnClick="lbtn_AddAnswer_Click" >Yorum yap</asp:LinkButton>
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
                    <td><%# Eval("UserName") %></td>
                    <td><%# Eval("Content") %></td>
                    <td><i class="fa-regular fa-clock"></i><%# Eval("AnswersTime") %></td>

                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>



</asp:Content>
