
using PillShop.Classes.Payment;
using PillShop.Classes;

using System;
using System.Collections.Generic;
using PillShop.Classes.Payment.FactoryDesignPattern;
using PillShop.Classes.Delivery;

namespace PillStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо перелік доступних таблеток
            List<Pill> pills = new List<Pill>()
            {
                new Pill("Вітамін А", "Фіто Фарма КО", 100.50),
                new Pill("Вітамін С", "21st Centry Health Care Inc", 75.25),
                new Pill("Вітамін B", "BioTech USA", 50.75),
            };

            // Виводимо на екран перелік доступних таблеток
            Console.WriteLine("Avaible pills:");
            foreach (Pill pill in pills)
            {
                Console.WriteLine("{0} ({1}) - {2}$", Pill.Title, Pill.Producer, Pill.Price);
            }

            // Покупець обирає таблетку та вводить інформацію про спосіб оплати
            Console.WriteLine("\nChoose pills (enter number):");
            int selectedPillIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Choose payment method:");
            Console.WriteLine("1. Credit card");
            Console.WriteLine("2. PayPal");
            Console.WriteLine("3. Bank transfer");

            int selectedPaymentMethodIndex = int.Parse(Console.ReadLine());

            // Створюємо об'єкт ліків, яку купують
            Pill selectedPill = Pills[selectedPillIndex];

            // Створюємо об'єкт способу оплати, використовуючи фабричний метод
            PaymentMethod paymentMethod = PaymentMethodFactory.CreatePaymentMethod(selectedPaymentMethodIndex);


            // Оплачуємо Таблетки, використовуючи обраний спосіб оплати
            double total = selectedPill.Price;
            Console.WriteLine("\nPrice: {0}$", total);

            paymentMethod.ProcessPayment(total);

            Console.WriteLine("Pills \"{0}\" ({1}) were successfully bought!", selectedPill.Title, selectedPill.Producer);


            Console.WriteLine("Choose delivery method:");
            Console.WriteLine("1. Нова пошта");
            Console.WriteLine("2. Укрпошта");


            int selectedDeliveryIndex = int.Parse(Console.ReadLine());

            var result = DeliveryFactory.CreateDeliveryFactory(selectedDeliveryIndex);
            DeliveryFactory deliveryFactory = result.Item1;

            Delivery deliveryF = deliveryFactory.GetDelivery(result.Item2);

        }
    }
}
