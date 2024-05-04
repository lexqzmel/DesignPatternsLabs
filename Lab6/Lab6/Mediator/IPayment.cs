using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Mediator
{
    interface IPayment
    {
        bool CanProcessPayment(string paymentMethod);
        void ProcessPayment(Order order);
    }

}
