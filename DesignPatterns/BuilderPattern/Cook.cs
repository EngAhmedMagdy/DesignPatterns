using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Cook
    {
        string Ingredients;
        string Extra;
        string Size;
        public Cook SetIngredients(string str)
        {
            Ingredients = str;
            return this;
        }
        public Cook SetSize(string str)
        {
            Size = str;
            return this;
        }
        public Cook SetExtra(string str)
        {
            Extra = str;
            return this;
        }
        public Sandwich Build()
        {
            return new Sandwich(Ingredients, Extra, Size);
        }
    }
}
