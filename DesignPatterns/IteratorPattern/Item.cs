using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Item(int id,string name)
        {
            Id = id;
            Name = name;
        }
    }
}
