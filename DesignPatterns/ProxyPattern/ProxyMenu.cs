using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyPattern
{
    public class ProxyMenu : Menu
    {
        // RealMenu is object that the proxy comunicate with
        // the RealMenu is aggregated object since the it can exist independently.
        private RealMenu _realMenu; 
        private string _role;
        public ProxyMenu(RealMenu RealMenu, string role)
        {
            _realMenu = RealMenu;
            _role = role;
        }
        public void PlaceOrder(string item)
        {
            if(_role == "Customer")
            {
                _realMenu.PlaceOrder(item);
            }
            else
            {
                Console.WriteLine("access is denied!");
            }
        }
    }
}
