using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Bridge
{
    // Конкретний підклас EmailContactCenter
    public class EmailContactCenter : ContactCenter
    {
        public override void SendRequest()
        {
            Console.WriteLine("Sending email request");
        }

        public override void ReceiveResponse()
        {
            Console.WriteLine("Receiving email response");
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending email");
        }

        public void ReceiveEmail()
        {
            Console.WriteLine("Receiving email");
        }
    }
}
