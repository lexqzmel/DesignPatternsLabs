using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Users
{
    public class PaymentHandler : RequestHandler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Type == RequestType.Payment)
            {
                // Обробляємо запит
                Console.WriteLine("Payment processed.");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
