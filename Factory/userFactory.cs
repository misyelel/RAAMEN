using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Handler;
namespace LABPSD_RAAMEN.Factory
{
    public class userFactory
    {
        Database1Entities db = DBSingleton.GetInstance();
        public static user AddUser(string username, string email, string gender, string password)
        {
            user u = new user();
            u.Id = UserHandler.generateUserId();
            u.username = username;
            u.email = email;
            u.gender = gender;
            u.password = password;
            return u;
        }
    }
}