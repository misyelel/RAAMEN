using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Factory;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Model;

namespace LABPSD_RAAMEN.Handler
{
    public class UserHandler
    {
        private static Random random = new Random();

        static Database1Entities db = DBSingleton.GetInstance();

        public static bool checkId(int id)
        {
            user u = (from x in db.users
                      where x.Id == id
                      select x).FirstOrDefault();
            if (u == null)
            {
                return true;
            }
            return false;
        }

        public static int generateUserId()
        {
            int id=0;
            bool unique = false;
            while (unique==false)
            {
                id = random.Next();
                unique = checkId(id);
            }

            return id;
        }

        public static user loginHandler(string username, string password)
        {
            return db.users.Where(x => x.username == username && x.password == password).FirstOrDefault();
           
        }
    }
}