using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractMethodPattern
{
    class ClassicEgyptionResturant : IResturant
    {
        public IOrder CreateOrder()
        {
            return new EgyptionOrder();
        }

        public IPrepare PrepareOrder()
        {
            return new ClassicPrepare();
        }
    }
}
