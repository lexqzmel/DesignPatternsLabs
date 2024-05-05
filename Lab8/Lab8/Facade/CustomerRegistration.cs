using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Facade
{
    public class CustomerRegistration
    {
        public bool RegisterCustomer(Customer customer)
        {
            // Крок 1: Перевірка клієнта
            Validator validator = new Validator();
            bool IsValid = validator.ValidateCustomer(customer);
            // Крок 2: Зберегти об'єкт клієнта в базі даних
            CustomerDataAccessLayer customerDataAccessLayer = new CustomerDataAccessLayer();
            bool IsSaved = customerDataAccessLayer.SaveCustomer(customer);
            // Крок 3: Відправити реєстраційний лист клієнту
            Email email = new Email();
            email.SendRegistrationEmail(customer);
            return true;
        }
    }
}
