using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End
{
   public class Person
    {
        protected string Name;
        public string name { get { return Name; } set { Name = value; } }
        protected string ID;
        public string id { get { return ID; } set { ID = value; } }

       protected string Address;
       public string address { get { return Address; } set { Address = value; } }
       protected string Gender;
       public string gender { get { return Gender; } set { Gender = value; } }
        protected int Age;
        public int age { get { return Age; } set { Age = value; } }
        protected Int64 contact_info;
        public Int64 Contact_info { get { return contact_info; } set { contact_info = value; } }

        protected string cnic;
        public string Cnic { get { return cnic; } set { cnic = value; } }

        public static string dbconn()
        {
            string dbconnect = "datasource=localhost; username=root; password=; database = OOP";

            return dbconnect;
        }

    }
}
