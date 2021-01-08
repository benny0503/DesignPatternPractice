using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Cake : IBread
    {
        public string Name { get; set; }

        public string Shape { get; set; }

        public Cake(string name)
        {
            Name = name;
        }

        public string GetBreadName()
        {
            return $"Cake: {this.Name}";
        }

        public string GetShape()
        {
            return $"Cake's shape:{this.Shape}";
        }
    }
}
