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
namespace LABPSD_RAAMEN.View.Staff
{
    public partial class OrderHandled : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            handledGridView.DataSource = OrderRepository.GetHandledOrders();
            handledGridView.DataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/ManageRamen.aspx");
        }
    }
}