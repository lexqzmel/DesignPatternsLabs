using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сart
{
    public class DeleteCommand : ICommand
    {
        private CartProduct product;
        public DeleteCommand(CartProduct prod)
        {
            product = prod;
        }
        public void Execute()
        {
            product.Delete();
        }
    }
}
