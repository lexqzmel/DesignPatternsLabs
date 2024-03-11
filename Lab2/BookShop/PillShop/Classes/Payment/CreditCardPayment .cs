using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Payment
{
    public class CreditCardPayment : PaymentMethod
    {
        private string _cardNumber;
        private string _expirationDate;
        private string _cvv;


        public CreditCardPayment(string cardNumber, string expirationDate, string cvv)
        {
            _cardNumber = cardNumber;
            _expirationDate = expirationDate;
            _cvv = cvv;
        }

        public CreditCardPayment()
        {
            Console.WriteLine("1. Введіть номер кредитної картки:");
            _cardNumber = Console.ReadLine();
            Console.WriteLine("2. Введіть дату закінчення терміну дії кредитної картки (у форматі MM/YY):");
            _expirationDate = Console.ReadLine();
            Console.WriteLine("3. Введіть CVV-код кредитної картки:");
            _cvv = Console.ReadLine();

        }

        public override void ProcessPayment(double amount)
        {
            // Логіка оплати кредитною карткою
            Console.WriteLine($"Оплачено {amount:C} з використанням кредитної картки {_cardNumber}");
        }


    }

}
