using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace OOP_Front_End
{
    class Admin : Person
    {
        protected string Admin_Password;
        public string Admin_Pass { set { Admin_Password = value; } get { return Admin_Password; } }
      /*  public static string dbconn()
        {
            string dbconnect = "datasource=localhost; username=root; password=; database = OOP";

            return dbconnect;
        }*/



        public Cabin_Attendent  ca = new Cabin_Attendent("Morning");
        public Admin(Cabin_Attendent caobj)
        {
            ca = caobj;
        }

        public Pilot pl = new Pilot("7 years");
        public Admin(Pilot obj)
        {
            pl = obj;
        }

        public Route r = new Route();
        public Admin(Route robj)
        {
            r = robj;
        }



        //functions
        public void Login()
        {

        }
        public void Logout()
        {

        }
    }
}