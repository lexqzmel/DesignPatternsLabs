using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Bridge
{
    // Абстрактний клас ContactCenter
    public abstract class ContactCenter
    {
        public abstract void SendRequest();
        public abstract void ReceiveResponse();
    }
}
