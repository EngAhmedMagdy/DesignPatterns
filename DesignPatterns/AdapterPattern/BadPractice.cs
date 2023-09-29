using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    class BadPractice
    {
        public BadPractice()
        {
            XMLData currentData = new XMLData();
            OldUI data = new OldUI();
            data.DisplayUsers(currentData);
            ModernUI service = new ModernUI();
            //service.DisplayUsers(xml);
            //here the problem
        }
    }
}
