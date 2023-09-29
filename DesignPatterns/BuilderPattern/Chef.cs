using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Chef
    {
        public void CheeseSandwich(Cook cook)
        {
                cook
                .SetExtra("Tomato")
                .SetIngredients("Cheese")
                .SetSize("Medium");
        }
        public void ShowrmaSandwich(Cook cook)
        {
            cook
            .SetExtra("swos")
            .SetIngredients("Showrma")
            .SetSize("BIG");
        }
    }
}
