﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarCust.Master" AutoEventWireup="true" CodeBehind="profileCust.aspx.cs" Inherits="LABPSD_RAAMEN.View.profile" %>
<asp:Content ID="navbar" ContentPlaceHolderID="contentBody" runat="server">
    <h1>PROFILE</h1>
    <div>
            <div>
             <asp:Label ID="usernameLbl" runat="server" Text="Username"></asp:Label>
             </div>
             <asp:TextBox ID="usernameTxt" runat="server"  Enabled="false"></asp:TextBox>
             <div>
                 <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
             </div>
             <asp:TextBox ID="emailTxt" runat="server"  Enabled="false"></asp:TextBox>             

            <div>
                 <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
             </div>
            <div>
                <asp:radiobutton id="maleBtn" groupname="genders" runat="server" text="Male" value="1"/>
                <asp:radiobutton id="femaleBtn" groupname="genders" runat="server" text="Female" value="2" />
            </div>
             <div>
                 <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
             </div>
             <asp:TextBox ID="passwordTxt" runat="server"  Enabled="false"></asp:TextBox>
             <div>
                 <asp:Label ID="confirmpassLbl" runat="server" Text="Confirmation Password" Visible="false"></asp:Label>
             </div>
             <asp:TextBox ID="confirmpassTxt" runat="server"  Visible="false"></asp:TextBox>
                <div>
                 <asp:Label ID="errorLbl" runat="server" ForeColor="Red" Visible="false"></asp:Label>
             </div>
        </div>
    <div>
        <div>
            <asp:Button ID="saveChangesButton" runat="server" Text="Save Changes" Visible="false" OnClick="saveChangesButton_Click"/>
            <asp:Button ID="cancelButton" runat="server" Text="Cancel" Visible="false" OnClick="cancelButton_Click"/>
        </div>
        <div>
            <asp:Button ID="editProfileButton" runat="server" Text="Edit Profile" OnClick="editProfileButton_Click" />
        </div>
    </div>
</asp:Content>
