using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Model;
namespace LABPSD_RAAMEN.Repository
{
    public class AdminRepository
    {
        static Database1Entities1 db = DBSingleton.GetInstance();

        public static List<user> GetStaffData()
        {
            List<user> u = db.users.Where(x => x.roleID == 2).ToList();

            return u;


        }
    }
}