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
    public partial class InsertRamen : System.Web.UI.Page
    {
        static Database1Entities1 db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlMeat.DataSource = StaffRepository.GetAllMeat();
                ddlMeat.DataBind();

            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/ManageRamen.aspx");
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            int id = GenerateID.GenerateIDs("ramen", "Id");
            int price;
            bool isPriceValid = int.TryParse(txtPrice.Text, out price);
            bool isValid = false;

            if (isPriceValid)
            {
                isValid = StaffController.ValidateInput(txtName.Text, ddlMeat.SelectedValue, txtBroth.Text, price);
                if (isValid) Controller.RamenController.InsertRamenToTable(id, ddlMeat.SelectedValue, txtName.Text, txtBroth.Text, price.ToString());
                lblError.Text = "Insert Ramen Sucess!!!";
            }

            if (!isValid) lblError.Text = StaffController.GetErrorMessage(txtName.Text, ddlMeat.SelectedValue, txtBroth.Text, price);
            else if (!isPriceValid) lblError.Text = "Invalid price format";

        }

    }
}