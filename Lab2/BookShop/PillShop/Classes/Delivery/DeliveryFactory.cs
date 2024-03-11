using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Delivery
{
    public abstract class DeliveryFactory
    {
        public abstract Delivery GetDelivery(string deliverType, string[] args);
        public abstract Delivery GetDelivery(int deliveryType);
        public static DeliveryFactory CreateDeliveryFactory(string FactoryType)
        {
            if (FactoryType.Equals("NovaPoshta"))
                return new NovaPoshtaDeliveryFactory();
            else
                return new UkrposhtaDeliveryFactory();
        }
        public static (DeliveryFactory, int) CreateDeliveryFactory(int FactoryType)
        {
            if (FactoryType.Equals(1))
            {
                Console.WriteLine("Choose тип доставки Нової пошти:");
                Console.WriteLine("1. Відділення");
                Console.WriteLine("2. Курєрська");
                Console.WriteLine("3. Поштомат");
                int selectedDeliveryIndex = int.Parse(Console.ReadLine());
                return (new NovaPoshtaDeliveryFactory(), selectedDeliveryIndex);
            }
            else
            {
                Console.WriteLine("Choose тип доставки Укрпошти:");
                Console.WriteLine("1. Відділення");
                Console.WriteLine("2. Курєрська");
                int selectedDeliveryIndex = int.Parse(Console.ReadLine());
                return (new UkrposhtaDeliveryFactory(), selectedDeliveryIndex);
            }
        }
    }
}
