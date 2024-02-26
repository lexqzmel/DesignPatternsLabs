using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Payment.FactoryDesignPattern
{
    public static class PaymentMethodFactory
    {
        public static PaymentMethod CreatePaymentMethod(string type, string[] args)
        {
            switch (type)
            {
                case "CreditCard":
                    string cardNumber = args[0];
                    string expirationDate = args[1];
                    string cvv = args[2];
                    return new CreditCardPayment(cardNumber, expirationDate, cvv);

                case "PayPal":
                    return new PayPalPayment();

                case "BankTransfer":
                    string accountNumber = args[0];
                    string bankCode = args[1];
                    return new BankTransferPayment(accountNumber, bankCode);

                default:
                    throw new ArgumentException("Unknown delivery type");
            }
        }

        public static PaymentMethod CreatePaymentMethod(int type)
        {
            switch (type)
            {
                case 1:

                    return new CreditCardPayment();

                case 2:
                    return new PayPalPayment();

                case 3:
                    return new BankTransferPayment();

                default:
                    throw new ArgumentException("Unknown delivery type");
            }
        }
    }
}
