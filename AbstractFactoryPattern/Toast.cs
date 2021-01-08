using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Toast : IBread
    {
        public string Name { get; set; }

        public Toast(string name)
        {
            Name = name;
        }

        public string GetBreadName()
        {
            return $"Toast: {this.Name}";
        }
    }
}
