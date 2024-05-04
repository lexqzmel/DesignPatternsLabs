using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.Patern
{
    // Клас відвідувача для генерації звіту про продажі
    class SalesReportVisitor : IVisitor
    {
        private decimal totalSales;
        private Dictionary<string, int> popularProducts;
        private int totalUnitsSold;

        public SalesReportVisitor()
        {
            totalSales = 0;
            popularProducts = new Dictionary<string, int>();
            totalUnitsSold = 0;
        }

        public void Visit(Order order)
        {
            foreach (var product in order.Products)
            {
                totalSales += (decimal)product.Price;

                if (popularProducts.ContainsKey(product.Name))
                    popularProducts[product.Name] += 1;
                else
                    popularProducts.Add(product.Name, 1);

                totalUnitsSold += 1;
            }
        }

        public void GenerateReport()
        {
            Console.WriteLine("Sales Report:");
            Console.WriteLine("Total Sales: $" + totalSales);
            Console.WriteLine("Popular Products:");

            foreach (var product in popularProducts)
            {
                Console.WriteLine(product.Key + ": " + product.Value + " units");
            }

            Console.WriteLine("Total Units Sold: " + totalUnitsSold);
        }
    }

}
