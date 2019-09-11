using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
               new Latte() ,
               new Latte() ,
               new Cortado(), 
               new BlackCoffe()

            };
           

            foreach (var coffee in orderList)
            {
                Console.WriteLine($"the Price of {coffee.Name()} is :{coffee.price()} and the strenght is {coffee.Strength()} " );
            }

            foreach (var cofff in orderList)
            {
                if (cofff is IMilk)
                {
                    Console.WriteLine($"This item of your order {cofff.Name()} contains MILK ");
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
