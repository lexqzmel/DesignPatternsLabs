using Observer;
using Payment;
using Сart;
using System;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace StrategyDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////
            //Strategy Pattern
            Console.WriteLine("Будь ласка, виберіть тип платежу: кредитна картка або готівка");
            string PaymentType = Console.ReadLine();
            Console.WriteLine("Тип платежу : " + PaymentType);
            double Amount = 1000;
            Console.WriteLine("Сума : " + Amount);

            PaymentS context = new PaymentS();

            if ("CreditCard".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
            {
                context.SetPaymentStrategy(new CreditCard());
            }
            else if ("Cash".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
            {
                context.SetPaymentStrategy(new Cash());
            }
            context.Pay(Amount);



            /////////////////////////////////////////
            //Command Pattern
            CartProduct document = new CartProduct();
            ICommand addCommand = new AddCommand(document);
            ICommand subtractCommand = new SubtractCommand(document);
            ICommand deleteCommand = new DeleteCommand(document);
            CartProductOption menu = new CartProductOption(addCommand, subtractCommand, deleteCommand);
            menu.clickAdd();
            menu.clickSubtract();
            menu.clickDelete();


            ///////////////////////////////////////////
            // Observer  Pattern
            Product pill = new Product("Vitamin K", 10000, "Немає в наявності");
            //Буде створено користувача ANNET, а об’єкт user1 буде зареєстровано для суб’єкта
            Observer user1 = new Observer("Vitamin C", pill);

            Observer user2 = new Observer("Vitamin D", pill);
            Observer user3 = new Observer("Vitamin E", pill);

            Console.WriteLine("Поточний стан : " + pill.getAvailability());
            Console.WriteLine();
            // Зараз товар доступний
            pill.setAvailability("Доступно");
            Console.Read();

            Console.ReadKey();
        }
    }
}
