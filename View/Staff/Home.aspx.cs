using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Controller;
using LABPSD_RAAMEN.Factory;
using LABPSD_RAAMEN.Handler;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Model;

namespace LABPSD_RAAMEN.View.Staff
{
    public partial class Home : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                user u = (user)Session["user"];
                if (u == null || u.roleID != 2)
                {
                    Session.Clear();
                    Response.Redirect("/View/Guest/login.aspx");
                }
            }
            userGridView.DataSource = StaffRepository
                .GetUserData();
            userGridView.DataBind();
        }
    }
}