<%@ Page Title="" Language="C#" MasterPageFile="~/UserPanel/UserPanel.Master" AutoEventWireup="true" CodeBehind="ComplaintSuggestionPages.aspx.cs" Inherits="FastOutdoors.UserPanel.ComplaintSuggestionPages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ComplaintSuggestionPage">
        <div class="Container">
            <asp:Panel ID="pnl_succes" CssClass="pnlSucces" runat="server" Visible="false">
                Şikayetiniz Alınmıştır Teşşekürler
            </asp:Panel>
            <asp:Panel ID="pnl_eror" runat="server" CssClass="pnlEror" Visible="false">
                <asp:Label ID="lbl_msj" runat="server"></asp:Label>
            </asp:Panel>
            <div class="row">
                <asp:TextBox ID="tb_content" TextMode="MultiLine" CssClass="textbox" runat="server" Text="Lütfen Şikayet/Öneri yazınız"></asp:TextBox>
            </div>
            <asp:LinkButton ID="lbtn_send" runat="server" CssClass="sendBtn" OnClick="lbtn_send_Click">Gönder</asp:LinkButton>
        </div>

    </div>
</asp:Content>
