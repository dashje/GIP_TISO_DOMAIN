<%@ Page Title="" Language="C#" MasterPageFile="~/global.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="GIP_TISO_ASP2.home" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <p>
        Login screen</p>
    <div style="text-align:center"> <asp:TextBox ID="txtnaam" runat="server"> </asp:TextBox> 
    <br />
    <asp:TextBox ID="txtpaswoord" runat="server"  TextMode="Password"></asp:TextBox>
    <br />
    <br /> 
    <asp:Button  ID="btnLogin" runat="server" Text="Login"  OnClick="btnLogin_Click" height="29px" Width="170px" BackColor="#1A1A1D" BorderColor="forestgreen" ForeColor="white" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Create account"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnCreate" runat="server" Text="Go" OnClick="btnCreate_Click" Height="29px" Width="170px" BackColor="#1A1A1D" BorderColor="forestgreen" ForeColor="white" />
        <br />
        <br />
    </div>
</asp:Content>
