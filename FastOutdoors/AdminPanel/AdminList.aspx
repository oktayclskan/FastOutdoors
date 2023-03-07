<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminList.aspx.cs" Inherits="FastOutdoors.AdminPanel.AdminList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="AdminList">
        <div class="adminControlBtns">
            <asp:LinkButton ID="lbtn_activeAdmBtn" runat="server" CssClass="activeAdmBtn" OnClick="lbtn_activeAdmBtn_Click">Aktif Adminler</asp:LinkButton>
            <asp:LinkButton ID="lbtn_passiveAdmnBtn" runat="server" CssClass="passiveAdmBtn" OnClick="lbtn_passiveAdmnBtn_Click">Pasif Adminler</asp:LinkButton>
            <a href="AdminAdd.aspx" class="activeAdmBtn">Admin Ekle</a>
        </div>
        <asp:ListView ID="lv_adminListActive" runat="server" OnItemCommand="lv_adminListActive_ItemCommand" Visible="true">
            <LayoutTemplate>
                <table class="Table" cellpaddind="0" cellspacing="3">
                    <tr>
                        <thead>
                            <th>ID</th>
                            <th>Isim</th>
                            <th>Soyisim</th>
                            <th>Kullanıcı Adı</th>
                            <th>Telefon</th>
                            <th>E-Posta</th>
                            <th>Durum</th>
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
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("SurName") %></td>
                    <td><%# Eval("UserName") %></td>
                    <td><%# Eval("Phone") %></td>
                    <td><%# Eval("Mail") %></td>
                    <td><%# Eval("AdminStatusStr") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_Passive" runat="server" CommandArgument='<%#Eval("ID")%>' CommandName="deactivate" CssClass="deactivateBtn">Pasife Al</asp:LinkButton>
                    </td>

                </tr>
            </ItemTemplate>
        </asp:ListView>
        <asp:ListView ID="lv_AdminListsPassive" runat="server" Visible="true" OnItemCommand="lv_AdminListsPassive_ItemCommand">
            <LayoutTemplate>
                <table class="Table" cellpaddind="0" cellspacing="3">
                    <tr>
                        <thead>
                            <th>ID</th>
                            <th>Isim</th>
                            <th>Soyisim</th>
                            <th>Kullanıcı Adı</th>
                            <th>Telefon</th>
                            <th>E-Posta</th>
                            <th>Durum</th>
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
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("SurName") %></td>
                    <td><%# Eval("UserName") %></td>
                    <td><%# Eval("Phone") %></td>
                    <td><%# Eval("Mail") %></td>
                    <td><%# Eval("AdminStatusStr") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_Active" runat="server" CommandArgument='<%#Eval("ID")%>' CommandName="activate" CssClass="activateBtn" >Aktif Et</asp:LinkButton>
                        <asp:LinkButton ID="lbtn_remove" runat="server" CssClass="adminRemoveBtn" CommandArgument='<%#Eval("ID")%>' CommandName="remove" >Sil</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
