<%@ Page Title="" Language="C#" MasterPageFile="~/global.Master" AutoEventWireup="true" CodeBehind="selectionScreen.aspx.cs" Inherits="GIP_TISO_ASP2.selectionScreen" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Dit zijn uw Lijsten</p>
    <div style="text-align:center"><asp:ListBox ID="lbxSelectionLists" runat="server" Height="199px" Width="266px" AutoPostBack="true" OnSelectedIndexChanged="lbxSelectionLists_SelectedIndexChanged"></asp:ListBox>
    </div>
    <div style="text-align:center"><asp:Button ID="btnHome" runat="server" Text="Return" OnClick="btnHome_Click" />
        <br />
        

</asp:Content>
