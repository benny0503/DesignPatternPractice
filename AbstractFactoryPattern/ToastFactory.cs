using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ToastFactory : Bakery
    {
        public override IBread CreateBread(string name)
        {
            return new Toast(name);
        }

        public override IFlour CreateFlour(int amount)
        {
            IFlour flour = new Flour();
            flour.Name = "Toast flour";
            flour.Amount = amount;
            return flour;
        }

        public override IOil CreateOli(int amount)
        {
            IOil oil = new Oil();
            oil.Name = "oliver oil";
            oil.Amount = amount;
            return oil;
        }
    }
}
