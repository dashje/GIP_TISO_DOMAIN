<%@ Page Title="" Language="C#" MasterPageFile="~/global.Master" AutoEventWireup="true" CodeBehind="guestlist.aspx.cs" Inherits="GIP_TISO_ASP2.guestlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center"><asp:Label ID="lblInformatie" runat="server" Font-Size="XX-Large"></asp:Label>
    <br />
    <asp:ListBox ID="lbxWishlist" runat="server" Height="140px" Width="466px"></asp:ListBox>

    </div>
    <br />
    <br />
    <div style="text-align:center"><asp:Button ID="Button1" runat="server" Text="return" OnClick="Button1_Click" />
</asp:Content>

