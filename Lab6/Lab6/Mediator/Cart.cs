using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Mediator
{
    class Cart
    {
        private Mediator _mediator;
        private List<Product> _products = new List<Product>();

        public Cart(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
            Console.WriteLine($"Added {product.Name} to cart.");
        }

        public void PlaceOrder(IPayment payment)
        {
            var order = new Order
            {
                Products = _products,
                PaymentMethod = "CreditCard" // В дійсності це значення має бути встановлене користувачем
            };

            _mediator.MakePayment(order);
        }
    }
}
