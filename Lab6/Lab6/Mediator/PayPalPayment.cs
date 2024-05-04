using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Mediator
{
    class PayPalPayment : IPayment
    {
        public bool CanProcessPayment(string paymentMethod)
        {
            return paymentMethod == "PayPal";
        }

        public void ProcessPayment(Order order)
        {
            Console.WriteLine($"Processing PayPal payment for ${order.TotalAmount}");
            // Логіка оплати PayPal
        }
    }
}
