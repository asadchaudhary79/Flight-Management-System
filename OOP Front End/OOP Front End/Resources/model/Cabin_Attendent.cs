using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Front_End
{
    public class Cabin_Attendent:Person
    {
       // CA_Front_End CA1 = new CA_Front_End();       
        protected string shift_CA;
        public string shift_ca { set { shift_CA = value; } get { return shift_CA; } }

         public Cabin_Attendent(string a)
        {
            this.name = "Asad";
            this.id = "021";
            this.gender = "Male";
            this.address = "Lahore";
            this.age = 23;
            this.Contact_info = 03328884184;
            this.Cnic = "3110374364809";
            this.shift_ca = "Morning";
        }

      /*  public void add_ca()
         {
             this.name = CA1.textBoxcaname.Text;
             this.address = CA1.textBoxcaaddress.Text;
             this.gender = CA1.comboboxcamalefemale.Text;
             this.Contact_info = long.Parse( CA1.textBoxcacionfo.Text);
             this.Cnic = long.Parse(CA1.textBoxcacnic.Text);
             this.shift_ca = CA1.comboBoxcashift.Text;
             this.age = int.Parse(CA1.textBoxcaage.Text);
         } */
    }
}
