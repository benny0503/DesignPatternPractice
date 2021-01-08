using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ToastFactory : Bakery
    {
        public override IBread CreateBread(string name)
        {
            return new Toast(name);
        }
    }
}
