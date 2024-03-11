using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Payment
{
    public class PayPalPayment : PaymentMethod
    {

        public PayPalPayment()
        {
            Console.WriteLine("Зачекайте, Вас буде перенаправлено на сайт PayPal...");
        }

        public override void ProcessPayment(double amount)
        {
            // Логіка оплати через PayPal
            Console.WriteLine($"Оплачено {amount:C} через PayPal з електронною поштою");
        }
    }
}
