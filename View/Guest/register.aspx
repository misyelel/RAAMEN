<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="LABPSD_RAAMEN.View.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div>
             <div>
                 <asp:Label ID="usernameLbl" runat="server" Text="Username"></asp:Label>
             </div>
             <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
            

             <div>
                 <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
             </div>
                <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
           
            <div>
                 <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
             </div>
            <div>
                <asp:radiobutton id="maleRadio" groupname="genders" runat="server" text="Male" value="1"/>
                <asp:radiobutton id="femaleRadio" groupname="genders" runat="server" text="Female" value="2" />
              
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
            <div>
                 <asp:Label ID="errorLbl" runat="server" ForeColor="Red" Visible="False"></asp:Label>
             </div>
        <div>
             <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" />
        </div>
       
            <div>
                 <a href="login.aspx">"Already have an account? Login here"</a>
             </div>
    </form>
</body>
</html>
