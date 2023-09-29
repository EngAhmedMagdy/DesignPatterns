using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    class EgyptionResturant : IResturant
    {
        public IOrder CreateOrder()
        {
            return new EgyptionOrder();
        }
    }
}
