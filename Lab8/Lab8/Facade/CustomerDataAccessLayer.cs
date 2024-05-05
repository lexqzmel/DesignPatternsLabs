using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Facade
{
    public class CustomerDataAccessLayer
    {
        public bool SaveCustomer(Customer customer)
        {
            // Зберегти клієнта в базі даних
            Console.WriteLine("\nКлієнт збережений в базі даних...");
            return true;
        }
    }
}
