using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab8.Bridge;

namespace Lab8.Facade
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        // Інші властивості відповідно до бізнес-вимог
        private ContactCenter contactCenter;

        public void SetContactCenter(ContactCenter contactCenter)
        {
            this.contactCenter = contactCenter;
        }

        public void ContactCustomerSupport()
        {
            contactCenter.SendRequest();
            contactCenter.ReceiveResponse();
        }
    }
}
