using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Users
{
    public class Client
    {
        private RequestHandler _handler;

        public Client(RequestHandler handler)
        {
            _handler = handler;
        }

        public void SendRequest(Request request)
        {
            _handler.HandleRequest(request);
        }
    }
}
