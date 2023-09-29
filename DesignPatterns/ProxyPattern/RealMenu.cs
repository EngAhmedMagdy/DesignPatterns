using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyPattern
{
    public class RealMenu : Menu
    {
        public void PlaceOrder(string item)
        {
            Console.WriteLine($"add {item} to orders");
        }
    }
}
