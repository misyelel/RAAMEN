using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Model;
using LABPSD_RAAMEN.Repository;

namespace LABPSD_RAAMEN.Controller
{
    public class GenerateID
    {
        public static int GenerateIDs(string table, string kolom)
        {
            Database1Entities1 db = DBSingleton.GetInstance();

            var lastData = db.Database.SqlQuery<int>($"SELECT TOP 1 {kolom} FROM {table} ORDER BY {kolom} DESC").FirstOrDefault();
   
            if (lastData == 0)
            {
                return 1;
            }        
            int nextId = lastData + 1;

            return nextId;
        }
    }
}
