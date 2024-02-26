using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes
{
    public class Pill
    {
        public string Title { get; set; }  // Назва
        public string Producer { get; set; } // Виробник
        public double Price { get; set; } // Ціна

        public Pill(string title, string producer, double price)
        {
            Title = title;
            Producer = producer;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Title} by {Producer} - {Price:C}";
        }
    }
}
