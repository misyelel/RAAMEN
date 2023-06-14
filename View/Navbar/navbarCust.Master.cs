using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LABPSD_RAAMEN.View
{
    public partial class navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderRamenBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Cust/orderRamen.aspx");
        }

        protected void historyBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Cust/historyCust.aspx");
        }

        protected void profileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Cust/profileCust.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("../Guest/login.aspx");
        }
    }
}