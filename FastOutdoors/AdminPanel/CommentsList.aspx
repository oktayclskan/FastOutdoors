<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CommentsList.aspx.cs" Inherits="FastOutdoors.AdminPanel.CommentsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="commentList">
        <asp:ListView ID="lv_commentList" runat="server" class="memberTable" OnItemCommand="lv_commentList_ItemCommand">
            <LayoutTemplate>
                <table class="Table" cellpaddind="0" cellspacing="3">
                    <tr>
                        <thead>
                            <th>ID</th>
                            <th>Isim</th>
                            <th>Resim</th>
                            <th>Resim</th>
                            <th>Resim</th>
                            <th>Resim</th>
                            <th>Resim</th>
                            <th>Resim</th>
                            <th>Resim</th>
                            <th>Resim</th>
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
                    <td><%# Eval("CategoryName") %></td>
                    <td><%# Eval("MemberName") %></td>
                    <td><%# Eval("Title") %></td>
                    <td><%# Eval("Content") %></td>
                    <td><%# Eval("CommentDate") %></td>
                    <td><%# Eval("CommentViews") %></td>
                    <td><%# Eval("CommentStatus") %></td>
                    <td>
                        <img style="text-align: center;" src="../AdminPanel/Assets/Img/CommentImg/<%# Eval("Img")%>" width="25" />
                    </td>
                    <td>
                        <asp:LinkButton ID="lbtn_categoryDel" runat="server" CommandArgument='<%# Eval("ID") %>'>Yorum Kaldır</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
