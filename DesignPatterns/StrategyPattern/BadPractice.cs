using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    class BadPractice
    {
        //this class is open for modification and closed for extention which is a problem
        private int price;
        public BadPractice()
        {
            ProcessOrder("CreditCard");
        }
        public void ProcessOrder(string paymentMethod)
        {
            
            if (paymentMethod == "CreditCard")
            {
                new CreditCard().Pay(price);
            }
            else if (paymentMethod == "PayPal")
            {
                new PayPal().Pay(price);
            }
        }
        public void SetPrice(int p)
        {
            price = p;
        }
    }
}
