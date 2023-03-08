<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanel.Master" AutoEventWireup="true" CodeBehind="FormPage.aspx.cs" Inherits="FastOutdoors.UserPanel.FormPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnl_noEntry" runat="server">
        <div class="FormPageNoEntry">
            <div class="Container">
                <a href="UserLogin.aspx">
                    <h1>Form sayfamızı görüntüleyebilmek için giriş yapmanız gerekmektedir</h1>
                </a>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="pnl_LoggedIn" runat="server" Visible="false">
        <div class="formPage">
            <div class="Header">
                <div>
                    <span><i class="fa-solid fa-icons"></i>Forum'da neler oluyor??</span>
                    <div style="float: right">
                        <h4>Sende Deneyimlerini Paylaş</h4>
                        <a href="CommentAdd.aspx" class="commentAddBtn">Yorum Yap</a>
                    </div>
                </div>


            </div>
            <asp:Repeater ID="rp_Comments" runat="server">
                <ItemTemplate>
                    <div>
                        <div class="row">
                            <div class="Category">
                                <span><i class="fa-solid fa-comment-dots"></i><%# Eval("CategoryName") %></span>
                                <div class="memberName">
                                    <span><%# Eval("UserName") %></span>
                                </div>
                            </div>
                            <div class="title">
                                <h3><%# Eval("Title") %></h3>
                            </div>

                            <div class="views">
                                <i style="color: #c4bbbb" class="fa-solid fa-eye"></i>Görüntüleme : <%# Eval ("CommentViews") %>
                                <div class="dateTime">
                                    <i style="color: #c4bbbb" class="fa-regular fa-clock"></i>Göderi Tarihi: <%# Eval ("CommentDate") %>
                                </div>
                            </div>
                            <div class="ContentLink">
                                <a href="FormRead.aspx?fid=<%# Eval("ID") %>">Yorumu Oku </a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            
        </div>
    </asp:Panel>
</asp:Content>
