
using LoyaltyProgram;
using OrderProcessing;
using System;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace StrategyDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення клієнта і програми лояльності
            Customer customer = new Customer();
            LoyaltyProgramTemplate loyaltyProgram = new PremiumVersionLoyalty();

            // Виконання дій покупця, які можуть призвести до нагородження
            customer.MakePurchase(1500);
            customer.ReferFriend();

            // Нагородження покупця згідно з програмою лояльності
            loyaltyProgram.RewardCustomer(customer);

            // Виведення інформації про нагороди покупця
            Console.WriteLine("Customer rewards:");
            Console.WriteLine("Discount: {0:C}", customer.Discount);
            Console.WriteLine("Points: {0}", customer.Points);


            // Приклад використання
            Order order = new Order() { OrderId = 123 };
            MacroCommands macroCommands = new MacroCommands();
            //PaymentCheckCommand(order);
            macroCommands.AddCommand(new OrderConfirmationCommand(order));
            macroCommands.AddCommand(new OrderShippingCommand(order));
            macroCommands.ExecuteCommands();

            // Скасування команд
            macroCommands.UndoCommands();

            //Створення замовлення:
            Order orders = new Order { OrderId = 1 };
            Console.WriteLine("Замовлення створено.");
            //Перевірка оплати:
            Command paymentCheckCommand = new PaymentCheckCommand(orders);
            MacroCommands macroCommandss = new MacroCommands();
            macroCommandss.AddCommand(paymentCheckCommand);
            macroCommandss.ExecuteCommands();

            //Підтвердження замовлення:
            Command orderConfirmationCommand = new OrderConfirmationCommand(orders);
            macroCommandss.AddCommand(orderConfirmationCommand);
            macroCommandss.ExecuteCommands();

            //Відправлення замовлення до клієнта:///
            Command orderShippingCommand = new OrderShippingCommand(orders);
            macroCommandss.AddCommand(orderShippingCommand);
            macroCommandss.ExecuteCommands();

            //Скасування останньої команди (відправлення замовлення):
            macroCommandss.UndoCommands();

            //Скасування всіх команд:
            macroCommandss.UndoCommands();



            Console.ReadLine();
        }
    }
}