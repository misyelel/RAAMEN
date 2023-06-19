using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Handler;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;

namespace LABPSD_RAAMEN.Controller
{
    public class OrderController
    {
        private static Random random = new Random();
        public static int generateHeaderId()
        {

            int id = 0;
            bool unique = false;
            while (unique == false)
            {
                id = random.Next();
                unique = OrderHandler.checkHeaderId(id);
            }

            return id;
        }

        public static int GetRamenQuantityFromDetail(int id)
        {
            detail d = OrderHandler.GetDetailByRamenId(id);
            return d.quantity;
        }



    }
}