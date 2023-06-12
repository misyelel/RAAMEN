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

        static Database1Entities1 db = DBSingleton.GetInstance();

        public static bool checkId(int id)
        {
            user u = UserRepository.GetUserById(id);
            if (u == null)
            {
                return true;
            }
            return false;
        }
        public static user loginHandler(string username, string password)
        {
            return db.users.Where(x => x.username == username && x.password == password).FirstOrDefault();           
        }
    }
}