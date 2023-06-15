using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Controller;
using LABPSD_RAAMEN.Handler;

namespace LABPSD_RAAMEN.Factory
{

    public class OrderFactory
    {
        public static header AddHeaderFromUser(int customerId)
        {
            header h = new header();
            h.Id = OrderController.generateHeaderId();
            h.customerID = customerId;
            // sebelumnya :
            // h.staffID = 2;
            h.staffID = 0;
            h.date = DateTime.Now;
            return h;
        }

        public static detail AddDetail(int headerId, int ramenId, int quantity)
        {
            detail d = new detail();
            d.headerID = headerId;
            d.ramenID = ramenId;
            d.quantity = quantity;
            return d;
        }

        //public static List<detail> AddDetailRange(int headerId)
        //{
        //    List<detail> details = new List<detail>();

        //}
    }
}