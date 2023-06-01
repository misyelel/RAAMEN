using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Controller;
using LABPSD_RAAMEN.Factory;

namespace LABPSD_RAAMEN.Handler
{
    public class OrderHandler
    {
        static Database1Entities db = DBSingleton.GetInstance();
        public static bool checkHeaderId(int id)
        {
            header h = (from x in db.headers
                        where x.Id == id
                        select x).FirstOrDefault();
            if (h == null)
            {
                return true;
            }
            return false;
        }

        public static List<detail> GetUserCart(int userId)
        {
            header header = OrderRepository.GetActiveOrderByUser(userId);
            List<detail> details = OrderRepository.GetDetailsByHeaderId(header.Id);
            return details;
        }
    }
}