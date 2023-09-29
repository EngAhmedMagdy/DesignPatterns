using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    class Client
    {
        //composite : compose objects to a tree structure to represent part-whole hierarchies.
        public Client()
        {
            Sandwich s1 = new Sandwich(10);
            Console.WriteLine("Total price order 1 : {0}" ,s1.CalculatePrice());
            Sandwich s2 = new Sandwich(15);
            Console.WriteLine("Total price order 2 : {0}", s2.CalculatePrice());
            Offer offer1 = new Offer();
            offer1.AddItem(s1);
            offer1.AddItem(s2);
            Console.WriteLine("Total price order 3 : {0}", offer1.CalculatePrice());
            Offer offer2 = new Offer();
            offer2.AddItem(s1);
            offer2.AddItem(offer1);
            Console.WriteLine("Total price order 4 : {0}", offer2.CalculatePrice());
        }
    }
}
