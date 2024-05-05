using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Facade
{
    public class Validator
    {
        public bool ValidateCustomer(Customer customer)
        {
            // Потрібна перевірка об'єкта Customer
            Console.WriteLine("Клієнт перевірений...");
            Console.WriteLine($"Ім'я: {customer.Name}");
            Console.WriteLine($"Електронна пошта: {customer.Email}");
            Console.WriteLine($"Мобільний номер: {customer.MobileNumber}");
            Console.WriteLine($"Адреса: {customer.Address}");
            return true;
        }
    }
}
