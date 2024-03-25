using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сart
{
    public class CartProduct
    {
        public void Add()
        {
            Console.WriteLine("+1 Товар");
        }
        public void Subtract()
        {
            Console.WriteLine("-1 Товар");
        }
        public void Delete()
        {
            Console.WriteLine("Видалити товар");
        }
    }
}
