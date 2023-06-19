using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Controller;
using LABPSD_RAAMEN.Handler;
using LABPSD_RAAMEN.Factory;
using System.Data;

namespace LABPSD_RAAMEN.View
{
    public partial class orderRamen : System.Web.UI.Page
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
                ramenGridView.DataSource = RamenRepository.GetAllRamen();
                ramenGridView.DataBind();
            }
            
        }

        protected void ramenGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            user u = (user)Session["user"];
            GridViewRow selectedRow = ramenGridView.SelectedRow;
            int ramenId = int.Parse(selectedRow.Cells[0].Text);
            header h = (header)Session["cart"];

            if (h != null)
            {
                
            }
            else
            {
                Session["cart"] = OrderFactory.AddHeaderFromUser(u.Id);
                List<detail> details = new List<detail>();
                Session["order"] = details;
            }

            h = (header)Session["cart"];
            List<detail> orderDetails = (List<detail>)Session["order"];

            detail ramenDetail = orderDetails.Where(x => x.ramenID == ramenId && x.headerID==h.Id).FirstOrDefault();

            if (ramenDetail!= null)
            {
                //detail d = OrderRepository.FindRamen(h.Id, ramenId);
                //detail d = orderDetails.Where(x => x.ramenID == ramenId).FirstOrDefault();
                //d.quantity++;
                int prevQ = orderDetails.Where(x => x.ramenID == ramenId).Select(x => x.quantity).FirstOrDefault();
                orderDetails.Remove(orderDetails.Where(x => x.ramenID == ramenId).FirstOrDefault());
                orderDetails.Add(OrderFactory.AddDetail(h.Id, ramenId, prevQ+1));
                Session["order"] = orderDetails;
            }
            else
            {
                orderDetails.Add(OrderFactory.AddDetail(h.Id, ramenId, 1));
                Session["order"] = orderDetails;
            }
        }

        protected void cartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cartpage.aspx");
        }
    }
}