using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Payment
{
    public class BankTransferPayment : PaymentMethod
    {
        private string _accountNumber;
        private string _bankName;

        public BankTransferPayment(string accountNumber, string bankName)
        {
            _accountNumber = accountNumber;
            _bankName = bankName;
        }

        public BankTransferPayment()
        {
            Console.WriteLine("Введіть номербанківського рахунку:");
            _accountNumber = Console.ReadLine();
            Console.WriteLine("Введіть назву банку:");
            _bankName = Console.ReadLine();
        }

        public override void ProcessPayment(double amount)
        {
            // Логіка оплати банківським переказом
            Console.WriteLine($"Оплачено {amount:C} банківським переказом на рахунок {_accountNumber} з кодом банку {_bankName}");
        }
    }
}
