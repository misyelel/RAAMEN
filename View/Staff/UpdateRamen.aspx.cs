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
    public partial class UpdateRamen : System.Web.UI.Page
    {
        static Database1Entities1 db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlMeat.DataSource = StaffRepository.GetAllMeat();
                ddlMeat.DataBind();

                string id = Request["ID"];
                int ramenId = int.Parse(id);
                raman rm = db.ramen.Find(ramenId);
                txtName.Text = rm.name;
                ddlMeat.SelectedValue = StaffRepository.GetMeatNameById(rm.meatID);
                txtBroth.Text = rm.broth;
                txtPrice.Text = rm.price;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/ManageRamen.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = Request["ID"];
            int updateID = int.Parse(id);
            string name = txtName.Text.ToString();
            string meatName = ddlMeat.SelectedValue;
            int meatId = StaffRepository.GetIdByMeat(meatName);
            string broth = txtBroth.Text.ToString();
            string price = txtPrice.Text.ToString();

            raman updateRamen = db.ramen.Find(updateID);
            updateRamen.name = name;
            updateRamen.meatID = meatId;
            updateRamen.broth = broth;
            updateRamen.price = price;

            db.SaveChanges();
        }
    }
}