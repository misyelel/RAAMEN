<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarAdmin.Master" AutoEventWireup="true" CodeBehind="ManageRamen.aspx.cs" Inherits="LABPSD_RAAMEN.View.Admin.ManageRamen" %>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
     <h1>Manage Ramen</h1>

    <asp:GridView ID="ramenGridView" runat="server" AutoGenerateColumns="False"  OnRowEditing="ramenGridView_RowEditing" OnRowDeleting="ramenGridView_RowDeleting">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Ramen ID" SortExpression="Id" />
            <asp:BoundField DataField="meatID" HeaderText="Meat ID" SortExpression="meatID" />
            <asp:BoundField DataField="name" HeaderText="Ramen Name's" SortExpression="name" />
            <asp:BoundField DataField="broth" HeaderText="Ramen Broth's" SortExpression="broth" />
            <asp:BoundField DataField="price" HeaderText="Ramen Price" SortExpression="price" />
            <asp:CommandField HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" ButtonType="Button" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    <br />

    <asp:Button ID="btnInsertRamen" runat="server" Text="Insert New Ramen" OnClick="btnInsertRamen_Click" />
</asp:Content>
