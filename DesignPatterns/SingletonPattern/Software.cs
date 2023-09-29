using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class Software
    {
        private List<string> data;
        public Software()
        {
            Console.WriteLine("Clear and start fresh");
            data = new List<string>(10);
        }
        public void Add(string str)
        {
            data.Add(str);
        }
        public void Print()
        {
            foreach (var str in data)
            {
                Console.WriteLine(str);
            }

        }
    }
}
