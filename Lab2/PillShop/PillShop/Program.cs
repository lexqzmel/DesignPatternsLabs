
using PillShop.Classes.Payment;
using PillShop.Classes;

using System;
using System.Collections.Generic;
using PillShop.Classes.Payment.FactoryDesignPattern;
using PillShop.Classes.Delivery;
using PillShop.Classes.Client;
using PillShop.Classes.Pill;

namespace PillStore
{
    class Program
    {

        static void Main(string[] args)
        {
            //Патерн Будівельник
            Client client1;
            ClientDirector clientDirector = new ClientDirector();

            ClientBuilder cl = new ClientBuilder();
            client1 = clientDirector.MakeClient(cl);
            Console.WriteLine(client1.ShowBeverage());

            Console.WriteLine("New client:");

            var clientBuilder = new ClientBuilder();
            clientBuilder.SetName("Mario");
            clientBuilder.SetEmail("mariomario@gmail.com");
            clientBuilder.SetAddress("2 Pipe street");
            clientBuilder.SetPhoneNumber("4321-1234");
            var client = clientBuilder.GetClient();
            Console.WriteLine(client.ShowBeverage());

            //////////////////////////////////////////////

            // Створюємо перелік доступних таблеток
            List<PillPrototype> PillLIST = new List<PillPrototype>()
            {
                new Pill("Вітамін А", "Фіто Фарма КО", 100.50),
                new Pill("Вітамін С", "21st Centry Health Care Inc", 75.25),
                new Pill("Вітамін B", "BioTech USA", 50.75),
            };

            PillPrototype emp4 = PillLIST[2].Clone();

            // Виводимо на екран перелік доступних таблеток
            Console.WriteLine("Avaible pills:");
            foreach (Pill Pill in PillLIST)
            {
                Console.WriteLine("{0} ({1}) - {2}$ {3}", Pill.title, Pill.Producer, Pill.price, Pill.count);
            }

            // Покупець обирає таблетку та вводить інформацію про спосіб оплати
            Console.WriteLine("\nChoose pills (enter number):");
            int selectedPillIndex = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("\nChoose number of pills packs");
            int selPillCount = int.Parse(Console.ReadLine()) - 1;

            PillPrototype selectedPill = PillLIST[selectedPillIndex].Clone();

            PillLIST[selectedPillIndex].count = PillLIST[selectedPillIndex].count - selPillCount - 1;

            Console.WriteLine("Pills \"{0}\" ({1}) were successfully bought!", selectedPill.title, selectedPill.Producer);


            Console.WriteLine("Avaible pills:");
            foreach (Pill Pill in PillLIST)
            {
                Console.WriteLine("{0} ({1}) - {2}$ {3}", Pill.title, Pill.Producer, Pill.price, Pill.count);
            }

        }
    }
}
