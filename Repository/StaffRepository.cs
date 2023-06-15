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

        public static string GetMeatNameById(int meatId)
        {
            meat selectedMeat = db.meats.FirstOrDefault(m => m.Id == meatId);
            if (selectedMeat != null)
            {
                return selectedMeat.name;
            }
            return string.Empty;
        }

        public static int GetIdByMeat(string meatName)
        {
            meat selectedMeat = db.meats.FirstOrDefault(m => m.name == meatName);
            if (selectedMeat != null)
            {
                return selectedMeat.Id;
            }
            return 0;
        }


    }
}