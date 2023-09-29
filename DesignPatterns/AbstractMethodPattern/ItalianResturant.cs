using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractMethodPattern
{
    public class ClassicItalianResturant : IResturant
    {
        public IOrder CreateOrder()
        {
            return new ItalianOrder();

        }

        public IPrepare PrepareOrder()
        {
            return new ClassicPrepare();
        }
    }
}
