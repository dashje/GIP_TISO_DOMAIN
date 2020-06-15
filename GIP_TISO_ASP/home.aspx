<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="GIP_TISO_ASP.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Login screen</p>
    <asp:TextBox ID="txtnaam" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtpaswoord" runat="server"></asp:TextBox>
    <br />
    <br /> 
    <asp:Button ID="btnLogin" runat="server" Text="Button" OnClick="btnLogin_Click" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Create account"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnCreate" runat="server" Text="Button" OnClick="btnCreate_Click" />
</asp:Content>

