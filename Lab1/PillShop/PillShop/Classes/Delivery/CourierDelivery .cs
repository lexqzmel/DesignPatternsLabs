using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Delivery
{
    public class CourierDelivery : Delivery
    {
        private double _price;
        private string _address;
        private string _city;

        public CourierDelivery(string address, string city)
        {
            _address = address;
            _city = city;
        }

        public CourierDelivery(double price)
        {
            _price = price;
            Console.WriteLine("Введіть адресу доставки");
            _address = Console.ReadLine();
            Console.WriteLine("Enter your city");
            _city = Console.ReadLine();
        }

        public override void Deliver()
        {
            Console.WriteLine($"Delivering courier to address {_address}, {_city}");
        }
    }
}
