<%@ Page Title="" Language="C#" MasterPageFile="~/global.Master" AutoEventWireup="true" CodeBehind="ownList.aspx.cs" Inherits="GIP_TISO_ASP2.ownList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="text-align:center">
        <asp:TextBox ID="txtNameList" text="Name of this list" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="BtnCreateList" runat="server" Text="Create" BackColor="#1A1A1D" ForeColor="white" BorderColor="ForestGreen" OnClick="BtnCreateList_Click" />
        <br />

        <asp:ListBox ID="lbxAllCadeaus" runat="server" Height="193px" Width="380px"></asp:ListBox>
        <asp:Button ID="BtnFromMyList" runat="server" Text="<" OnClick="BtnFromMyList_Click" />
        <asp:Button ID="BtnToMyList" runat="server" Text=">" OnClick="BtnToMyList_Click" />
        <asp:ListBox ID="LbxCurrentList" runat="server" Height="193px" Width="380px"></asp:ListBox>
    <br />
    <asp:TextBox ID="txtName" runat="server" Text="Name"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtDescription" runat="server" Text="Description"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtWebsite" runat="server" Text="Website"></asp:TextBox>
    <br />
    <br />

    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" BackColor="#1A1A1D" BorderColor="forestgreen" ForeColor="white" Visible="false"/>
    <br />
    <br />
    <br />
        <asp:Button ID="btnReturn" runat="server" Text="Return" BackColor="#1A1A1D" BorderColor="forestgreen" ForeColor="white" OnClick="btnReturn_Click" />
    <br />

        <asp:Label ID="lblCode" runat="server" Text=""></asp:Label>
    <br />
        <br />

    <br />
        </div>

</asp:Content>

