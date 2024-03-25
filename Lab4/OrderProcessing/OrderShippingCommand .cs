using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class OrderShippingCommand : Command
    {
        public OrderShippingCommand(Order order) : base(order)
        {
        }

        public override void Execute()
        {
            Console.WriteLine($"Відправлення замовлення {_order.OrderId} до клієнта...");
            _order.IsShipped = true;
        }

        public override void Undo()
        {
            Console.WriteLine($"Скасування відправлення замовлення {_order.OrderId} до клієнта...");
            _order.IsShipped = false;
        }
    }
}
