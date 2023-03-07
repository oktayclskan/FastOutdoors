<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="FastOutdoors.AdminPanel.CategoryList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="categoryList">
        <div class="linkCategoryAdd">
            <a href="CategoryAdd.aspx" class="categoryAddlinkBtn">Kategori Ekle</a>
        </div>
        <asp:ListView ID="lv_categoryList" runat="server" class="memberTable" OnItemCommand="lv_categoryList_ItemCommand">
            <LayoutTemplate>
                <table class="Table" cellpaddind="0" cellspacing="3">
                    <tr>
                        <thead>
                            <th>ID</th>
                            <th>Isim</th>
                            <th>Resim</th>
                            <th>Seçenekler</th>
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
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("Img") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_categoryDel" runat="server" CssClass="categoryProcessBtn" CommandArgument='<%# Eval("ID") %>' CommandName="remove">Kategori Sil</asp:LinkButton>
                        <a class="categoryUpdateBtn" href="CategoryUpdate.aspx?cid=<%# Eval("ID") %>">Düzenle</a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
