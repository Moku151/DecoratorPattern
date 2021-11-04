using CoffeeShop.Beverages;
using CoffeeShop.Beverages.Interfaces;

namespace CoffeeShop.Condiments
{
    internal class CondimentBase : IBeverage
    {
        private readonly IBeverage _beverage;

        protected CondimentBase(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public virtual string GetDescription()
        {
            return _beverage.GetDescription();
        }

        public virtual float Cost()
        {
            return _beverage.Cost();
        }
    }
}
