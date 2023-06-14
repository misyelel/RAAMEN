<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarAdmin.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LABPSD_RAAMEN.View.Admin.Home" %>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <h1>Masuk MInt</h1>
    <asp:GridView ID="staffGridView" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Staff ID" SortExpression="Id" />
            <asp:BoundField DataField="username" HeaderText="Staff Name" SortExpression="username" />
            <asp:BoundField DataField="email" HeaderText="Staff Email" SortExpression="email" />
            <asp:BoundField DataField="gender" HeaderText="Staff Gender" SortExpression="gender" />
        </Columns>
    </asp:GridView>
</asp:Content>
