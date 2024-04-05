using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End
{
    class Airport
    {
        public static string dbconn()
        {
            string dbconnect = "datasource=localhost; username=root; password=; database = OOP";

            return dbconnect;
        }

        protected string a_name;
        public string A_name { set { a_name = value; } get { return a_name; } }

       protected string a_country;
       public string A_country { set { a_country = value; } get { return a_country; } }

       protected string a_code;
       public string A_code { set { a_code = value; } get { return a_code; } }

       protected string a_location;
       public string A_location { set { a_location = value; } get { return a_location; } }

       public Airport()
       {
           this.A_name = "Alama Iqbal international Airport";
           this.A_country = "Pakistan";
           this.A_code = "Pk661";
           this.A_location = "Lahore";
       }
    }
}
