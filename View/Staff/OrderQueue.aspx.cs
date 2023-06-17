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
    public partial class OrderQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                user u = (user)Session["user"];
                
                queueGridView.DataSource = OrderRepository.GetActiveOrders();
                queueGridView.DataBind();
            }
        }

        protected void btnViewHandled_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/OrderHandled.aspx");
        }

      
        protected void queueGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            user u = (user)Session["user"];
            int staffid = u.Id;
            GridViewRow selectedRow = queueGridView.SelectedRow;
            TableCell staffIdCell = selectedRow.Cells[2]; 

            staffIdCell.Text = staffid.ToString(); 

            int headerId = Convert.ToInt32(selectedRow.Cells[0].Text); 
            OrderRepository.UpdateHeaderStaffId(headerId, staffid);

            queueGridView.DataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/ManageRamen.aspx");
        }
    }
}