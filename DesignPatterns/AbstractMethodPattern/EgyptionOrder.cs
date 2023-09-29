﻿using DesignPatterns.FactoryMethodPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractMethodPattern
{
    public class EgyptionOrder : IOrder
    {
        public void Cook()
        {
            Console.WriteLine("cook koshry");
        }
    }
}
