<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarStaff.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LABPSD_RAAMEN.View.Staff.Home" %>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <h1>HELLO</h1>
    <p>Your Current Role is Staff</p>
    <asp:GridView ID="userGridView" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Customer ID" SortExpression="Id" />
            <asp:BoundField DataField="username" HeaderText="Customer Name" SortExpression="username" />
            <asp:BoundField DataField="email" HeaderText="Customer Email" SortExpression="email" />
            <asp:BoundField DataField="gender" HeaderText="Customer Gender" SortExpression="gender" />
        </Columns>
    </asp:GridView>
</asp:Content>
