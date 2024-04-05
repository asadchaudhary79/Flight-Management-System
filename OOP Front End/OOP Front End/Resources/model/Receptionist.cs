using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace OOP_Front_End
{
   class Receptionist:Person
    {
       protected string reception_passowrd;
       public string Reception_passowrd { set { reception_passowrd = value; } get { return reception_passowrd; } }
       /* public static string dbconn()
        {
            string dbconnect = "datasource=localhost; username=root; password=; database = OOP";

            return dbconnect;
        }*/
       public Receptionist(string a)
        {
            this.Reception_passowrd = a;
        }
    }
}
