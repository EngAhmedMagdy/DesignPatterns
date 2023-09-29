using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public interface Collection
    {
        void Add(Item item);
        void Remove(int index);
        int Total();
        Iterator GetIterator();
    }
}
