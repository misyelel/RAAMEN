using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Model;

namespace LABPSD_RAAMEN.Repository
{
    public class RamenRepository
    {
        static Database1Entities1 db = DBSingleton.GetInstance();
        public static List<raman> GetAllRamen()
        {
            List<raman> ramen = db.ramen.ToList();
            return ramen;
        }

        public static raman GetRamen(int id)
        {
            return db.ramen.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}