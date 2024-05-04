using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Mediator
{
    class CreditCardPayment : IPayment
    {
        public bool CanProcessPayment(string paymentMethod)
        {
            return paymentMethod == "CreditCard";
        }

        public void ProcessPayment(Order order)
        {
            Console.WriteLine($"Processing credit card payment for ${order.TotalAmount}");
            // Логіка оплати кредитною карткою
        }
    }
}
