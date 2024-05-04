using System;
using Lab7.Patern;

namespace Lab7
{
    class Program
    {
        static void Main()
        {
            // Створюємо замовлення та додаємо товари
            var order = new Order();
            order.Products.Add(new Product("Product 1", 10.0));
            order.Products.Add(new Product("Product 2", 20.0));
            order.Products.Add(new Product("Product 3", 15.0));

            // Створюємо відвідувача
            var visitor = new SalesReportVisitor();

            // Виконуємо відвідування для замовлення
            order.Accept(visitor);

            // Генеруємо звіт
            visitor.GenerateReport();

            // Приклад використання патерна "Memento"

            var product = new Product("Example Product", 100.0);
            Console.WriteLine(product); // Product: Example Product, Price: 100

            Console.WriteLine("Promotion in the store");
            var caretaker = new Caretaker();
            caretaker.Backup(product);

            product.Price = 80.0; // Зміна ціни після акції
            Console.WriteLine(product); // Product: Example Product, Price: 80

            Console.WriteLine("The promotion in the store has ended");
            caretaker.Restore(product);
            Console.WriteLine(product); // Product: Example Product, Price: 100
        }
    }

}
