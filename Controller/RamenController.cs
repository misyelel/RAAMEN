using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Handler;

namespace LABPSD_RAAMEN.Controller
{
    public class RamenController
    {
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
    }
}