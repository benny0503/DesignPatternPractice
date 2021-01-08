using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public abstract class Bakery
    {
        public abstract IBread CreateBread(string name);

        public abstract IFlour CreateFlour(int amount);

        public abstract IOil CreateOli(int amount);
    }
}
