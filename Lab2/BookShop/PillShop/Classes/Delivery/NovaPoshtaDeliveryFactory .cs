using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Delivery
{
    public class NovaPoshtaDeliveryFactory : DeliveryFactory
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

                case "PostomatDelivery":
                    string numberPostomat = args[0];
                    string cityPostomat = args[1];
                    return new PostomatDelivery(numberPostomat, cityPostomat);

                default:
                    throw new ArgumentException("Unknown delivery type");
            }
        }

        public override Delivery GetDelivery(int deliveryType)
        {
            switch (deliveryType)
            {
                case 1:
                    double priceBranch = 60;
                    Console.WriteLine("\nPrice: {0}$", priceBranch);
                    return new BranchDelivery(priceBranch);

                case 2:
                    double priceCourier = 100;
                    Console.WriteLine("\nPrice: {0}$", priceCourier);
                    return new CourierDelivery(priceCourier);

                case 3:
                    double pricePostomat = 50;
                    Console.WriteLine("\nPrice: {0}$", pricePostomat);
                    return new PostomatDelivery(pricePostomat);

                default:
                    throw new ArgumentException("Unknown delivery type");
            }
        }
    }
}
