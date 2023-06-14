using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Controller;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Handler;
using LABPSD_RAAMEN.Factory;

namespace LABPSD_RAAMEN.Repository
{
    public class OrderRepository
    {
        static Database1Entities1 db = DBSingleton.GetInstance();
        public static List<header> GetActiveOrders()
        {
            List<header> h = db.headers.Where(x => x.staffID.Equals(0)).ToList();
            return h;
        }
        public static List<header> GetHandledOrders()
        {
            List<header> h = db.headers.ToList();
            return h;
        }

        public static header GetActiveOrderByUser(int userId)
        {
            header h = db.headers.Where(x => x.staffID.Equals(null) && x.customerID == userId).FirstOrDefault();
            return h;
        }

        public static List<header> GetOrdersByUser(int userId)
        {
            List<header> h = db.headers.Where(x => x.customerID == userId).ToList();
            return h;
        }

        public static List<detail> GetDetailsByHeaderId(int headerId)
        {
            List<detail> d = db.details.Where(x => x.headerID == headerId).ToList();
            return d;
        }

        public static detail FindRamen(int headerId, int ramenId)
        {
            detail d = db.details.Where(x => x.ramenID == ramenId && x.headerID == headerId).FirstOrDefault();
            return d;
        }
        public static void UpdateHeaderStaffId(int headerId, int staffId)
        {
           
                header headerToUpdate = db.headers.FirstOrDefault(h => h.Id == headerId);
                if (headerToUpdate != null)
                {
                    headerToUpdate.staffID = staffId;
                    db.SaveChanges();
                }
            
        }
    }
}