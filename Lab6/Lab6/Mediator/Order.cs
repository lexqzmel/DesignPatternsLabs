using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Mediator
{
    class Order
    {
        public List<Product> Products { get; set; }
        public string PaymentMethod { get; set; }

        public decimal TotalAmount
        {
            get { return Products.Sum(p => p.Price); }
        }
    }
}
