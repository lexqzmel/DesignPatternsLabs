using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public abstract class Command
    {
        protected Order _order;

        public Command(Order order)
        {
            _order = order;
        }

        public abstract void Execute();

        public abstract void Undo();
    }
}
