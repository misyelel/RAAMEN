<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarStaff.Master" AutoEventWireup="true" CodeBehind="InsertRamen.aspx.cs" Inherits="LABPSD_RAAMEN.View.Staff.InsertRamen" %>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <br />
    <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />

     <asp:Label ID="Label2" runat="server" Text="Meat"></asp:Label>
    <asp:DropDownList ID="ddlMeat" runat="server"></asp:DropDownList>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Broth"></asp:Label>
    <asp:TextBox ID="txtBroth" runat="server"></asp:TextBox>
    <br />
        <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />

</asp:Content>
