using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class CakeFactory : Bakery
    {
        public override IBread CreateBread(string name)
        {
            Cake cake = new Cake(name);

            if (name == "Cheesecake")
            {
                cake.Shape = "square";
            }
            else
            {
                cake.Shape = "round";
            }

            return cake;
        }

        public override IFlour CreateFlour(int amount)
        {
            IFlour flour = new Flour();
            flour.Name = "cake flour";
            flour.Amount = amount;
            return flour;
        }

        public override IOil CreateOli(int amount)
        {
            IOil oil = new Oil();
            oil.Name = "butter";
            oil.Amount = amount;
            return oil;
        }
    }
}
