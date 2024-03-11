using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Pill
{
    public class Pill : PillPrototype
    {
        public Pill(string Title, string Producer, double Price, double Count)
        {
            title = Title;
            producer = Producer;
            price = Price;
            count = Count;
        }
        public override PillPrototype Clone()
        {
            // Клонуємо таблетку
            return (PillPrototype)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine($" Title:{this.title}, Producer: {this.Producer}, Price: {this.price}\n");
        }
    }
}
