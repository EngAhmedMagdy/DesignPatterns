using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class BadPractice
    {
        public BadPractice()
        {
            Software software;
            software = OpenSoftware();
            Cashir.OpenSoftware().Add("order1");
            Cashir.OpenSoftware().Add("order2");
            Cashir.OpenSoftware().Print();
            software = OpenSoftware();
            Cashir.OpenSoftware().Add("order3");
            Cashir.OpenSoftware().Add("order4");
            Cashir.OpenSoftware().Print();
        }
        public static Software OpenSoftware()
        {
            Console.WriteLine("install the software");
            return new Software();
        }
    }
}
