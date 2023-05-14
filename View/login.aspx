<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LABPSD_RAAMEN.View.login" %>

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
                 <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
             </div>
             <asp:TextBox ID="passwordTxt" runat="server"></asp:TextBox>
             <div>
                  <asp:CheckBox ID="rememberCheckBox" runat="server" Text="Remember Me" />
             </div>
             
             <asp:Button ID="loginBtn" runat="server" Text="Login" />
        </div>
    </form>
</body>
</html>
