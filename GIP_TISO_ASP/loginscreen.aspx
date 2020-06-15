<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="loginscreen.aspx.cs" Inherits="GIP_TISO_ASP.loginscreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Create a Wishlist<br />
    <br />
    <asp:Button ID="btnCreateWishlist" runat="server" Text="Create" OnClick="btnCreateWishlist_Click" />
    <br />
    Invite code<br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
    <br />
    <asp:Button ID="Button2" runat="server" Text="Check" />
    <br />
</asp:Content>
