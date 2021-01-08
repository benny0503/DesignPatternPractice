using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make bread start!");

            List<IBread> BreadList = new List<IBread>();

            var CakeFactory = new CakeFactory();
            var ToastFactory = new ToastFactory();

            var Bread = ToastFactory.CreateBread("Peanut butter toast");
            var Bread1 = ToastFactory.CreateBread("Chocolate toast");
            var Bread2 = CakeFactory.CreateBread("Cheesecake");
            var Bread3 = CakeFactory.CreateBread("Strawberry cake");

            BreadList.AddRange(new IBread[] { Bread, Bread1, Bread2, Bread3 });

            foreach (var item in BreadList)
            {
                switch (item)
                {
                    case Toast x:
                        Console.WriteLine(x.GetBreadName());
                        break;

                    case Cake x:
                        Console.WriteLine(x.GetBreadName());
                        Console.WriteLine(x.GetShape());
                        break;
                    default:
                        throw new ArgumentException("Wrong bread type");
                }
            }

        }
    }
}
