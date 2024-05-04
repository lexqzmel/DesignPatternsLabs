using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Shop
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, int id, double price)
        {
            Name = name;
            ID = id;
            Price = price;
        }
    }
}
