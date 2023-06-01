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
        static Database1Entities db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            user u = (user)Session["user"];
            ramenGridView.DataSource = RamenRepository.GetAllRamen();
            ramenGridView.DataBind();

            //cartGridView.DataSource = OrderHandler.GetUserCart(u.Id);
            //cartGridView.DataBind();
        }

        protected void ramenGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = Convert.ToInt32(e);

            // Access the input data from GridView1
            GridViewRow row = ramenGridView.Rows[rowIndex];
            raman r = RamenHandler.FindRamen(row.Cells[0].Text);

            // Add data to GridView2
            DataTable dt = GetCartGridViewData();
            dt.Rows.Add(r.name, 1, r.price);
            cartGridView.DataSource = dt;
            cartGridView.DataBind();
        }
        protected DataTable GetCartGridViewData()
        {
            DataTable dt = new DataTable();
            // Define your columns
            dt.Columns.Add("Ramen");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Price");

            // Retrieve existing data from GridView2, if any
            if (cartGridView.DataSource != null)
            {
                dt = (DataTable)cartGridView.DataSource;
            }

            return dt;
        }

        protected void ramenGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
}