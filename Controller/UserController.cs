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
        static Database1Entities db = DBSingleton.GetInstance();
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
            if (validate(@"\.com$", email) == false)
            {
                return false;
            }
            return true;
        }

        public static bool confirmPassword(string password, string confirmPass)
        {
            if (password.Equals(confirmPass) == false)
            {
                return false;
            }
            return true;
        }

        //public static bool checkGender(RadioButton male, RadioButton female)
        //{
        //    if (male.Checked == false && female.Checked == false)
        //    {
        //        return false;
        //    }
        //    else if (male.Checked == true && female.Checked == true)
        //    {
        //        return false;
        //    }
        //    return true;
        //}


        public static bool checkRegistration(string username, string email, string password, string confirmPass)
        {
            if (checkUsername(username) == true && checkEmail(email) == true && confirmPassword(password, confirmPass) == true)
            {
                return true;
            }

            return false;
        }
    }
}