using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Client
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public string ShowBeverage()
        {
            return "Name " + Name + "\nEmail " + Email + "\nAddress " + Address + "\nPhoneNumber " + PhoneNumber + "\n";
        }

    }

}