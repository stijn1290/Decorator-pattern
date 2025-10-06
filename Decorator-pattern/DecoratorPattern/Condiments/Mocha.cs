using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double extraCost = 0;
            switch (Size)
            {
                case Size.GRANDE:
                    extraCost += 0.20;
                    break;
                case Size.VENDI:
                    extraCost += 0.40;
                    break;
                case Size.TALL:
                    extraCost += 0.60;
                    break;
                default:
                    break;
            }
            return (0.20 + extraCost) + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Mocha";
        }
    }
}
