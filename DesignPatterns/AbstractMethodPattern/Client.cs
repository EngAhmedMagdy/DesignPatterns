using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractMethodPattern
{
    public class Client
    {
        public Client()
        {
            ClassicItalianResturant abstractFacotry = new ClassicItalianResturant();
            IPrepare prepare = abstractFacotry.PrepareOrder();
            IOrder order = abstractFacotry.CreateOrder();
            order.Cook();
            prepare.Method();
        }
    }
}
