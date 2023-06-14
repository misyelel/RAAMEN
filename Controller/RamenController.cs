using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Handler;
using LABPSD_RAAMEN.Factory;
namespace LABPSD_RAAMEN.Controller
{
    public class RamenController
    {
        static Database1Entities1 db = DBSingleton.GetInstance();
        public static string GetRamenName(int id)
        {
            raman r = RamenHandler.GetRamenById(id);
            return r.name;
        }
        public static string GetRamenPrice(int id)
        {
            raman r = RamenHandler.GetRamenById(id);
            return r.price;
        }
        private static int GetMeatIdByName(string meatName)
        {
            meat meat = db.meats.FirstOrDefault(m => m.name == meatName);
            if (meat != null)
            {
                return meat.Id;
            }
            else
            {
                return -1; 
            }
        }
        public static bool InsertRamenToTable(int id, string meat, string name, string broth, string price)
        {

            try
            {
                int meatId = GetMeatIdByName(meat);
                if (meatId != -1)
                {
                    raman rm = RamenFactory.InsertRamen(id, meatId, name, broth, price);
                    db.ramen.Add(rm);
                    db.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}