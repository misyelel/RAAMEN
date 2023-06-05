<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarCust.Master" AutoEventWireup="true" CodeBehind="orderRamen.aspx.cs" Inherits="LABPSD_RAAMEN.View.orderRamen" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <h1>Order Ramen</h1>
    <asp:GridView ID="ramenGridView" runat="server" Width="566px" AutoGenerateColumns="False" OnSelectedIndexChanged="ramenGridView_SelectedIndexChanged" OnSelectedIndexChanging="ramenGridView_SelectedIndexChanging">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="Ramen Name" SortExpression="name" />
            <asp:BoundField DataField="broth" HeaderText="Broth" SortExpression="broth" />
            <asp:BoundField DataField="meat.name" HeaderText="Meat" SortExpression="meat.name" />
            <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Purchase" ShowHeader="True" Text="Add To Cart" />
        </Columns>

       
        
    </asp:GridView>
     <h1>CART</h1>
    <asp:GridView ID="cartGridView" runat="server"></asp:GridView>

</asp:Content>
