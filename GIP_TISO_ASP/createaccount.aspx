<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="createaccount.aspx.cs" Inherits="GIP_TISO_ASP.createaccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Create account"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="txtName" runat="server" Text="Name"></asp:TextBox>

    <br />
    <asp:TextBox ID="txtPaswoord" runat="server" Text="Password"></asp:TextBox>

    <br />
    <asp:TextBox ID="txtAge" runat="server" Text="Age"></asp:TextBox>

    <br />
    <asp:TextBox ID="txtMail" runat="server" Text="Email"></asp:TextBox>

    <br />
    <asp:RadioButtonList ID="rbnlGeslacht" runat="server">
        <asp:ListItem Value="M">Male</asp:ListItem>
        <asp:ListItem Value="V">Female</asp:ListItem>
        <asp:ListItem Value="NS">/</asp:ListItem>
    </asp:RadioButtonList>

    <br />
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="btnReturn" runat="server" Text="Return" OnClick="btnReturn_Click" />

</asp:Content>
