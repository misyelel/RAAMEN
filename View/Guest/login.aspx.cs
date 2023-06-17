using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Factory;
using LABPSD_RAAMEN.Handler;
using LABPSD_RAAMEN.Controller;

namespace LABPSD_RAAMEN.View
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["user_cookie"];
                if (cookie != null)
                {
                    usernameTxt.Text = cookie.Values["username"];
                    passwordTxt.Text = cookie.Values["password"];
                }
            }
            
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            user u = UserHandler.loginHandler(usernameTxt.Text, passwordTxt.Text);
            if (u == null)
            {
                errorLbl.Text = "Username/password wrong";
                errorLbl.Visible = true;
            }
            else 
            {
                if (rememberCheckBox.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Values["username"] = usernameTxt.Text;
                    cookie.Values["password"] = passwordTxt.Text;
                    cookie.Expires.AddMinutes(2);
                    Response.Cookies.Add(cookie);
                }
                Session["user"] = u;
                if (u.roleID == 1)
                {
                    Response.Redirect("../Admin/Home.aspx");
                }
                else if (u.roleID == 2)
                {
                    Response.Redirect("../Staff/Home.aspx");
                }
                else if (u.roleID == 3)
                {
                    Response.Redirect("../Cust/Home.aspx");
                }
            } 
        }
    }
}