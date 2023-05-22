<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarCust.Master" AutoEventWireup="true" CodeBehind="orderRamen.aspx.cs" Inherits="LABPSD_RAAMEN.View.orderRamen" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="566px"></asp:GridView>
</asp:Content>
