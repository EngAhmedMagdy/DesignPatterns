using DesignPatterns.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creational Patterns
            SingletonPattern.BadPractice b1 = new SingletonPattern.BadPractice();
            Console.WriteLine("----------------");
            SingletonPattern.Client c1 = new SingletonPattern.Client();
            Console.WriteLine("================");
            FactoryMethodPattern.Client c2 = new FactoryMethodPattern.Client();
            Console.WriteLine("================");
            AbstractMethodPattern.Client c3 = new AbstractMethodPattern.Client();
            Console.WriteLine("================");
            BuilderPattern.Client c4 = new BuilderPattern.Client();
            Console.WriteLine("================");

            //Structural Patterns
            Adapter.Client c5 = new Adapter.Client();
            Console.WriteLine("================");
            Composite.Client c6 = new Composite.Client();
            Console.WriteLine("================");
            ProxyPattern.Client c7 = new ProxyPattern.Client();
            Console.WriteLine("================");

            //Behavior Patterns
            ObserverPattern.Client c8 = new ObserverPattern.Client();
            Console.WriteLine("================");
            IteratorPattern.Client c9 = new IteratorPattern.Client();
            Console.WriteLine("================");
            StrategyPattern.Client c10 = new StrategyPattern.Client();
            Console.WriteLine("================");
            Console.ReadKey();
        }
    }
}
