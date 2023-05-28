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
            if (UserController.checkRegistration(usernameTxt.Text, emailTxt.Text, passwordTxt.Text, confirmpassTxt.Text) == true)
            {
                userFactory.AddUser(usernameTxt.Text, emailTxt.Text, passwordTxt.Text);
            }
        }
    }
}