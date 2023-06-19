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
        static Database1Entities1 db = DBSingleton.GetInstance();
        public static bool checkHeaderId(int id)
        {
            int? maxId = db.headers.Max(x => (int?)x.Id);

            if (maxId.HasValue && id > maxId.Value)
            {
                return true;
            }
            return false;
        }

        public static void DeleteLastHeader()
        {
            var lastHeader = db.headers.OrderByDescending(x => x.Id).FirstOrDefault();

            if (lastHeader != null)
            {
                db.headers.Remove(lastHeader);
                db.SaveChanges();
            }
        }

        //public static List<detail> GetUserCart(int userId)
        //{
        //    header header = OrderRepository.GetActiveOrderByUser(userId);
        //    List<detail> details = OrderRepository.GetDetailsByHeaderId(header.Id);
        //    return details;
        //}

        public static List<header> GetHistory(int userId)
        {
            return OrderRepository.GetOrdersByUser(userId);
        }

        public static List<header> GetAllHistory()
        {
            return OrderRepository.GetHistoryData();
        }
        public static List<detail> GetDetails(int headerId)
        {
            return OrderRepository.GetDetailsByHeaderId(headerId);
        }

        public static detail GetDetailByRamenId(int id)
        {
            return OrderRepository.GetDetailByRamenId(id);
        }
    }
}