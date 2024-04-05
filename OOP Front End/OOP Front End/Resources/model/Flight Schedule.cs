using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End
{
    class Flight_Schedule
    {
      
        protected string date_sch;
        public string Date_sch { set { date_sch = value; } get { return date_sch; } }
        protected string Flight_name;
        public string flight_name { set { Flight_name = value; } get { return Flight_name; } }

        protected string flight_arrival;
        public string Flight_arrival { set { flight_arrival = value; } get { return flight_arrival; } }
        protected int flight_capacity;
        public int Flight_capacity { set { flight_capacity = value; } get { return flight_capacity; } }
        protected int booked;
        public int Booked { set { booked = value; } get { return booked; } }

        public Flight_Schedule(int c, int d)
        {
         
            this.Flight_capacity = c;
            this.Booked = d;
        }
        public void add_flight()
        {
           
        }
    }
}
