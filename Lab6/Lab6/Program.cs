using Lab6.Interpreter;
using Lab6.Mediator;

class Program
{
    static void Main(string[] args)
    {
        var pills = new List<Pill>
        {
            new Pill { Title = "Vitamin A", Producer = "Biotech", Price = "1000", Type = 1 },
            new Pill { Title = "Vitamin B", Producer = "Biotech", Price = "1000", Type = 1 },
            new Pill { Title = "Vitamin D", Producer = "Biotech", Price = "1000", Type = 1 },
            new Pill { Title = "Valeriana", Producer = "Sopharma", Price = "100", Type = 3 },
            new Pill { Title = "Carvalol", Producer = "Farmak", Price = "100", Type = 3 }
        };

        var context = new Context(pills);

        // Execute a query to find all pills with "Valeriana" in the title
        var query1 = "title: Valeriana";
        var result1 = context.ExecuteQuery(query1);
        Console.WriteLine($"Results for query '{query1}':");
        PrintResults(result1);

        // Execute a query to find all pills by Sopharma Austen or Farmak
        var query2 = "producer: Sopharma OR producer: Farmak";
        var result2 = context.ExecuteQuery(query2);
        Console.WriteLine($"Results for query '{query2}':");
        PrintResults(result2);

        // Execute a query to find all pills in the 1000 price and type 1(vitamins)
        var query3 = "price: 1000 AND type: 1";
        var result3 = context.ExecuteQuery(query3);
        Console.WriteLine($"Results for query '{query3}':");
        PrintResults(result3);

        // Створюємо об'єкти класів
        var mediator = new Mediator();
        var cart = new Cart(mediator);
        var creditCardPayment = new CreditCardPayment();
        var payPalPayment = new PayPalPayment();

        mediator.AddPayment(creditCardPayment);

        // Додаємо товари до корзини
        cart.AddProduct(new Product { Id = 1, Name = "Product 1", Price = 10 });
        cart.AddProduct(new Product { Id = 2, Name = "Product 2", Price = 20 });
        cart.AddProduct(new Product { Id = 3, Name = "Product 3", Price = 30 });

        // Оформляємо замовлення з платежем кредитною карткою
        cart.PlaceOrder(creditCardPayment);
    }

    static void PrintResults(List<Pill> pills)
    {
        foreach (var pill in pills)
        {
            Console.WriteLine($"- {pill.Title} by {pill.Producer}, {pill.Price}, {pill.Type}");
        }
        Console.WriteLine();
    }


}

