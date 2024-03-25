using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class OrderConfirmationCommand : Command
    {
        public OrderConfirmationCommand(Order order) : base(order)
        {
        }

        public override void Execute()
        {
            Console.WriteLine($"Підтвердження замовлення {_order.OrderId}...");
            _order.IsConfirmed = true;
        }

        public override void Undo()
        {
            Console.WriteLine($"Скасування підтвердження замовлення {_order.OrderId}...");
            _order.IsConfirmed = false;
        }
    }
}
