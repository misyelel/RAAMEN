using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Handler;
using LABPSD_RAAMEN.Factory;
using System.Text.RegularExpressions;

namespace LABPSD_RAAMEN.Controller
{
    public class UserController
    {
        private static Random random = new Random();
        public static int generateUserId()
        {

            int id = 0;
            bool unique = false;
            while (unique == false)
            {
                id = random.Next();
                unique = UserHandler.checkId(id);
            }

            return id;
        }

       
        public static bool validate(string pattern, string input)
        {
            return Regex.IsMatch(input, pattern);
        }

        public static bool checkUsername(string username)
        {

            if (username.Length < 5 || username.Length > 15)
            {
                return false;
            }
            else if (validate("^[a-zA-Z]+$", username) == false)
            {
                return false;
            }
            return true;
        }

        public static bool checkEmail(string email)
        {
            if (validate(@".+\.com$", email) == false)
            {
                return false;
            }
            return true;
        }

        public static bool confirmPassword(string password, string confirmPass)
        {
            if(password=="" || confirmPass == "")
            {
                return false;
            }
            if (password.Equals(confirmPass) == false)
            {
                return false;
            }
            return true;
        }

        public static string checkRegistration(string username, string email, string password, string confirmPass)
        {            
            if (checkUsername(username)==false)
            {
                return "Username must consists of 5 to 15 alphabets";
            }
            else if (checkEmail(email) == false)
            {
                return "Must ends with .com";
            }
            else if (confirmPassword(password, confirmPass) == false)
            {
                return "Passwords must be the same";
            }
            else if (checkUsername(username) == true && checkEmail(email) == true && confirmPassword(password, confirmPass) == true)
            {
                return "true";
            }

            return "false";
        }
    }
}