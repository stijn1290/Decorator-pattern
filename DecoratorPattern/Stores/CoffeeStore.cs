using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Stores
{
    internal abstract class CoffeeStore
    {
        public abstract List<string> MenuItems {  get;}
        public abstract Beverage CreateCoffee(string coffeeType);
       
        public void OrderCoffee (string type)
        {
            Beverage beverage = CreateCoffee(type);
            PrintBeverage(beverage);
        }
        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}
