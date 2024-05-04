using Lab5.Shop;
using Lab5.Orderer;
using Lab5.Users;
using System.Net;

public class Program
{
    static void Main()
    {
        // Build a collection
        ProductList collection = new ProductList();
        collection.AddProduct(new Product("Vitamin A", 1, 1001));
        collection.AddProduct(new Product("Vitamin B", 2, 1001));
        collection.AddProduct(new Product("Vitamin C", 3, 1001));
        collection.AddProduct(new Product("Vitamin D", 4, 1001));
        collection.AddProduct(new Product("Vitamin K", 5, 1001));
        collection.AddProduct(new Product("Vitamin E", 6, 1001));

        // Create iterator
        Iterator iterator = collection.CreateIterator();

        int count = collection.Count;
        Console.WriteLine($"Number of products in the collection: {count}\n");

        Product thirdProduct = collection.GetProduct(2);
        Console.WriteLine($"Third product in the collection: ID : {thirdProduct.ID} Name : {thirdProduct.Name} Price: {thirdProduct.Price}\n");

        //looping iterator      
        Console.WriteLine("Iterating over collection:");

        for (Product book = iterator.First(); !iterator.IsCompleted; book = iterator.Next())
        {
            Console.WriteLine($"ID : {book.ID} Name : {book.Name} Price: {book.Price}");
        }
        Console.Read();


        Order order = new Order();
        Console.WriteLine($"Current Order State : {order.OrderState.GetType().Name}\n");
        order.ShowInformation(505);
        order.ParcelTracking(505);
        order.PayForTheOrder(505);
        Console.WriteLine($"\nCurrent Order State : {order.OrderState.GetType().Name}\n");
        order.ShowInformation(505);
        order.PayForTheOrder(505);
        order.ParcelTracking(505);
        Console.WriteLine($"\nCurrent Order State : {order.OrderState.GetType().Name}");
        order.ShowInformation(505);
        order.PayForTheOrder(505);
        order.ParcelTracking(505);
        Console.WriteLine($"\nCurrent Order State : {order.OrderState.GetType().Name}");
        Console.Read();


        // Використання паттерну
        var paymentHandler = new PaymentHandler();
        var orderHandler = new OrderHandler();
        var shippingHandler = new ShippingHandler();

        paymentHandler.SetNextHandler(orderHandler);
        orderHandler.SetNextHandler(shippingHandler);

        var client = new Client(paymentHandler);

        // Відправка запитів
        client.SendRequest(new Request { Type = RequestType.Payment });
        client.SendRequest(new Request { Type = RequestType.Order });
        client.SendRequest(new Request { Type = RequestType.Shipping });

    }
}