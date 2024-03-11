using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Delivery
{
    public class PostomatDelivery : Delivery
    {
        private double _price;
        private string _numberPostomat;
        private string _city;

        public PostomatDelivery(string numberPostomat, string city)
        {
            _numberPostomat = numberPostomat;
            _city = city;
        }
        public PostomatDelivery(double price)
        {
            _price = price;
            Console.WriteLine("Enter your city");
            _city = Console.ReadLine();
            Console.WriteLine("Enter postomat number");
            _numberPostomat = Console.ReadLine();
        }

        public override void Deliver()
        {
            Console.WriteLine($"Delivering by UkrPoshta to branch {_numberPostomat}, {_city}");
        }
    }
}
