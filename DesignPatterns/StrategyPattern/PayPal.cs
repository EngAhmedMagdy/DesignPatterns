using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class PayPal : PaymentMethod
    {
        public void Pay(int price)
        {
            Console.WriteLine($"pay {price} through paypal...");
        }

        public bool Validate()
        {
            //validate the credit card
            return true; //if it is valid
        }
    }
}
