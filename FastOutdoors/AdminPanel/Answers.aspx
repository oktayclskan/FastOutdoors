<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Answers.aspx.cs" Inherits="FastOutdoors.AdminPanel.Answers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="answersList">
        <asp:ListView ID="lv_answerList" runat="server" class="memberTable" OnItemCommand="lv_answerList_ItemCommand">
            <LayoutTemplate>
                <table class="Table" cellpaddind="0" cellspacing="3">
                    <tr>
                        <thead>
                            <th>ID</th>
                            <th>Yorum ID</th>
                            <th>Yorum Sahibi</th>
                            <th>İçerik</th>
                            <th>Cevap verilen saat</th>
                            <th>Seçenek</th>
                        </thead>
                    </tr>

                    <tbody>
                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("Comment_ID") %></td>
                    <td><%# Eval("UserName") %></td>
                    <td><%# Eval("Content") %></td>
                    <td><%# Eval("AnswersTime") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_remove" runat="server" CssClass="CommentBanBtn" CommandArgument='<%# Eval("ID") %>' CommandName="remove" >Kaldır</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
