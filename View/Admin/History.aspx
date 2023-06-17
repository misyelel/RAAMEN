<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarAdmin.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="LABPSD_RAAMEN.View.Admin.History" %>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
      <div>
        <h1>HISTORY</h1>
    </div>
    <div style="display:flex; flex-direction:row; justify-content:space-around;">
        <div>
            <asp:GridView ID="historyGridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="historyGridView_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                    <asp:BoundField DataField="id" HeaderText="TransactionId" SortExpression="id" />
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Action" ShowHeader="True" Text="View Detail" />
                </Columns>
            </asp:GridView>
        </div>
        <div>
            <div>
                Transaction Details
            </div>
            <div>
                <p>Items</p>
                <table>
                    <tr>
                        <th>Ramen</th>
                        <th>Quantity</th>
                        <th>Price</th>
                    </tr>
                    <%foreach (var d in details)
                    { %>
                        <tr>
                            <td><%= d.raman.name %></td>
                            <td><%= d.quantity %></td>
                            <td><%= int.Parse(d.raman.price)*d.quantity %></td>
                        </tr>
                <%  } %>
                </table>
            </div>
        </div>
    </div>
   
</asp:Content>
