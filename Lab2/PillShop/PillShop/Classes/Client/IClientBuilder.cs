using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Client
{
    public interface IClientBuilder
    {
        void SetName(string name);
        void SetEmail(string email);
        void SetAddress(string address);
        void SetPhoneNumber(string phoneNumber);
        Client GetClient();


    }
}
