using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Clinet clinet = new Clinet();
            clinet.Main();
        }        
    }

    public class Clinet
    {
        public void Main()
        {
            Console.WriteLine("Make bread start!");

            var cakeMaker = new CakeFactory();
            Console.WriteLine("Cheesecake");
            CreadBread(cakeMaker, 300, 100);
            Console.WriteLine("Strawberry cake");
            CreadBread(cakeMaker, 400, 150);

            var toastMaker = new ToastFactory();
            Console.WriteLine("Chocolate toast");
            CreadBread(toastMaker, 200, 50);
            Console.WriteLine("Penut butter toast");
            CreadBread(toastMaker, 200, 80);
        }

        void CreadBread(Bakery factory, int flourAmount, int oilAmount)
        {
            var flour = factory.CreateFlour(flourAmount);
            var oil = factory.CreateOli(oilAmount);
            Console.WriteLine("---");
            Console.WriteLine(flour.GetIngredient());
            Console.WriteLine(oil.GetIngredient());
            Console.WriteLine("---");
        }
    }
}
