using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class OldUI : OldUIResturnat
    {
        public void DisplayUsers(XMLData xml)
        {
            Console.WriteLine("draw old ui using xml..");
        }

    }
}
