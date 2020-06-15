<%@ Page Title="" Language="C#" MasterPageFile="~/global.Master" AutoEventWireup="true" CodeBehind="loginscreen.aspx.cs" Inherits="GIP_TISO_ASP2.loginscreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

   <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <br />
       <br /><p>Create a Wishlist</p>

     <div style="text-align:center"> <asp:Button ID="btnCreateWishlist" runat="server" Text="Create" OnClick="btnCreateWishlist_Click" BackColor="#1A1A1D" BorderColor="forestgreen" ForeColor="white" />
    <br />
         <br />
         <br />
         See your own Wishlist<br />
         <br />
         <asp:Button ID="btnSeeWishlist" BackColor="#1A1A1D" BorderColor="forestgreen" ForeColor="white" runat="server" Text="+" OnClick="btnSeeWishlist_Click" />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
    Invite code<br />
    <br />
    <asp:TextBox ID="txtLogin" runat="server" ></asp:TextBox>
         <br />
         <br />
    <asp:Button ID="btnCheck" runat="server" Text="Check" BackColor="#1A1A1D" BorderColor="forestgreen" ForeColor="white" OnClick="Button2_Click" />
    <br /></div>
</asp:Content>
