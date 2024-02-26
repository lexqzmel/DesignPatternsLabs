using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Delivery
{
    public class BranchDelivery : Delivery
    {
        private double _price;
        private string _numberBranch;
        private string _city;

        public BranchDelivery(string numberBranch, string city)
        {
            _numberBranch = numberBranch;
            _city = city;
        }
        public BranchDelivery(double price)
        {
            _price = price;
            Console.WriteLine("Введіть відділення для доставки");
            _numberBranch = Console.ReadLine();
            Console.WriteLine("Enter your city");
            _city = Console.ReadLine();
        }
        public override void Deliver()
        {
            Console.WriteLine($"Delivering by UkrPoshta to branch {_numberBranch}, {_city}");
        }
    }
}
