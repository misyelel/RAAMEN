<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarStaff.Master" AutoEventWireup="true" CodeBehind="OrderQueue.aspx.cs" Inherits="LABPSD_RAAMEN.View.Staff.OrderQueue" %>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <br />
    <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
    <br />
    <br />
    <asp:GridView ID="queueGridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="queueGridView_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Header ID" SortExpression="headerID" />
            <asp:BoundField DataField="customerID" HeaderText="Customer ID" SortExpression="CustomerID" />
            <asp:BoundField DataField="staffID" HeaderText="Staff ID" SortExpression="staffID" />
            <asp:BoundField DataField="date" HeaderText="Date" SortExpression="Date" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Actions" ShowHeader="True" Text="Handle" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnViewHandled" runat="server" Text="View Handled Order" OnClick="btnViewHandled_Click" />
</asp:Content>
