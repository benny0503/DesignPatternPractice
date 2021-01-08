using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface IOil
    {
        string Name { get; set; }

        public int Amount { get; set; }

        string GetIngredient();
    }
}
