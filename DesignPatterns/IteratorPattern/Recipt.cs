using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public class Recipt : Collection
    {
        internal Item[] Items;
        private int Count;
        public Recipt(int size)
        {
            Items = new Item[size];
            Count = 0;
        }

        public void Add(Item item)
        {
            Items[Count++] = item;
        }

        public Iterator GetIterator()
        {
            return new ReciptItrator(this);
        }

        public int Total()
        {
            return Count;
        }
        private int findById(int id)
        {
            for (int i = 0; i < Count; i++)
            {
                if(Items[i].Id == id)
                {
                    return i;
                }
            }
            return 0;
        }
        public void Remove(int id)
        {
            int index = findById(id);
            if (index != 0)
            {
                for (int i = index; i < Count; i++)
                {
                    Items[i] = Items[i + 1];
                }
                Count -= 1;
            }
            
        }
    }
}
