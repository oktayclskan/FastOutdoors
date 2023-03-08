<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ComplaintSuggestionList.aspx.cs" Inherits="FastOutdoors.AdminPanel.ComplaintSuggestionList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="complaintSuggestionList">
        <div class="complaintSuggestionContorlBtn">
            <asp:LinkButton ID="lbtn_read" runat="server" CssClass="readAndToBeReadBtn" OnClick="lbtn_read_Click">Okunmuş</asp:LinkButton>
            <asp:LinkButton ID="lbtn_toBeRead" runat="server" CssClass="readAndToBeReadBtn" OnClick="lbtn_toBeRead_Click">Bekleyen</asp:LinkButton>
        </div>
        <asp:ListView ID="lv_toBeRead" runat="server" class="memberTable" OnItemCommand="lv_toBeRead_ItemCommand" Visible="false">
            <LayoutTemplate>
                <table class="Table" cellpaddind="0" cellspacing="3">
                    <tr>
                        <thead>
                            <th>ID</th>
                            <th>Mesaj</th>
                            <th>Durum
                            </th>
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
                    <td style="max-width: 800px; overflow-wrap: break-word;"><%# Eval("Content") %></td>
                    <td><%# Eval("ComplaintSuggestionStatusStr") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_read" runat="server" CssClass="readBtn" CommandArgument='<%# Eval("ID") %>' CommandName="Read">Okundu Yap</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <asp:ListView ID="lv_read" runat="server" class="memberTable" OnItemCommand="lv_read_ItemCommand" Visible="false">
            <LayoutTemplate>
                <table class="Table" cellpaddind="0" cellspacing="3">
                    <tr>
                        <thead>
                            <th>ID</th>
                            <th>Mesaj</th>
                            <th>Durum</th>
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
                    <td ><%# Eval("Content") %></td>
                    <td><%# Eval("ComplaintSuggestionStatusStr") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_remove" runat="server" CssClass="removeBtn" CommandArgument='<%# Eval("ID") %>' CommandName="remove">Kaldır</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>

</asp:Content>
