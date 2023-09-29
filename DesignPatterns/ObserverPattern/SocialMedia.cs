using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public class SocialMedia : Advertising
    {
        List<User> customers;
        public SocialMedia()
        {
            customers = new List<User>();
        }
        public void Add(User c)
        {
            Console.WriteLine($"Add User {c.Id}");
            customers.Add(c);
        }
        public void Remove(User c)
        {
            Console.WriteLine($"Remove User {c.Id}");
            customers.Remove(c);
        }
        public void NotfiyAll(string announce)
        {
            foreach(Customer i in customers)
            {
                i.Notify(announce);
            }
        }
    }
}
