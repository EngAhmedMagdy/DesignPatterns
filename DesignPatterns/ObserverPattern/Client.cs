using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    class Client
    {
        public Client()
        {
            Customer C1 = new Customer(1);
            Customer C2 = new Customer(2);
            SocialMedia social = new SocialMedia();
            social.Add(C1);
            social.Add(C2);
            //a new sale announcement so we want to notify customers..
            string announce1 = "new offer1";
            social.NotfiyAll(announce1);
            social.Remove(C1);
            //later.. another new sale announcement so we want to notify customers..
            string announce2 = "new offer2";
            social.NotfiyAll(announce2);
        }
    }
}
