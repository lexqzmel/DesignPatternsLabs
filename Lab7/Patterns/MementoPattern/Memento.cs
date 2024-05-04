using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.Patern
{
    // Клас, що представляє Memento
    class Memento
    {
        public double Price { get; }

        public Memento(double price)
        {
            Price = price;
        }
    }
}
