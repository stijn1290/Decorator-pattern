using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Water : Beverage
    {
        public Water(Beverage beverage = null)
        {
            description = "Water";
            this.baseBeverage = beverage;

        }
        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
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
            double baseCost = 0.50;
            if (baseBeverage != null)
            {
                double cost = baseCost + extraCost;
                return cost += baseBeverage.cost();
            }
            return baseCost + extraCost;
        }
    }
}
