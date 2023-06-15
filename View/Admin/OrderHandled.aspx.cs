using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Repository;
namespace LABPSD_RAAMEN.View.Admin
{
    public partial class OrderHandled : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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