﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ParagraphList.aspx.cs" Inherits="FastOutdoors.AdminPanel.ParagraphList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="paragraphsList">
        <asp:ListView ID="lv_paragrapList" runat="server" class="memberTable" OnItemCommand="lv_paragrapList_ItemCommand">
            <LayoutTemplate>
                <table class="Table" cellpaddind="0" cellspacing="3">
                    <tr>
                        <thead>
                            <th>ID</th>
                            <th>Kategori</th>
                            <th>Ekleyen Admin</th>
                            <th>Başlık</th>
                            <th>İçerik</th>
                            <th>Görüntülenme</th>
                            <th>Ekleme Tarihi</th>
                            <th>Resim</th>
                            <th>Secenek</th>

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
                    <td><%# Eval("AdminName") %></td>
                    <td><%# Eval("Title") %></td>
                    <td><%# Eval("Contents") %></td>
                    <td><%# Eval("ParagraphViews") %></td>
                    <td><%# Eval("ParagraphDateTime") %></td>
                    <td><%# Eval("Img") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_remove" runat="server" CssClass="paragraphBanBtn" CommandArgument='<%# Eval("ID") %>' >Kaldır</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
