<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarStaff.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LABPSD_RAAMEN.View.Staff.Home" %>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <h1>HELLO</h1>
    <p>Your Current Role is Staff</p>
    <asp:GridView ID="userGridView" runat="server"></asp:GridView>
</asp:Content>
