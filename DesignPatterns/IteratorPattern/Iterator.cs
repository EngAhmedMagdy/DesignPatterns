using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public interface Iterator
    {
        Item GetNext();
        Item GetCurrent();
        bool HasNext();
        void Reset();
    }
}
