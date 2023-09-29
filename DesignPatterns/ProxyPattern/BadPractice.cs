using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyPattern
{
    class BadPractice
    {
        public BadPractice()
        {
            //we need a design that allow the place order method to be called based on given role.
            string UserRole1 = "Customer";
            string UserRole2 = "Cook";
            RealMenu realMenu = new RealMenu();
            realMenu.PlaceOrder("chiken");
            
        }
    }
}
