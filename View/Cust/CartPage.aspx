<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarCust.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="LABPSD_RAAMEN.View.Cust.CartPage" %>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <asp:Button ID="backBtn" runat="server" Text="Back" OnClick="backBtn_Click" />
    <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
    <div>
        <h1>CART</h1>
    </div>
    <asp:Label ID="statusLabel" runat="server" Text="There is no item in Cart!" Visible="false"></asp:Label>
    <div>
        <asp:GridView ID="cartGridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="cartGridView_RowDeleting">
            <Columns>
                <asp:BoundField DataField="ramenID" HeaderText="Ramen" SortExpression="ramen.name" />
                <asp:BoundField DataField="quantity" HeaderText="Quantity" SortExpression="quantity" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Actions" ShowHeader="True" Text="Remove" />
            </Columns>
        </asp:GridView>
    </div>
    <asp:Button ID="checkoutBtn" runat="server" Text="Checkout Order" OnClick="checkoutBtn_Click" />
</asp:Content>
