using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractMethodPattern
{
    class BadPractice
    {
        public Service createDeliverOrder()
        {
            return new ItalianResturant().order("classic");
        }
        public abstract class ResturantFacotry
        {
            public Service order(string typr)
            {
                Service o = CreateOrder(typr);
                o.Cook();
                return o;
            }

            protected abstract Service CreateOrder(string type);
        }
        public interface Service
        {
            void Cook();
        }
        public class prepareService : Service
        {
            public void Cook()
            {
                throw new NotImplementedException();
            }
        }
        public class OrderService : Service
        {
            public void Cook()
            {
                throw new NotImplementedException();
            }
        }
        public class ItalianResturant : ResturantFacotry
        {
            //this code is open for modification and close for extension.
            //it violate the open/close principle.
            protected override Service CreateOrder(string type)
            {
                Service o = null;
                if(type == "prepare")
                {
                    o = new prepareService();
                }
                else if(type == "order")
                {
                    o = new OrderService();
                }
                return o ;
            }
        }
    }
}
