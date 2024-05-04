using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.Patern
{
    class Order
    {
        public List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
