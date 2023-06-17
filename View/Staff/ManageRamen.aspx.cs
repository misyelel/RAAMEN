using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Model;
namespace LABPSD_RAAMEN.View.Staff
{
    public partial class ManageRamen : System.Web.UI.Page
    {
        static Database1Entities1 db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ramenGridView.DataSource = StaffRepository.GetAllRamen();
                ramenGridView.DataBind();
            }
        }

        protected void btnInsertRamen_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Staff/InsertRamen.aspx");
        }


        protected void ramenGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = ramenGridView.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);

            Response.Redirect("../Staff/UpdateRamen.aspx?ID="+id);
        }

        protected void ramenGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                GridViewRow row = ramenGridView.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells[0].Text);

                raman rm = db.ramen.Find(id);
                db.ramen.Remove(rm);
                db.SaveChanges();

                ramenGridView.DataSource = StaffRepository.GetAllRamen();
                ramenGridView.DataBind();
            }
            catch (Exception ex)
            {
                lblError.Text = "Data tersebut tidak dapat dihapus, karena sedang digunakan!";
            }

        }
    }
}