using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Orderer
{
    public class Order : IOrderState

    {
        public IOrderState OrderState { get; set; }
        public Order()
        {
            OrderState = new NewOrderState();
        }
        public void ShowInformation(int IDOrder)
        {
            OrderState.ShowInformation(IDOrder);
            if (OrderState is NewOrderState)
            {
                //OrderState = new NewOrderState();
                Console.WriteLine($"ORDER STATE Нове {OrderState.GetType().Name}");
            }
            else if (OrderState is PaidState)
            {
                //OrderState = new PaidState();
                Console.WriteLine($"ORDER STATE Оплачене {OrderState.GetType().Name}");
            }
            else if (OrderState is SentOrderState)
            {
                //OrderState = new PaidState();
                Console.WriteLine($"ORDER STATE Відправлене {OrderState.GetType().Name}");
            }
        }
        public void PayForTheOrder(int IDOrder)
        {
            OrderState.PayForTheOrder(IDOrder);
            if (OrderState is NewOrderState)
            {
                OrderState = new PaidState();
                Console.WriteLine($"ORDER STATE Ви оплатили {OrderState.GetType().Name}");
            }
            else if (OrderState is PaidState)
            {
                //OrderState = new PaidState();
                Console.WriteLine($"ORDER STATE Оплачене {OrderState.GetType().Name}");
            }
            else if (OrderState is SentOrderState)
            {
                //OrderState = new PaidState();
                Console.WriteLine($"ORDER STATE Відправлене {OrderState.GetType().Name}");
            }
        }
        public void ParcelTracking(int IDOrder)
        {
            OrderState.ShowInformation(IDOrder);
            if (OrderState is NewOrderState)
            {
                //OrderState = new NewOrderState();
                Console.WriteLine($"ORDER STATE Не оплачене {OrderState.GetType().Name}");
            }
            else if (OrderState is PaidState)
            {
                OrderState = new SentOrderState();
                Console.WriteLine($"ORDER STATE Готується до відправлення {OrderState.GetType().Name}");
            }
            else if (OrderState is SentOrderState)
            {
                //OrderState = new PaidState();
                Console.WriteLine($"ORDER STATE Відправлене {OrderState.GetType().Name}");
            }
        }
    }
}
