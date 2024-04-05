using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End
{
    class Passenger:Person
    {
       // Customer_Front_end c1 = new Customer_Front_end();
        protected string Passport_no;
        public string passport_no { set { Passport_no = value; } get { return Passport_no; } }
        protected string Email_address;
        public string email_address { set { Email_address = value; } get { return Email_address; } }
        protected string Luggage_carried;
        public string luggage_carried { set { Luggage_carried = value; } get { return Luggage_carried; } }

        public Passenger(string a, string b, string c)
        {
            this.name = "Asad";
            this.id = "063";
            this.gender = "Male";
            this.address = "Lahore";
            this.age = 23;
            this.Contact_info = 03458707508;
            this.Cnic = "74364809";
            this.passport_no = a;
            this.email_address = b;
            this.luggage_carried = c;
        }
        public Ticket t1 = new Ticket();
        public Passenger (Ticket obj)
        {
            t1 = obj;
        }
        public Flight_Schedule f1 = new Flight_Schedule(33,22);
        public Passenger(Flight_Schedule objects)
        {
            f1 = objects;
        }
       /* public void add_passenger()
        {
            this.name = c1.textBoxpname.Text;
            this.gender =c1.comboboxmalefemale.Text;
            this.address = c1.textBoxaddress.Text;
            this.age = int.Parse( c1.textBoxage.Text);
            this.Contact_info = int.Parse(c1.textBoxcionfo.Text);
            this.Cnic = int.Parse(c1.textBoxcnic.Text);
            this.passport_no = c1.textBoxpassport.Text;
            this.email_address = c1.textBoxemail.Text;
            this.luggage_carried = c1.textboxluggage.Text;
        } */

    }
}
