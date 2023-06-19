using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Model;

namespace LABPSD_RAAMEN.View.Admin
{
    public partial class OrderHandled : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                user u = (user)Session["user"];
                if (u == null || u.roleID != 1)
                {
                    Session.Clear();
                    Response.Redirect("/View/Guest/login.aspx");
                }
                handledGridView.DataSource = OrderRepository.GetHandledOrders();
                handledGridView.DataBind();
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/ManageRamen.aspx");
        }
    }
}