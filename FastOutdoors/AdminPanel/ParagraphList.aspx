<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ParagraphList.aspx.cs" Inherits="FastOutdoors.AdminPanel.ParagraphList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="paragraphsList">
        <div class="paragraphControl">
            <a class="paragraphAddLink" href="ParagraphAdd.aspx">Metin Ekle</a>

        </div>
        <asp:ListView ID="lv_paragrapList" runat="server" class="memberTable" OnItemCommand="lv_paragrapList_ItemCommand">
            <LayoutTemplate>
                <table style="margin-top: 15px;" class="Table" cellpaddind="0" cellspacing="3">
                    <tr>
                        <thead>
                            <th>ID</th>
                            <th>Kategori</th>
                            <th>Ekleyen Admin</th>
                            <th>Başlık</th>
                            <th>Özet</th>
                            <th>Görüntülenme</th>
                            <th>Ekleme Tarihi</th>
                            <th>Resim</th>
                            <th colspan="3">Secenek</th>

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
                    <td><%# Eval("Brief") %></td>
                    <td><%# Eval("ParagraphViews") %></td>
                    <td><%# Eval("ParagraphDateTime") %></td>
                    <td><%# Eval("Img") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_remove" runat="server" CssClass="paragraphBanBtn" CommandArgument='<%# Eval("ID") %>' CommandName="remove">Kaldır</asp:LinkButton>

                        <a class="ParagraphUpdateBtn" href="ParagraphUpdate.aspx?pid=<%# Eval("ID") %>">Güncelle</a>

                        <a class="ParagraphUpdateBtn" href="ParagraphDetail.aspx?pid=<%# Eval("ID") %>">Detay</a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
