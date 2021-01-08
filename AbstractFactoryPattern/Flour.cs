using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Flour : IFlour
    {
        public string Name { get; set; }

        public int Amount { get; set; }
        
        public string GetIngredient()
        {
            return $"Flour name: {this.Name}\nFlour amount:{this.Amount}";
        }
    }
}
