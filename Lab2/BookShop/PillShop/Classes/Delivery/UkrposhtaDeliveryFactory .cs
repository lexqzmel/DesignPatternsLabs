using PillShop.Classes.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Delivery
{
    public class UkrposhtaDeliveryFactory : DeliveryFactory
    {
        public override Delivery GetDelivery(string deliveryType, string[] args)
        {
            switch (deliveryType)
            {
                case "BranchDelivery":

                    string numberBranch = args[0];
                    string city = args[1];

                    return new BranchDelivery(numberBranch, city);

                case "CourierDelivery":

                    string address = args[0];
                    string cityCourier = args[1];
                    return new CourierDelivery(address, cityCourier);
                default:
                    throw new ArgumentException("Unknown delivery type");
            }
        }

        public override Delivery GetDelivery(int deliveryType)
        {
            switch (deliveryType)
            {
                case 1:
                    double priceBranch = 50;
                    Console.WriteLine("\nPrice: {0}$", priceBranch);
                    return new BranchDelivery(priceBranch);

                case 2:
                    double priceCourier = 80;
                    Console.WriteLine("\nPrice: {0}$", priceCourier);
                    return new CourierDelivery(priceCourier);

                default:
                    throw new ArgumentException("Unknown delivery type");
            }
        }
    }
}
