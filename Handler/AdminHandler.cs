using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Dataset;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Report;
using LABPSD_RAAMEN.Repository;
using LABPSD_RAAMEN.Controller;
using LABPSD_RAAMEN.Factory;
namespace LABPSD_RAAMEN.Handler
{
    public class AdminHandler
    {
        public static List<header> GetDataHeader()
        {
            return AdminRepository.GetHeader();
        }
    }
}