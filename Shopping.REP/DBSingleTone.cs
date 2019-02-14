using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping.DAL;
namespace Shopping.REP
{
    public class DBSingleTone
    {
        static NorthwindEntities db;

        public static NorthwindEntities GetInstance()
        {
            if (db==null)
            {
                db = new NorthwindEntities();
            }
            return db;         
        }
    }


}
