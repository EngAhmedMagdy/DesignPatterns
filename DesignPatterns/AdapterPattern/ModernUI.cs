using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class ModernUI : ModernUIResturant
    {
        //configue this code to work with xml is not ideal since
        //1- the source good might be available to modifiy it.
        //2- might break the code.
        //3- might need the json format later.
        public void DisplayUsers(JSONData data)
        {
            Console.WriteLine("drawing UI using json data ...");
        }
    }
}
