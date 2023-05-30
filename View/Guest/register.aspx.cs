using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Handler;
using LABPSD_RAAMEN.Factory;
using LABPSD_RAAMEN.Controller;

namespace LABPSD_RAAMEN.View
{
    public partial class register : System.Web.UI.Page
    {
        Database1Entities db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string errorMsg = UserController.checkRegistration(usernameTxt.Text, emailTxt.Text, passwordTxt.Text, confirmpassTxt.Text);

            if(errorMsg== "Username must consists of 5 to 15 alphabets" || errorMsg == "Must ends with .com")
            {
                errorLbl.Text = errorMsg;
                errorLbl.Visible = true;
            }
            else if (CheckGender().Equals(null))
            {
                errorLbl.Text = "Gender must be chosen";
                errorLbl.Visible = true;
            }
            else if (errorMsg == "Passwords must be the same")
            {
                errorLbl.Text = errorMsg;
                errorLbl.Visible = true;
            }
            else if ( errorMsg == "true")
            {
                user u = userFactory.AddUser(usernameTxt.Text, emailTxt.Text, CheckGender() ,passwordTxt.Text);
                db.users.Add(u);
                DataBind();
                db.SaveChanges();               
                Response.Redirect("login.aspx");
            }
            else if (errorMsg == "false")
            {
                errorLbl.Text = "error";
                errorLbl.Visible = true;
            }
        }

        protected string CheckGender()
        {
            string gender = null;
            if (maleRadio.Text.Equals("Male"))
            {
                gender = maleRadio.Text;
            }
            else if (femaleRadio.Text.Equals("Female"))
            {
                gender = femaleRadio.Text;
            }
            return gender;
        }

    }
}