using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class Cashir
    {
        private static Software UniqueInstance;
        public static Software OpenSoftware()
        {
            if(UniqueInstance == null )
            {
                Console.WriteLine("install the software");
                UniqueInstance = new Software();
            }
            return UniqueInstance;
        }
        
        
    }
}
