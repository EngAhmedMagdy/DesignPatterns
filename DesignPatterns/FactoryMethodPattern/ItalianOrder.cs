using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    public class ItalianOrder : IOrder
    {
        public void Cook()
        {
            Console.WriteLine("cook pizza");
        }
    }
}
