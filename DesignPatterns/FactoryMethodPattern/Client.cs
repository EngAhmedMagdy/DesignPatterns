using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    public class Client
    {
        public Client()
        {

            IResturant res = Location("Egypt");
            IOrder makeOrder = res.CreateOrder();
            makeOrder.Cook();
        }
        public IResturant Location(string location)
        {
            //even though this code looks like it open for modification its acutaly fine since
            //this code considered as the program configuration and can be easily changed accordingly.
            //and we already solved the problem of closed/open in the core design of the application.
            if(location == "Egypt")
            {
                return new EgyptionResturant();
            }
            else if(location == "Italian")
            {
                return new ItalianResturant();
            }
            return null;
        }
    }
}
