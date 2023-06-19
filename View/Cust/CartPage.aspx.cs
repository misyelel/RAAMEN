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

namespace LABPSD_RAAMEN.View.Cust
{
    public partial class CartPage : System.Web.UI.Page
    {
        static Database1Entities1 db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                user u = (user)Session["user"];
                if (u == null || u.roleID != 3)
                {
                    Session.Clear();
                    Response.Redirect("/View/Guest/login.aspx");
                }
                header h = (header)Session["cart"];
                List<detail> orderDetails = (List<detail>)Session["order"];

                if (orderDetails != null)
                {
                    if (orderDetails.Count.Equals(0))
                    {
                        Session.Remove("cart");
                        Session.Remove("order");
                        h = null;
                        orderDetails = null;
                        checkoutBtn.Visible = false;
                    }
                }
                else
                {
                    Session.Remove("cart");
                    Session.Remove("order");
                    h = null;
                    orderDetails = null;
                    checkoutBtn.Visible = false;
                }

                if (h != null)
                {
                    btnBack.Visible = false;
                    cartGridView.Visible = true;
                    checkoutBtn.Visible = true;

                    cartGridView.DataSource = orderDetails;
                    cartGridView.DataBind();
                }
                else
                {
                   
                    btnBack.Visible = true;
                    backBtn.Visible = false;
                    statusLabel.Visible = true;
                    cartGridView.Visible = false;
                    checkoutBtn.Visible = false;
                }
            }

        }

        protected void checkoutBtn_Click(object sender, EventArgs e)
        {
            header h = (header)Session["cart"];
            List<detail> orderDetails = (List<detail>)Session["order"];

            db.headers.Add(h);
            DataBind();
            db.SaveChanges();

            db.details.AddRange(orderDetails);
            DataBind();
            db.SaveChanges();

            Session.Remove("cart");
            Session.Remove("order");
            Response.Redirect("orderRamen.aspx");
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("orderRamen.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("orderRamen.aspx");
        }

        protected void cartGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            List<detail> orderDetails = (List<detail>)Session["order"];

            
            orderDetails.RemoveAt(rowIndex);

            
            cartGridView.DataSource = orderDetails;
            cartGridView.DataBind();

            
            Session["order"] = orderDetails;
            if (orderDetails.Count.Equals(0))
            {
                btnBack.Visible = true;
                backBtn.Visible = false;
                statusLabel.Visible = true;
                cartGridView.Visible = false;
                checkoutBtn.Visible = false;
            }
        }
    }
}