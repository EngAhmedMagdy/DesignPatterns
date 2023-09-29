using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    class ReciptItrator : Iterator
    {
        private Recipt _Recipt;
        private int CurrentIndex;
        public ReciptItrator(Recipt Recipt)
        {
            _Recipt = Recipt;
            CurrentIndex = 0;
        }

        public void Reset()
        {
            CurrentIndex = 0;
        }

        public bool HasNext()
        {
            return _Recipt.Total() > CurrentIndex;
        }

        public Item GetCurrent()
        {
            return _Recipt.Items[CurrentIndex];
        }

        public Item GetNext()
        {
            return _Recipt.Items[CurrentIndex++];
        }
    }
}
