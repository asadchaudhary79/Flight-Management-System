using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End
{
    class Ticket
    {
        
        //properties

        protected string Ticket_no;
        public string ticket_no { set { Ticket_no = value; } get { return Ticket_no; } }

        protected string Ticket_type;
        public string ticket_type { set { Ticket_type = value; } get { return Ticket_type; } }

        protected string Payment;
        public string payment { set{Payment=value;} get{return Payment;} }
        protected int No_of_Passengers;
        public int no_of_passengers { set { No_of_Passengers = value; } get { return No_of_Passengers; } }

        public Ticket()
        {
            this.ticket_no = "10392";
            this.ticket_type = "Economy";
            this.payment = "Cash";
            this.no_of_passengers = 2;
        }
    
    }
}
