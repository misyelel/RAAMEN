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
            user u = (user)Session["user"];
            nameLabel.Text = u.username;
        }
    }
}