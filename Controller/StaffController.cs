using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABPSD_RAAMEN.Controller
{
    public class StaffController
    {
        public static bool ValidateInput(string name, string meat, string broth, int price)
        {
            if (!name.Contains("Ramen")) return false;
            if (string.IsNullOrEmpty(meat)) return false;
            if (string.IsNullOrEmpty(broth)) return false;
            if (price < 3000) return false;

            return true;
        }

        public static string GetErrorMessage(string name, string meat, string broth, int price)
        {
            if (!name.Contains("Ramen")) return "Name must contain 'Ramen'. ";
            if (string.IsNullOrEmpty(meat)) return "Meat must be selected. ";
            if (string.IsNullOrEmpty(broth)) return "Broth cannot be empty. ";
            if (price < 3000) return "Price must be at least 3000. ";

            return "Insert Ramen Success!!!";
        }
    }
}