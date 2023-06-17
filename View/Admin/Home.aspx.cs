using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;
namespace LABPSD_RAAMEN.View.Admin
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                staffGridView.DataSource = AdminRepository.GetStaffData();
                staffGridView.DataBind();

                userGridView.DataSource = AdminRepository.GetCustomerData();
                userGridView.DataBind();
            }
        }
    }
}