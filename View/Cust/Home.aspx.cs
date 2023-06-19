using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Model;

namespace LABPSD_RAAMEN.View.Cust
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                user u = (user)Session["user"];
                if (u==null || u.roleID != 3)
                {
                    Session.Clear();
                    Response.Redirect("/View/Guest/login.aspx");
                }
                nameLabel.Text = u.username;
            }
            
        }
    }
}