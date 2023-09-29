using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class PaymentService
    {
        private int price;
        public void ProcessOrder(PaymentMethod method)
        {
            if(method.Validate())
            {
                method.Pay(price);
            }
        }
        public void SetPrice(int p)
        {
            price = p;
        }
    }
}
