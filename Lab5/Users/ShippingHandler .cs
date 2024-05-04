using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Users
{
    public class ShippingHandler : RequestHandler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Type == RequestType.Shipping)
            {
                // Обробляємо запит
                Console.WriteLine("Shipping processed.");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
