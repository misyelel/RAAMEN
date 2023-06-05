using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LABPSD_RAAMEN.Controller;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Factory;
using LABPSD_RAAMEN.Handler;
using LABPSD_RAAMEN.Repository;

namespace LABPSD_RAAMEN.View.Staff
{
    public partial class Home : System.Web.UI.Page
    {
        static Database1Entities db = DBSingleton.GetInstance();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<user> users = db.users.Where(x=>x.roleID==3).ToList();
            userGridView.DataSource = users;
            userGridView.DataBind();
        }
    }
}