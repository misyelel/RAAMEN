<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarCust.Master" AutoEventWireup="true" CodeBehind="orderRamen.aspx.cs" Inherits="LABPSD_RAAMEN.View.orderRamen" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div style="display:flex; flex-direction:row; justify-content:space-around">
        <h1>Order Ramen</h1>
        <asp:Button ID="cartBtn" runat="server" Text="View Cart" OnClick="cartBtn_Click" />
    </div>
    
    <asp:GridView ID="ramenGridView" runat="server" Width="566px" AutoGenerateColumns="False" OnSelectedIndexChanged="ramenGridView_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Ramen ID" SortExpression="id" />
            <asp:BoundField DataField="name" HeaderText="Ramen Name" SortExpression="name" />
            <asp:BoundField DataField="broth" HeaderText="Broth" SortExpression="broth" />
            <asp:BoundField DataField="meat.name" HeaderText="Meat" SortExpression="meat.name" />
            <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Purchase" ShowHeader="True" Text="Add To Cart" />            
        </Columns>
       </asp:GridView>

</asp:Content>
