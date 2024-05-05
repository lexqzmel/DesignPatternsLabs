using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Bridge
{
    // Конкретний підклас PhoneContactCenter
    public class PhoneContactCenter : ContactCenter
    {
        public override void SendRequest()
        {
            Console.WriteLine("Making phone call request");
        }

        public override void ReceiveResponse()
        {
            Console.WriteLine("Receiving phone call response");
        }

        public void MakeCall()
        {
            Console.WriteLine("Making phone call");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Receiving phone call");
        }
    }
}
