using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyaltyProgram
{

    class PremiumVersionLoyalty : LoyaltyProgramTemplate
    {
        protected override void GiveDiscount(Customer customer, double amount)
        {
            // Віддати покупцеві знижку на наступну покупку
            customer.Discount += amount;
        }

        protected override void GiveFreeItem(Customer customer)
        {
            // Віддати покупцеві безкоштовний товар
            customer.AddFreeItem();
        }

        protected override void GivePoints(Customer customer, int points)
        {
            // Додати покупцеві бонусні бали
            customer.Points += points;
        }
    }
}
