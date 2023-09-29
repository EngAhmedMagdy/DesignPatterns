using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    class Offer : Item
    {
        List<Item> items  = new List<Item>();
        public Offer()
        {
        }
        public void AddItem(Item i)
        {
            items.Add(i);
        }
        public int CalculatePrice()
        {
            int total = 0;
            foreach(Item i in items)
            {
                total += i.CalculatePrice();
            }
            return total;
        }
    }
}
