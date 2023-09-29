using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyPattern
{
    public class Client
    {
        public Client()
        {
            string UserRole1 = "Customer";
            string UserRole2 = "Cook";
            RealMenu realMenu = new RealMenu();
            //using the customer role
            ProxyMenu proxyMenu1 = new ProxyMenu(realMenu, UserRole1);
            proxyMenu1.PlaceOrder("chiken");
            //using the cook role
            ProxyMenu proxyMenu2 = new ProxyMenu(realMenu, UserRole2);
            proxyMenu2.PlaceOrder("chiken");
        }
    }
}
