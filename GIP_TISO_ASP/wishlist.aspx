<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="wishlist.aspx.cs" Inherits="GIP_TISO_ASP.wishlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Wishlist<br />
    <br />
    <asp:ListBox ID="lbxCadeau" runat="server" Height="193px" Width="459px"></asp:ListBox>
    <br />
    <br />
    <asp:TextBox ID="txtName" runat="server" Text="Name"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtDescription" runat="server" Text="Description"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtWebsite" runat="server" Text="Website"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtNameList" runat="server" Text="Name List"></asp:TextBox>
    <br />

    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
    <br />
    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="lblCode" runat="server" Text=""></asp:Label>
    <br />

</asp:Content>
