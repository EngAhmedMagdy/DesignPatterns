using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public interface PaymentMethod
    {
        void Pay(int price);
        bool Validate();
    }
}
