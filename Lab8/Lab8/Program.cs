using System;
using Lab8.Facade;
using Lab8.Proxy;
using Lab8.Bridge;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створити екземпляр класу Customer
            Customer customer = new Customer()
            {
                Name = "Іван",
                Email = "ivan@gmail.com",
                MobileNumber = "9876543210",
                Address = "Київ, Україна"
            };
            // Використання класу-фасада
            CustomerRegistration customerRegistration = new CustomerRegistration();
            customerRegistration.RegisterCustomer(customer);



            // Створення проксі для завантаження зображень
            IImageLoader imageLoader = new ImageLoaderProxy("http://example.com/image.jpg");

            // При першому виклику буде завантажено і відображено зображення
            imageLoader.DisplayImage();

            // При наступних викликах буде відображено зображення з кешу
            imageLoader.DisplayImage();




            // Створення об'єкту контактного центру
            ContactCenter emailContactCenter = new EmailContactCenter();

            // Створення об'єкту клієнта
            //Customer customers = new Customer();

            // Встановлення контактного центру для клієнта
            customer.SetContactCenter(emailContactCenter);

            // Клієнт контактує з контактним центром
            customer.ContactCustomerSupport();

            // Виклик методів специфічних для EmailContactCenter
            EmailContactCenter emailCenter = (EmailContactCenter)emailContactCenter;
            emailCenter.SendEmail();
            emailCenter.ReceiveEmail();

            // Створення об'єкту іншого контактного центру
            ContactCenter phoneContactCenter = new PhoneContactCenter();
            customer.SetContactCenter(phoneContactCenter);
            customer.ContactCustomerSupport();

            // Виклик методів специфічних для PhoneContactCenter
            PhoneContactCenter phoneCenter = (PhoneContactCenter)phoneContactCenter;
            phoneCenter.MakeCall();
            phoneCenter.ReceiveCall();


            Console.ReadKey();
        }
    }
}