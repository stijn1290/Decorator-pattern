using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Stores;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeStore starrbuzzcoffee = new StarbuzzCoffeeStore();
            foreach (var item in starrbuzzcoffee.MenuItems)
            {
                starrbuzzcoffee.OrderCoffee(item);
            }
        }
    }
}