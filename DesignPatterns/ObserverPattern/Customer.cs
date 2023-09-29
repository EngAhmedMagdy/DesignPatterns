using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public class Customer : User
    {
        public int id;
        public Customer(int id)
        {
            this.id = id;
        }

        public int Id { 
            get { return id; }
            set { id = value; } 
        }

        public void Notify(string announce)
        {
            Console.WriteLine($"{announce} send to customer {this.id} ..");
        }
    }
}
