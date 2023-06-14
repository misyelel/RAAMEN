using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Factory;

namespace LABPSD_RAAMEN.Repository
{
    public class UserRepository
    {
        static Database1Entities1 db = DBSingleton.GetInstance();
        public static user GetUserById(int id)
        {
            user u = db.users.Where(x => x.Id == id).FirstOrDefault();
            return u;
        }
    }
}