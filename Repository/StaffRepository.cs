using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Model;
namespace LABPSD_RAAMEN.Repository
{
    public class StaffRepository
    {
        static Database1Entities1 db = DBSingleton.GetInstance();
        public static List<user> GetUserData()
        {
            List<user> u = db.users.Where(x => x.roleID == 3).ToList();

            return u;
        }
        public static List<raman> GetAllRamen()
        {
            List<raman> ramen = db.ramen.ToList();
            return ramen;
        }

        public static List<string> GetAllMeat()
        {
            List<string> m = db.meats.Select(x => x.name).ToList();
            return m;
                
        }
    }
}