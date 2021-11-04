using CoffeeShop.Beverages;
using CoffeeShop.Beverages.Interfaces;

namespace CoffeeShop.Condiments
{
    internal class Soy : CondimentBase
    {
        public Soy(IBeverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, Soy";
        }

        public override float Cost()
        {
            return base.Cost() + 0.15f;
        }
    }
}
