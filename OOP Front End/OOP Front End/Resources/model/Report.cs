using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End
{
    class Report
    {
        protected int total_passengers;
        public int Total_passengers { get { return total_passengers; } set { total_passengers = value; } }
        protected int total_earning;
        public int Total_earning { get { return total_earning; } set { total_earning = value; } }       
        //functions
        public void daily_report()
        {

        }
        public void weekly_report()
        {

        }
        public void monthly_report()
        {

        } 
    }
}
