using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    public class PaymentS
    {
        private IPaymentStrategy PaymentStrategy;
        // The user will set the PaymentStrategy by 
        // calling this method at runtime
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            this.PaymentStrategy = strategy;
        }
        public void Pay(double amount)
        {
            PaymentStrategy.Pay(amount);
        }
    }
}
