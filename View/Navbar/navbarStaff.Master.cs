using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LABPSD_RAAMEN.View
{
    public partial class navbarStaff : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/Home.aspx");
        }

        protected void manageRamenBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/ManageRamen.aspx");
        }

        protected void profileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/Profile.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("../Guest/login.aspx");
        }

        protected void orderQBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/OrderQueue.aspx");
        }
    }
}