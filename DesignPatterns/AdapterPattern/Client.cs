using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    class Client
    {
         
        public Client()
        {
            XMLData currentData = new XMLData();
            XMLAdapter adapter = new XMLAdapter();
            adapter.DisplayUsers(currentData);
        }
    }
}
