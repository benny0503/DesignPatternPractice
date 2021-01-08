using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class Bakery
    {
        public abstract IBread CreateBread(string name);
    }
}
