using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;

namespace LABPSD_RAAMEN.Handler
{
    public class RamenHandler
    {
        static Database1Entities1 db = DBSingleton.GetInstance();

        public static raman FindRamen(string name)
        {
            raman r = db.ramen.Where(x => x.name == name).FirstOrDefault();
            return r;
        }

        public static raman GetRamenById(int id)
        {
            return RamenRepository.GetRamen(id);
        }

        //public static raman AddRamenToCart(int id)
        //{

        //}
    }
}