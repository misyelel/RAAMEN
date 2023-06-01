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
        static Database1Entities db = DBSingleton.GetInstance();

        public header AddHeaderFromUser(int id, int customerId, DateTime date)
        {
            header h = new header();
            h.Id = id;
            h.customerID = customerId;
            h.date = date;
            return h;
        }

        public detail AddDetail(int headerId, int ramenId, int quantity)
        {
            detail d = new detail();
            d.headerID = headerId;
            d.ramenID = ramenId;
            d.quantity = quantity;
            return d;
        }
    }
}