<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarAdmin.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LABPSD_RAAMEN.View.Admin.Home" %>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <h1>Staff</h1>
    <asp:GridView ID="staffGridView" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Staff ID" SortExpression="Id" />
            <asp:BoundField DataField="username" HeaderText="Staff Name" SortExpression="username" />
            <asp:BoundField DataField="email" HeaderText="Staff Email" SortExpression="email" />
            <asp:BoundField DataField="gender" HeaderText="Staff Gender" SortExpression="gender" />
        </Columns>
    </asp:GridView>
    <br />

    <h1>Customer</h1>
      <asp:GridView ID="userGridView" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Customer ID" SortExpression="Id" />
            <asp:BoundField DataField="username" HeaderText="Customer Name" SortExpression="username" />
            <asp:BoundField DataField="email" HeaderText="Customer Email" SortExpression="email" />
            <asp:BoundField DataField="gender" HeaderText="Customer Gender" SortExpression="gender" />
        </Columns>
    </asp:GridView>
</asp:Content>
