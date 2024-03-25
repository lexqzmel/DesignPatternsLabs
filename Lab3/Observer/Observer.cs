using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Observer : IObserver
    {
        public string UserName { get; set; }

        public Observer(string userName, IProduct product)
        {
            UserName = userName;
            product.RegisterObserver(this);
        }

        public void update(string availabiliy)
        {
            Console.WriteLine("Доброго дня,  " + UserName + ", Товар " + availabiliy + " є доступний");
        }
    }
}
