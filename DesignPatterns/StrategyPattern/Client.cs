using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class Client
    {
        public Client()
        {
            PaymentService service = new PaymentService();

            PaymentMethod cc = new CreditCard();
            service.SetPrice(1000);
            service.ProcessOrder(cc);
            PaymentMethod pp = new PayPal();
            service.SetPrice(3000);
            service.ProcessOrder(pp);
        }
    }
}
