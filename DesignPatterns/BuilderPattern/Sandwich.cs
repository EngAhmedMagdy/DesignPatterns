using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Sandwich
    {
        string Ingredients;
        string Extra;
        string Size;
        internal Sandwich(string ing , string ex, string si)
        {
            this.Ingredients = ing;
            this.Extra = ex;
            this.Size = si;
        }
        public override string ToString()
        {
            return string.Format("ing: {0} , ex: {1} , size: {2}",
            Ingredients, Extra, Size);
        }
        
    }
   
}
