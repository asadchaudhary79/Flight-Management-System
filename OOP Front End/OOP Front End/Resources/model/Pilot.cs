using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End
{
    class Pilot:Person
    {
        protected string P_Experience;
        public string p_experience { get { return P_Experience; } set { P_Experience = value; } }
         public Pilot(string a)
        {
            this.name = "Asad";
            this.id = "063";
            this.gender = "Male";
            this.address = "Lahore";
            this.age = 23;
            this.Contact_info = 03458707508;
            this.Cnic = "311777";
            this.p_experience = "6 years";
        }
    }
}
