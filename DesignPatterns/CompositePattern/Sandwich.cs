using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    class Sandwich : Item
    {
        int price;
        public Sandwich(int price)
        {
            this.price = price;
        }
        public int CalculatePrice()
        {
            return price;
        }
    }
}
