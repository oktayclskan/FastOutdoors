<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="MemberList.aspx.cs" Inherits="FastOutdoors.AdminPanel.MemberList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="memberList">
        <asp:ListView ID="lv_memberList" runat="server" class="memberTable" OnItemCommand="lv_memberList_ItemCommand">
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
                            <th>Konum</th>
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
                    <td><%# Eval("Location") %></td>
                    <td><%# Eval("MemberStatusStr") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_ban" runat="server" CssClass="banBTN" CommandArgument='<%#Eval("ID")%>' CommandName="ban">Banla</asp:LinkButton>
                        <asp:LinkButton ID="lbtn_unban" runat="server" CssClass="unbanBTN" CommandArgument='<%#Eval("ID")%>' CommandName="unban">Ban Kaldır</asp:LinkButton>
                        <asp:LinkButton ID="lbtn_Dlt" runat="server" CssClass="dltBTN" CommandArgument='<%#Eval("ID")%>' CommandName="remove">Sil</asp:LinkButton>
                       
                    </td>

                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
