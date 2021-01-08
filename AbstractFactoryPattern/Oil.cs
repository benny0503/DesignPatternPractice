using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Oil : IOil
    {
        public string Name { get; set; }

        public int Amount { get; set; }
        
        public string GetIngredient()
        {
            return $"Oil name: {this.Name}\nOil amount:{this.Amount}";
        }
    }
}
