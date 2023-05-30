using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LABPSD_RAAMEN.Model;

namespace LABPSD_RAAMEN.Repository
{
    public class DBSingleton
    {
        //Singleton
        //Punya class, punya object
        //Otomatis tiap object beda atribut
        //Kalau pake singleton, cuma mau satu object aja yang dipakai

        static Database1Entities db = null;
       

        public static Database1Entities GetInstance()
        {
            if (db == null)
            {
                db = new Database1Entities();

            }
            return db;
        }
    }
}
