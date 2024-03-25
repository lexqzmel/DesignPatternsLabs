using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class PaymentCheckCommand : Command
    {
        public PaymentCheckCommand(Order order) : base(order)
        {
        }

        public override void Execute()
        {
            Console.WriteLine($"Перевірка оплати замовлення {_order.OrderId}...");
            _order.IsPaid = true;
        }

        public override void Undo()
        {
            Console.WriteLine($"Скасування перевірки оплати замовлення {_order.OrderId}...");
            _order.IsPaid = false;
        }
    }
}
