using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyaltyProgram
{
    class EverydayVersionLoyalty : LoyaltyProgramTemplate
    {
        protected override void GiveDiscount(Customer customer, double amount)
        {
            // Віддати покупцеві знижку на наступну покупку
            customer.Discount += amount / 2;
        }

        protected override void GiveFreeItem(Customer customer)
        {
            // Не надавати безкоштовний товар звичайним покупцям
        }

        protected override void GivePoints(Customer customer, int points)
        {
            // Додати покупцеві бонусні бали
            customer.Points += points / 2;
        }
    }
}
