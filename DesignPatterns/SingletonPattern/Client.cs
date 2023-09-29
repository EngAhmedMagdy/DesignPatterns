using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    class Client
    {
        public Client()
        {
            Cashir.OpenSoftware().Add("order1");
            Cashir.OpenSoftware().Add("order2");
            Cashir.OpenSoftware().Print();
            Cashir.OpenSoftware().Add("order3");
            Cashir.OpenSoftware().Add("order4");
            Cashir.OpenSoftware().Print();
        }
        
        
    }
}
