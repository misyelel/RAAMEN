﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarCust.Master" AutoEventWireup="true" CodeBehind="profileCust.aspx.cs" Inherits="LABPSD_RAAMEN.View.profile" %>
<asp:Content ID="navbar" ContentPlaceHolderID="contentBody" runat="server">
    <div>
             <asp:Label ID="usernameLbl" runat="server" Text="Username"></asp:Label>
             </div>
             <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
            <div>
                 <asp:Label ID="errorLbl" runat="server" ForeColor="Red"></asp:Label>
             </div>

             <div>
                 <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
             </div>
             <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
             <div>
                 <asp:Label ID="ErrorLbl2" runat="server" ForeColor="Red"></asp:Label>
             </div>

            <div>
                 <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
             </div>
            <div>
                <asp:RadioButton ID="maleBtn" runat="server" Text="Male" />
                <asp:RadioButton ID="femaleBtn" runat="server" Text="Female" />
            </div>
            

             <div>
                 <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
             </div>
             <asp:TextBox ID="passwordTxt" runat="server"></asp:TextBox>
             <div>
                 <asp:Label ID="confirmpassLbl" runat="server" Text="Confirmation Password"></asp:Label>
             </div>
             <asp:TextBox ID="confirmpassTxt" runat="server"></asp:TextBox>
        </div>
</asp:Content>
