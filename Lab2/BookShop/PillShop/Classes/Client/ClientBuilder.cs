using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Client
{
    public class ClientBuilder : IClientBuilder
    {
        private Client client;

        public ClientBuilder()
        {
            client = new Client();
        }
        public void CreateClientBuilder()
        {
            client = new Client();
        }

        public void SetName(string name)
        {
            client.Name = name;
        }

        public void SetEmail(string email)
        {
            client.Email = email;
        }

        public void SetAddress(string address)
        {
            client.Address = address;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            client.PhoneNumber = phoneNumber;
        }

        public Client GetClient()
        {
            return client;
        }

        public void SetName()
        {
            Console.WriteLine("Enter your name");
            GetClient().Name = Console.ReadLine();
        }
        public void SetEmail()
        {
            Console.WriteLine("Enter your e-mail");
            GetClient().Email = Console.ReadLine();
        }

        public void SetAddress()
        {
            Console.WriteLine("Enter your address");
            GetClient().Address = Console.ReadLine();
        }

        public void SetPhoneNumber()
        {
            Console.WriteLine("Enter your phonenumber");
            GetClient().PhoneNumber = Console.ReadLine();
        }
    }
}
