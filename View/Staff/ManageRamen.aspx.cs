using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Repository;
namespace LABPSD_RAAMEN.View.Staff
{
    public partial class ManageRamen : System.Web.UI.Page
    {
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
    }
}