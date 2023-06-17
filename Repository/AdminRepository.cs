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

        public static List<user> GetCustomerData()
        {
            List<user> u = db.users.Where(x => x.roleID == 3).ToList();

            return u;
        }

        public static List<header> GetHeader()
        {
            return db.headers.ToList();
        }
        public static decimal GetRamenPrice(int ramenID)
        {
            int price = 0;

            
            var ramen = db.ramen.FirstOrDefault(r => r.Id == ramenID);

            if (ramen != null)
            {
                int.TryParse(ramen.price, out price);
            }

            return price;
        }

    }
}