using CoffeeShop.Interfaces;

namespace CoffeeShop.Condiments
{
    internal class Whip : CondimentBase
    {
        public Whip(IBeverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, Whip";
        }

        public override float Cost()
        {
            return base.Cost() + 0.2f;
        }
    }
}
