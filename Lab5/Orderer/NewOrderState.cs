using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Orderer
{
    public class NewOrderState : IOrderState

    {
        public void ShowInformation(int orderID)
        {
            Console.WriteLine($" {orderID} Нове");
        }
        public void PayForTheOrder(int orderID)
        {
            Console.WriteLine($" {orderID} Ви оплатили замовлення");
        }
        public void ParcelTracking(int orderID)
        {
            Console.WriteLine($" {orderID} Замовлення нове і не оплачене");
        }

    }
}
