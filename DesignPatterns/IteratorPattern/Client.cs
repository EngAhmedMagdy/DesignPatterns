using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public class Client
    {
        public Client()
        {
            Item i1 = new Item(1, "cheese cake");
            Item i2 = new Item(2, "kfc burger");
            Item i3 = new Item(3, "pizza hut");
            Collection recipt = new Recipt(10);
            recipt.Add(i1);
            recipt.Add(i2);
            recipt.Add(i3);
            Iterator it = recipt.GetIterator();
            while(it.HasNext())
            {
                Console.WriteLine($"{it.GetCurrent().Id} + {it.GetCurrent().Name}");
                it.GetNext();
            }
            
            recipt.Remove(i2.Id);
            it.Reset();
            while (it.HasNext())
            {
                Console.WriteLine($"{it.GetCurrent().Id} + {it.GetCurrent().Name}");
                it.GetNext();
            }
        }
    }
}
