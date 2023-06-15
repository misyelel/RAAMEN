using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LABPSD_RAAMEN.View
{
    public partial class navbarAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reportBtn_Click(object sender, EventArgs e)
        {
            //Response.Redirect("../Admin/TransactionsReport.aspx");
        }

        protected void orderQBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/OrderQueue.aspx");
        }

        protected void manageRamenBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/ManageRamen.aspx");
        }

        protected void historyBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/History.aspx");
        }

        protected void profileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/Profile.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("../Guest/login.aspx");
        }
    }
}