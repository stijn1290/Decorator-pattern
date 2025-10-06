using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Cream : CondimentDecorator
    {
        public Cream(Beverage beverage)
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
            return (extraCost + 0.30) + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Cream";
        }
    }
}
