using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    public class Cash : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine(" Користувач здійснив оплату " + amount + " готівкою");
        }
    }
}
