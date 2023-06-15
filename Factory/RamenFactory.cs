using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Model;

namespace LABPSD_RAAMEN.Factory
{

    public class RamenFactory
    {
        public static raman InsertRamen(int id, int meatid, string name, string broth, string price)
        {
            raman rm = new raman();
            rm.Id = id;
            rm.meatID = meatid;
            rm.name = name;
            rm.broth = broth;
            rm.price = price;
            return rm;
        }
    }
}