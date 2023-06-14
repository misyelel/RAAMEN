<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarAdmin.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LABPSD_RAAMEN.View.Admin.viewCust" %>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <h1>Hello mint</h1>

    <asp:GridView ID="gridViewStaff" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID" SortExpression="Id" />
            <asp:BoundField DataField="username" HeaderText="Username" SortExpression="username" />
            <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
            <asp:BoundField DataField="gender" HeaderText="Gender" SortExpression="gender" />
        </Columns>
    </asp:GridView>
</asp:Content>
