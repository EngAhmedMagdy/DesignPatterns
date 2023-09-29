using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    class BadPractice
    {
        public IOrder createDeliverOrder(string typeOfResturant)
        {
            //this code is open for modification and close for extension.
            //it violate the open/close principle.
            //it violate the single responsibilty priciple.
            IOrder o = null;
            if (typeOfResturant == "Italian")
            {
                o = new ItalianOrder();
            }
            if (typeOfResturant == "Egyption")
            {
                o = new EgyptionOrder();
            }
            o.Cook();
            return o;
        }
        public class ResturantFacotry
        {
            //this code is open for modification and close for extension.
            //it violate the open/close principle.
            public IOrder CreateOrder(string typeOfResturant)
            {
                IOrder o = null;
                if (typeOfResturant == "Italian")
                {
                    o = new ItalianOrder();
                }
                if (typeOfResturant == "Egyption")
                {
                    o = new EgyptionOrder();
                }
                return o;
            }
        }
    }
}
