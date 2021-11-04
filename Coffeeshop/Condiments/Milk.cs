using CoffeeShop.Beverages;
using CoffeeShop.Beverages.Interfaces;

namespace CoffeeShop.Condiments
{
    internal class Milk : CondimentBase
    {
        public Milk(IBeverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, Milk";
        }

        public override float Cost()
        {
            return base.Cost() + 0.1f;
        }
    }
}
