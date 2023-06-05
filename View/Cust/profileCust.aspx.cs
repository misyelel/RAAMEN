using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Factory;
using LABPSD_RAAMEN.Handler;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Controller;

namespace LABPSD_RAAMEN.View
{
    public partial class profile : System.Web.UI.Page
    {
        static Database1Entities db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            user u = (user)Session["user"];
            showData(u);
        }

        protected void editProfileButton_Click(object sender, EventArgs e)
        {
            enableAll();
        }

        protected void saveChangesButton_Click(object sender, EventArgs e)
        {
            string errorMsg = UserController.checkRegistration(usernameTxt.Text, emailTxt.Text, passwordTxt.Text, confirmpassTxt.Text);

            if (errorMsg == "Username must consists of 5 to 15 alphabets" || errorMsg == "Must ends with .com")
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
            else if (errorMsg == "true")
            {
                user uid = (user)Session["user"];
                user u = db.users.Find(uid.Id);
                u.username = usernameTxt.Text;
                u.email = emailTxt.Text;
                u.gender = CheckGender();
                u.password = passwordTxt.Text;
                DataBind();
                db.SaveChanges();
                disableAll();
            }
            else if (errorMsg == "false")
            {
                errorLbl.Text = "error";
                errorLbl.Visible = true;
            }            
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            user u = (user)Session["user"];
            showData(u);
        }

        protected void showData(user u)
        {            
            usernameTxt.Text = u.username;
            emailTxt.Text = u.email;
            if (u.gender.Equals("Male"))
            {
                maleBtn.Checked = true;
            }
            else if (u.gender.Equals("Female"))
            {
                femaleBtn.Checked = true;
            }
            passwordTxt.Text = u.password;
        }

        protected void enableAll()
        {
            usernameTxt.Enabled = true;
            emailTxt.Enabled = true;
            maleBtn.Enabled = true;
            femaleBtn.Enabled = true;
            passwordTxt.Enabled = true;
            confirmpassLbl.Visible = true;
            confirmpassTxt.Visible = true;
            saveChangesButton.Visible = true;
            cancelButton.Visible = true;
        }

        protected void disableAll()
        {
            usernameTxt.Enabled = false;
            emailTxt.Enabled = false;
            maleBtn.Enabled = false;
            femaleBtn.Enabled = false;
            passwordTxt.Enabled = false;
            confirmpassLbl.Visible = false;
            confirmpassTxt.Visible = false;
            editProfileButton.Visible = false;
        }

        protected string CheckGender()
        {
            string gender = null;
            if (maleBtn.Text.Equals("Male"))
            {
                gender = maleBtn.Text;
            }
            else if (femaleBtn.Text.Equals("Female"))
            {
                gender = femaleBtn.Text;
            }
            return gender;
        }
    }
}