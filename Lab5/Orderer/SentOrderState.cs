using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Orderer
{
    internal class SentOrderState : IOrderState
    {
        public void ShowInformation(int orderID)
        {
            Console.WriteLine($" {orderID} Відправлене");
        }
        public void PayForTheOrder(int orderID)
        {
            Console.WriteLine($" {orderID} Замовлення оплачено");
        }
        public void ParcelTracking(int orderID)
        {
            Console.WriteLine($" {orderID} Замовлення відправлене");
        }
    }
}
