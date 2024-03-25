using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyaltyProgram
{
    public abstract class LoyaltyProgramTemplate
    {
        public void RewardCustomer(Customer customer)
        {
            if (customer.TotalPurchases > 1000)
            {
                GiveDiscount(customer, 10);
            }

            if (customer.ReferralCount > 5)
            {
                GiveFreeItem(customer);
            }

            GivePoints(customer, 100);
            Console.WriteLine("Нараховані балли");
        }

        protected abstract void GiveDiscount(Customer customer, double amount);
        protected abstract void GiveFreeItem(Customer customer);
        protected abstract void GivePoints(Customer customer, int points);
    }
}
