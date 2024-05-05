using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Facade
{
    public class Email
    {
        public bool SendRegistrationEmail(Customer customer)
        {
            // Надіслати клієнту електронного листа про успішну реєстрацію
            Console.WriteLine("\nВідправлено реєстраційний лист клієнту...");
            return true;
        }
    }
}
