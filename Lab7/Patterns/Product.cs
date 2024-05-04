using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.Patern
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Метод для створення Memento, що зберігає стан товару
        public Memento CreateMemento()
        {
            return new Memento(Price);
        }

        // Метод для відновлення стану товару з Memento
        public void RestoreMemento(Memento memento)
        {
            Price = memento.Price;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price}";
        }
    }

}
