using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Mediator
{
    class Mediator
    {
        private List<IPayment> _payments = new List<IPayment>();

        public void AddPayment(IPayment payment)
        {
            _payments.Add(payment);
        }

        public void MakePayment(Order order)
        {
            foreach (var payment in _payments)
            {
                if (payment.CanProcessPayment(order.PaymentMethod))
                {
                    payment.ProcessPayment(order);
                    Console.WriteLine("Payment processed successfully.");
                    return;
                }
            }

            Console.WriteLine("Unable to process payment. Please choose a different payment method.");
        }
    }
}
