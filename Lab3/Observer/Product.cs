using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Product : IProduct
    {
        private List<IObserver> observers = new List<IObserver>();
        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string Availability { get; set; }
        public Product(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string getAvailability()
        {
            return Availability;
        }
        public void setAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Наявність продукту змінено з «Немає в наявності» на «Доступно»");
            NotifyObservers();
        }
        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Ви тепер стежите за товаром : " + ((Observer)observer).UserName);
            observers.Add(observer);
        }
        public void AddObservers(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            Console.WriteLine("Назва товару :"
                            + ProductName + ", Ціна продукту : "
                            + ProductPrice + " тепер доступний. Повідомляємо всіх зареєстрованих користувачів ");
            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                observer.update(Availability);
            }
        }
    }
}
