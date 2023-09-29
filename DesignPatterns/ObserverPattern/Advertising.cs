using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public interface Advertising
    {
        void Add(User c);
        void Remove(User c);
        void NotfiyAll(string announce);
    }
}
