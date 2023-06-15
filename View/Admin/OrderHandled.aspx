<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarAdmin.Master" AutoEventWireup="true" CodeBehind="OrderHandled.aspx.cs" Inherits="LABPSD_RAAMEN.View.Admin.OrderHandled" %>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
     <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
    <h1>Handled Orders!!</h1>
    <asp:GridView ID="handledGridView" runat="server" AutoGenerateColumns="false">
         <Columns>
            <asp:BoundField DataField="Id" HeaderText="Header ID" SortExpression="headerID" />
            <asp:BoundField DataField="customerID" HeaderText="Customer ID" SortExpression="CustomerID" />
            <asp:BoundField DataField="staffID" HeaderText="Staff ID" SortExpression="staffID" />
            <asp:BoundField DataField="date" HeaderText="Date" SortExpression="Date" />
        </Columns>
    </asp:GridView>
</asp:Content>
