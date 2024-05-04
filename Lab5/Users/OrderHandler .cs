using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Users
{
    public class OrderHandler : RequestHandler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Type == RequestType.Order)
            {
                // Обробляємо запит
                Console.WriteLine("Order processed.");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
