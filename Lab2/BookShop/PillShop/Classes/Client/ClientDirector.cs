using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillShop.Classes.Client
{
    internal class ClientDirector
    {
        public Client MakeClient(ClientBuilder clientBuilder)
        {
            clientBuilder.CreateClientBuilder();
            clientBuilder.SetName();
            clientBuilder.SetEmail();
            clientBuilder.SetAddress();
            clientBuilder.SetPhoneNumber();

            return clientBuilder.GetClient();
        }
    }
}
