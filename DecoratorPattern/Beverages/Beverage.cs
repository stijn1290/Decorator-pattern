using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    internal abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        private Size size;

        protected string description = "Unknown";
        protected Beverage baseBeverage = null;
        

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
        protected double applySizeCost(double baseCost)
        {
            switch (Size)
            {
                case Size.GRANDE:
                    return baseCost + 0.20;
                case Size.VENDI:
                    return baseCost + 0.40;
                case Size.TALL:
                    return baseCost + 0.60;
                default:
                    return baseCost;
            }
        }
    }
}
