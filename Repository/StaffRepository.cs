using LABPSD_RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABPSD_RAAMEN.Repository
{
    public class StaffRepository
    {
        static Database1Entities db = DBSingleton.GetInstance();

        public static List<user> GetStaffData()
        {
            List<user> staff = db.users.Where(u => u.roleID == 2).ToList();
            return staff;
        }
    }
}