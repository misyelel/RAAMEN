using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Factory;
using LABPSD_RAAMEN.Handler;
using LABPSD_RAAMEN.Controller;

namespace LABPSD_RAAMEN.View.Admin
{
    public partial class History : System.Web.UI.Page
    {
        public List<detail> details = new List<detail>();

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
                historyGridView.DataSource = OrderHandler.GetAllHistory();
                historyGridView.DataBind();
            }
        }

        protected void historyGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow selectedRow = historyGridView.SelectedRow;
            int headerId = int.Parse(selectedRow.Cells[1].Text);
            details = OrderHandler.GetDetails(headerId);
        }
    }
}