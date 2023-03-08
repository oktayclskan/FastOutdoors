<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CommentsList.aspx.cs" Inherits="FastOutdoors.AdminPanel.CommentsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="commentControlBtn">
        <asp:LinkButton ID="lbtn_approved" runat="server" OnClick="lbtn_approved_Click" CssClass="cmdControlBtn">Onaylanan</asp:LinkButton>
        <asp:LinkButton ID="lbtn_waiting" runat="server" OnClick="lbtn_waiting_Click" CssClass="cmdControlBtn">Bekleyen</asp:LinkButton>
    </div>
    <div class="commentList">
        <asp:ListView ID="lv_commentApproved" runat="server" class="memberTable" OnItemCommand="lv_commentApproved_ItemCommand">
            <LayoutTemplate>
                <table class="Table" cellpaddind="0" cellspacing="3">
                    <tr>
                        <thead>
                            <th>ID</th>
                            <th>Kategori</th>
                            <th>Kullanıcı Adı</th>
                            <th>Başlık</th>
                            <th>Yorum</th>
                            <th>Yorum Tarihi</th>
                            <th>Görüntülenme</th>
                            <th>Durum</th>
                            <th>Resim</th>
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
                    <td><%# Eval("CategoryName") %></td>
                    <td><%# Eval("UserName") %></td>
                    <td><%# Eval("Title") %></td>
                    <td><%# Eval("Content") %></td>
                    <td><%# Eval("CommentDate") %></td>
                    <td><%# Eval("CommentViews") %></td>
                    <td><%# Eval("CommentStatusStr") %></td>
                    <td>
                        <img style="text-align: center;" src="../AdminPanel/Assets/Img/CommentImg/<%# Eval("Img")%>" width="25" />
                    </td>
                    <td>
                        <asp:LinkButton ID="lbtn_categoryDel" runat="server" CssClass="CommentBanBtn" CommandArgument='<%# Eval("ID") %>' CommandName="remove">Kaldır</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <asp:ListView ID="lv_commentWaiting" runat="server" class="memberTable" OnItemCommand="lv_commentWaiting_ItemCommand" Visible="false">
            <LayoutTemplate>
                <table class="Table" cellpaddind="0" cellspacing="3">
                    <tr>
                        <thead>
                            <th>ID</th>
                            <th>Kategori</th>
                            <th>Kullanıcı Adı</th>
                            <th>Başlık</th>
                            <th>Yorum</th>
                            <th>Yorum Tarihi</th>
                            
                            <th>Durum</th>
                            <th>Resim</th>
                            <th colspan="2">Seçenek</th>
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
                    <td><%# Eval("UserName") %></td>
                    <td><%# Eval("Title") %></td>
                    <td><%# Eval("Content") %></td>
                    <td><%# Eval("CommentDate") %></td>
                    
                    <td><%# Eval("CommentStatusStr") %></td>
                    <td>
                        <img style="text-align: center;" src="../AdminPanel/Assets/Img/CommentImg/<%# Eval("Img")%>" width="25" />
                    </td>
                    <td>
                        <asp:LinkButton ID="lbtn_approveBtn" runat="server" CssClass="ApprovedBtn" CommandArgument='<%# Eval("ID") %>' CommandName="approve">Onayla</asp:LinkButton>
                        <td>
                            <asp:LinkButton ID="lbtn_commentDel" runat="server" CssClass="CommentBanBtn" CommandArgument='<%# Eval("ID") %>' CommandName="remove">Kaldır</asp:LinkButton></td>

                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
