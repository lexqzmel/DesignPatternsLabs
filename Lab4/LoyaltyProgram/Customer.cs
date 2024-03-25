using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyaltyProgram
{
    public class Customer
    {
        public double TotalPurchases { get; set; }
        public int ReferralCount { get; set; }
        public double Discount { get; set; }
        public int Points { get; set; }

        public void MakePurchase(double amount)
        {
            TotalPurchases += amount;
        }

        public void ReferFriend()
        {
            ReferralCount++;
        }

        public void AddFreeItem()
        {
            // Додати безкоштовний товар в кошик покупця
        }

    }
}
