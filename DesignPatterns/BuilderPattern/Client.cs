using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    class Client
    {
        public Client()
        {
            Cook cook = new Cook();
            Chef chef = new Chef();
            chef.CheeseSandwich(cook);
            Sandwich s = cook.Build();
            Console.Write(s.ToString());
        }
    }
}
